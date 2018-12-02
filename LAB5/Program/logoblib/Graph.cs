using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logoblib
{
    public class Graph
    {
        private List<Top> tops;
        private List<Rib> ribs;
        private List<List<int>> matrix;


        // CONSTRUCTORS:
        public Graph()
        {
            tops = new List<Top>();
            ribs = new List<Rib>();
            matrix = new List<List<int>>();
        }

        public List<int> AlgorithmDijkstra(char top_name)
        {
            List<int> distance = new List<int>();
            List<bool> visited = new List<bool>();
            int top_index = findTopInGraph(top_name);
            int tops_count = this.tops.Count;

            for (int i = 0; i < tops_count; i++)
            {
                distance.Add(int.MaxValue);
                visited.Add(false);
            }
            distance[top_index] = 0;

            int min, k, a, temp;

            do
            {
                k = min = int.MaxValue;

                for (int i = 0; i < tops_count; i++)
                {
                    if ((visited[i] == false) && (distance[i] < min))
                    {
                        min = distance[i];
                        k = i;
                    }
                }

                if (k != int.MaxValue)
                {
                    for (int i = 0; i < tops_count; i++)
                    {

                        if ((temp = (findRibInGraph(tops[k].Name, tops[i].Name) == -1) ? 0 : ribs[findRibInGraph(tops[k].Name, tops[i].Name)].ValuePrice) > 0)
                        {
                            a = min + temp;
                            if (a < distance[i])
                            {
                                distance[i] = a;
                            }
                        }
                    }
                    visited[k] = true;
                }
            } while (k < int.MaxValue);

            return distance;
        }

        public void AddTop(char name)
        {
            // Check top with eqivalenth name
            if (findTopInGraph(name) != -1)
                return;

            int i, j;
            tops.Add(new Top(name));

            for (i = 0; i < matrix.Count; i++)
            {
                matrix[i].Add(0);
            }
            matrix.Add(new List<int>());
            for (j = 0; j < matrix.Count; j++)
            {
                matrix[matrix.Count - 1].Add(0);
            }
        }

        public void DeleteTop(char name)
        {
            int i = findTopInGraph(name), j;
            if (i == -1)
                return;

            List<int> listRigsIndexes = findRibInGraph(name);

            for (j = 0; j < listRigsIndexes.Count; j++)
                DeleteRig(listRigsIndexes[j]);

            tops.RemoveAt(i);
            matrix.RemoveAt(i);
            for (j = 0; j < matrix.Count; j++)
                matrix[j].RemoveAt(i);
        }

        public void AddRib(char start_top_name, char end_top_name, int valuePrice)
        {
            int i, j;

            AddTop(start_top_name);
            AddTop(end_top_name);

            i = findTopInGraph(start_top_name);
            j = findTopInGraph(end_top_name);

            ribs.Add(new Rib(tops[i], tops[j], valuePrice));
            matrix[i][j] = matrix[j][i] = valuePrice;
        }

        public void DeleteRig(char top_start_name, char top_end_name)
        {
            int i = findRibInGraph(top_start_name, top_end_name), j;
            if (i == -1)
                return;

            ribs.RemoveAt(i);

            int q, p;
            matrix[q = findTopInGraph(top_start_name)][p = findTopInGraph(top_end_name)] = matrix[p][q] = 0;
        }

        public void DeleteRig(int index)
        {
            if (index >= ribs.Count || index < 0)
                return;

            int q, p;
            matrix[q = findTopInGraph(ribs[index].StartTop.Name)][p = findTopInGraph(ribs[index].EndTop.Name)] = matrix[p][q] = 0;
            ribs.RemoveAt(index);
        }

        public void writeMatrix()
        {
            int i, j;

            Console.Write('\t');
            for (i = 0; i < matrix.Count; i++)
            {
                Console.Write("|{0}\t", tops[i].Name);
            }
            Console.WriteLine();
            for (i = 0; i < matrix.Count; i++)
            {
                Console.Write("________");
            }
            Console.WriteLine();
            for (i = 0; i < matrix.Count; i++)
            {
                Console.Write("{0}\t|", tops[i].Name);
                for (j = 0; j < matrix[i].Count; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i = 0; i < matrix.Count; i++)
            {
                Console.Write("--------");
            }
            Console.WriteLine('\n');
        }

        //PRIVATE:
        private int findTopInGraph(char name)
        {
            for (int i = 0; i < tops.Count; i++)
                if (tops[i].Name == name)
                    return i;
            return -1;
        }

        private int findRibInGraph(char start_name_top, char end_name_top)
        {
            for (int i = 0; i < ribs.Count; i++)
                if ((ribs[i].StartTop.Name == start_name_top && ribs[i].EndTop.Name == end_name_top)
                    || (ribs[i].StartTop.Name == end_name_top && ribs[i].EndTop.Name == start_name_top))
                    return i;
            return -1;
        }
        private List<int> findRibInGraph(char name_top)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < ribs.Count; i++)
                if (ribs[i].StartTop.Name == name_top || ribs[i].EndTop.Name == name_top)
                    indexes.Add(i);

            return indexes;
        }

        private bool loopCheck()
        {
            if (this.tops.Count < 3) return false;
            Graph temp = new Graph();

            for (int i = 0; i < this.ribs.Count; i++)
            {
                temp.AddRib(this.ribs[i].StartTop.Name, this.ribs[i].EndTop.Name, this.ribs[i].ValuePrice);
            }

            for (int key = temp.tops.Count; ;)
            {

                for (int i = 0; i < temp.tops.Count; i++)
                {
                    if (temp.searchDegree(temp.tops[i].Name) < 2)
                        temp.DeleteTop(temp.tops[i].Name);
                }

                if (temp.tops.Count == 0)
                    return false;
                if (key == temp.tops.Count)
                    return true;
                else
                    key = temp.tops.Count;
            }
        }

        private int searchDegree(char top_name)
        {
            int result = 0;

            for (int i = 0; i < this.ribs.Count; i++)
            {
                if (this.ribs[i].StartTop.Name == top_name)
                    result++;
                if (this.ribs[i].EndTop.Name == top_name)
                    result++;
            }
            return result;
        }

        List<int> searchForNeighboringVertices(char top_name)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < this.ribs.Count; i++)
            {
                if (ribs[i].EndTop.Name == top_name)
                    result.Add(this.findTopInGraph(ribs[i].StartTop.Name));
                if (ribs[i].StartTop.Name == top_name)
                    result.Add(this.findTopInGraph(ribs[i].EndTop.Name));
            }

            return result;
        }
    }
}
