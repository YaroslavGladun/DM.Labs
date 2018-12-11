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
        static void printList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine("[V0 - V{0}] = {1}", i, list[i]);

        }

        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddTop((char)(0 + 64));
            graph.AddTop((char)(1 + 64));
            graph.AddTop((char)(2 + 64));
            graph.AddTop((char)(3 + 64));
            graph.AddTop((char)(4 + 64));
            graph.AddTop((char)(5 + 64));
            graph.AddTop((char)(6 + 64));
            graph.AddTop((char)(7 + 64));
            graph.AddTop((char)(8 + 64));
            graph.AddTop((char)(9 + 64));
            graph.AddTop((char)(10 + 64));
            graph.AddTop((char)(11 + 64));
            graph.AddTop((char)(12 + 64));
            graph.AddTop((char)(13 + 64));
            graph.AddTop((char)(14 + 64));
            graph.AddTop((char)(15 + 64));
            graph.AddTop((char)(16 + 64));
            graph.AddTop((char)(17 + 64));
            graph.AddTop((char)(18 + 64));
            graph.AddTop((char)(19 + 64));
            graph.AddTop((char)(20 + 64));
            graph.AddTop((char)(21 + 64));
            graph.AddTop((char)(22 + 64));
            graph.AddTop((char)(23 + 64));
            graph.AddTop((char)(24 + 64));
            graph.AddTop((char)(25 + 64));
            graph.AddTop((char)(26 + 64));
            graph.AddTop((char)(27 + 64));
            graph.AddTop((char)(28 + 64));
            graph.AddTop((char)(29 + 64));

            graph.AddRib((char)(0 + 64), (char)(1 + 64), 7);
            graph.AddRib((char)(1 + 64), (char)(2 + 64), 5);
            graph.AddRib((char)(2 + 64), (char)(3 + 64), 3);
            graph.AddRib((char)(3 + 64), (char)(4 + 64), 8);
            graph.AddRib((char)(4 + 64), (char)(5 + 64), 5);

            graph.AddRib((char)(6 + 64), (char)(7 + 64), 7);
            graph.AddRib((char)(7 + 64), (char)(8 + 64), 3);
            graph.AddRib((char)(8 + 64), (char)(9 + 64), 1);
            graph.AddRib((char)(9 + 64), (char)(10 + 64), 2);
            graph.AddRib((char)(10 + 64), (char)(11 + 64), 2);

            graph.AddRib((char)(12 + 64), (char)(13 + 64), 3);
            graph.AddRib((char)(13 + 64), (char)(14 + 64), 8);
            graph.AddRib((char)(14 + 64), (char)(15 + 64), 8);
            graph.AddRib((char)(15 + 64), (char)(16 + 64), 7);
            graph.AddRib((char)(16 + 64), (char)(17 + 64), 7);

            graph.AddRib((char)(18 + 64), (char)(19 + 64), 1);
            graph.AddRib((char)(19 + 64), (char)(20 + 64), 3);
            graph.AddRib((char)(20 + 64), (char)(21 + 64), 1);
            graph.AddRib((char)(21 + 64), (char)(22 + 64), 1);
            graph.AddRib((char)(22 + 64), (char)(23 + 64), 5);

            graph.AddRib((char)(24 + 64), (char)(25 + 64), 3);
            graph.AddRib((char)(25 + 64), (char)(26 + 64), 3);
            graph.AddRib((char)(26 + 64), (char)(27 + 64), 4);
            graph.AddRib((char)(27 + 64), (char)(28 + 64), 3);
            graph.AddRib((char)(28 + 64), (char)(29 + 64), 1);

            graph.AddRib((char)(0 + 64), (char)(0 + 6 + 64), 4);
            graph.AddRib((char)(1 + 64), (char)(1 + 6 + 64), 3);
            graph.AddRib((char)(2 + 64), (char)(2 + 6 + 64), 3);
            graph.AddRib((char)(3 + 64), (char)(3 + 6 + 64), 4);
            graph.AddRib((char)(4 + 64), (char)(4 + 6 + 64), 1);
            graph.AddRib((char)(5 + 64), (char)(5 + 6 + 64), 1);

            graph.AddRib((char)(6 + 64), (char)(6 + 6 + 64), 2);
            graph.AddRib((char)(7 + 64), (char)(7 + 6 + 64), 1);
            graph.AddRib((char)(8 + 64), (char)(8 + 6 + 64), 7);
            graph.AddRib((char)(9 + 64), (char)(9 + 6 + 64), 4);
            graph.AddRib((char)(10 + 64), (char)(10 + 6 + 64), 1);
            graph.AddRib((char)(11 + 64), (char)(11 + 6 + 64), 7);

            graph.AddRib((char)(12 + 64), (char)(12 + 6 + 64), 1);
            graph.AddRib((char)(13 + 64), (char)(13 + 6 + 64), 5);
            graph.AddRib((char)(14 + 64), (char)(14 + 6 + 64), 6);
            graph.AddRib((char)(15 + 64), (char)(15 + 6 + 64), 6);
            graph.AddRib((char)(16 + 64), (char)(16 + 6 + 64), 7);
            graph.AddRib((char)(17 + 64), (char)(17 + 6 + 64), 7);

            graph.AddRib((char)(18 + 64), (char)(18 + 6 + 64), 4);
            graph.AddRib((char)(19 + 64), (char)(19 + 6 + 64), 2);
            graph.AddRib((char)(20 + 64), (char)(20 + 6 + 64), 3);
            graph.AddRib((char)(21 + 64), (char)(21 + 6 + 64), 8);
            graph.AddRib((char)(22 + 64), (char)(22 + 6 + 64), 1);
            graph.AddRib((char)(23 + 64), (char)(23 + 6 + 64), 2);

            //graph.AddRib((char)(0 + 64), (char)(1 + 64), 7);
            //graph.AddRib((char)(1 + 64), (char)(2 + 64), 5);
            //graph.AddRib((char)(2 + 64), (char)(3 + 64), 1);
            //graph.AddRib((char)(3 + 64), (char)(4 + 64), 7);
            //graph.AddRib((char)(4 + 64), (char)(5 + 64), 7);
            //
            //graph.AddRib((char)(6 + 64), (char)(7 + 64), 1);
            //graph.AddRib((char)(7 + 64), (char)(8 + 64), 1);
            //graph.AddRib((char)(8 + 64), (char)(9 + 64), 6);
            //graph.AddRib((char)(9 + 64), (char)(10 + 64), 1);
            //graph.AddRib((char)(10 + 64), (char)(11 + 64), 5);
            //
            //graph.AddRib((char)(12 + 64), (char)(13 + 64), 5);
            //graph.AddRib((char)(13 + 64), (char)(14 + 64), 1);
            //graph.AddRib((char)(14 + 64), (char)(15 + 64), 5);
            //graph.AddRib((char)(15 + 64), (char)(16 + 64), 8);
            //graph.AddRib((char)(16 + 64), (char)(17 + 64), 5);
            //
            //graph.AddRib((char)(18 + 64), (char)(19 + 64), 3);
            //graph.AddRib((char)(19 + 64), (char)(20 + 64), 8);
            //graph.AddRib((char)(20 + 64), (char)(21 + 64), 5);
            //graph.AddRib((char)(21 + 64), (char)(22 + 64), 5);
            //graph.AddRib((char)(22 + 64), (char)(23 + 64), 8);
            //
            //graph.AddRib((char)(24 + 64), (char)(25 + 64), 1);
            //graph.AddRib((char)(25 + 64), (char)(26 + 64), 2);
            //graph.AddRib((char)(26 + 64), (char)(27 + 64), 2);
            //graph.AddRib((char)(27 + 64), (char)(28 + 64), 7);
            //graph.AddRib((char)(28 + 64), (char)(29 + 64), 1);
            //
            //graph.AddRib((char)(0 + 64), (char)(0 + 6 + 64), 1);
            //graph.AddRib((char)(1 + 64), (char)(1 + 6 + 64), 2);
            //graph.AddRib((char)(2 + 64), (char)(2 + 6 + 64), 2);
            //graph.AddRib((char)(3 + 64), (char)(3 + 6 + 64), 7);
            //graph.AddRib((char)(4 + 64), (char)(4 + 6 + 64), 7);
            //graph.AddRib((char)(5 + 64), (char)(5 + 6 + 64), 2);
            //
            //graph.AddRib((char)(6 + 64), (char)(6 + 6 + 64), 2);
            //graph.AddRib((char)(7 + 64), (char)(7 + 6 + 64), 7);
            //graph.AddRib((char)(8 + 64), (char)(8 + 6 + 64), 7);
            //graph.AddRib((char)(9 + 64), (char)(9 + 6 + 64), 5);
            //graph.AddRib((char)(10 + 64), (char)(10 + 6 + 64), 6);
            //graph.AddRib((char)(11 + 64), (char)(11 + 6 + 64), 1);
            //
            //graph.AddRib((char)(12 + 64), (char)(12 + 6 + 64), 7);
            //graph.AddRib((char)(13 + 64), (char)(13 + 6 + 64), 3);
            //graph.AddRib((char)(14 + 64), (char)(14 + 6 + 64), 3);
            //graph.AddRib((char)(15 + 64), (char)(15 + 6 + 64), 7);
            //graph.AddRib((char)(16 + 64), (char)(16 + 6 + 64), 8);
            //graph.AddRib((char)(17 + 64), (char)(17 + 6 + 64), 3);
            //
            //graph.AddRib((char)(18 + 64), (char)(18 + 6 + 64), 2);
            //graph.AddRib((char)(19 + 64), (char)(19 + 6 + 64), 7);
            //graph.AddRib((char)(20 + 64), (char)(20 + 6 + 64), 3);
            //graph.AddRib((char)(21 + 64), (char)(21 + 6 + 64), 1);
            //graph.AddRib((char)(22 + 64), (char)(22 + 6 + 64), 3);
            //graph.AddRib((char)(23 + 64), (char)(23 + 6 + 64), 2);

            printList(graph.AlgorithmDijkstra((char)(0 + 64)));
        }

        
    }
}
