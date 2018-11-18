using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logoblib;

namespace GraphsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddRib('A', 'B', 10);
            graph.AddRib('A', 'C', 15);
            graph.AddRib('B', 'B', 33);
            graph.AddRib('B', 'C', 1);
            graph.writeMatrix();
            graph.AlgorithmKruskal().writeMatrix();
        }
    }
}
