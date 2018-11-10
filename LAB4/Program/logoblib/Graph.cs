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

        // PUBLIC:
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

        // REVIEW
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
                Console.Write("{0}\t", tops[i].Name);
            }
            Console.WriteLine();
            for (i = 0; i < matrix.Count; i++)
            {
                Console.Write("{0}\t", tops[i].Name);
                for (j = 0; j < matrix[i].Count; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }

        // CRASKYL ALGORISM
        public Graph AlgorithmKruskal()
        {
            Graph resultGraph = new Graph();
            List<Rib> sortRibs = new List<Rib>();

            for (int i = 0; i < this.ribs.Count; i++)
                sortRibs.Add(this.ribs[i]);
            sortRibs.Sort((a, b) => a.ValuePrice.CompareTo(b.ValuePrice));

            for (int i = 0; i < this.tops.Count; i++)
                resultGraph.AddTop(this.tops[i].Name);


            //for (int i = 0; i < sortRibs.Count; i++)
            //    Console.WriteLine("{0} ", sortRibs[i].ValuePrice);

            for (int i = 0; i < sortRibs.Count; i++)
            {
                resultGraph.AddRib(sortRibs[i].StartTop.Name, sortRibs[i].EndTop.Name,
                    sortRibs[i].ValuePrice); // !!!!!!!!
                if (resultGraph.loopCheck()) resultGraph.DeleteRig(i);
            }



            return resultGraph;
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
            int i, j, k;

            for (i = 0; i < this.ribs.Count; i++)
            {
                for (j = 0; j < this.ribs.Count; j++)
                {
                    if (i == j)
                        continue;
                    for (k = 0; k < this.ribs.Count; k++)
                    {
                        if (k == j || k == i)
                            continue;
                        if (ribs[i].checkJointTops(ribs[j]) && ribs[i].checkJointTops(ribs[k]))
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
