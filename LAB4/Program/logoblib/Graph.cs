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

        public void DeleteTop(char name)
        {
            int i = findTopInGraph(name), j;
            if (i == -1)
                return;

            tops.RemoveAt(i);
            matrix.RemoveAt(i);
            for (j = 0; j < matrix.Count; j++)
                matrix[i].RemoveAt(i);
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

        public void DeleteRig(char top_name)
        {

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

        //// CRASKYL ALGORISM
        //public Graph AlgorismCrascal()
        //{
        //
        //}

        // PRIVATE:
        // Return -1 if element not found
        private int findTopInGraph(char name)
        {
            for (int i = 0; i < tops.Count; i++)
                if (tops[i].Name == name)
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
    }
}
