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
            //Graph graph = new Graph();
            //graph.AddRib('A', 'B', 10);
            //graph.AddRib('A', 'C', 15);
            //graph.AddRib('B', 'B', 33);
            //graph.AddRib('B', 'C', 1);
            //graph.writeMatrix();
            //graph.AlgorithmKruskal().writeMatrix();

            bool key = true;
            do
            {
                Console.WriteLine("0. Вихід.");
                Console.WriteLine("1. Приклад.");
                Console.WriteLine("2. Запуск");
                Console.WriteLine("Оберіть пункт меню та натисніть Enter: ");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.Clear();
                        key = false;
                        break;
                    case "1":
                        Console.Clear();
                        ExempleProgram();
                        break;
                    case "2":
                        Console.Clear();
                        StartProgram();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ви вибрали не існуючий пункт меню.");
                        break;
                }
            } while (key);
        }

        static void ExempleProgram()
        {
            Graph graph = new Graph();

            graph.AddTop('1');
            graph.AddTop('2');
            graph.AddTop('3');
            graph.AddTop('4');
            graph.AddTop('5');
            graph.AddTop('6');
            graph.AddTop('7');
            graph.AddTop('8');
            graph.AddTop('9');
            graph.AddTop('A');
            graph.AddTop('B');
            graph.AddRib('1', '2', 7);
            graph.AddRib('1', '3', 3);
            graph.AddRib('1', '4', 2);
            graph.AddRib('2', '7', 1);
            graph.AddRib('2', '5', 7);
            graph.AddRib('3', '5', 7);
            graph.AddRib('3', '6', 4);
            graph.AddRib('4', '6', 5);
            graph.AddRib('4', '7', 5);
            graph.AddRib('5', '8', 2);
            graph.AddRib('5', '9', 4);
            graph.AddRib('6', '8', 4);
            graph.AddRib('6', 'A', 2);
            graph.AddRib('7', '9', 3);
            graph.AddRib('8', 'B', 3);
            graph.AddRib('9', 'B', 1);
            graph.AddRib('A', 'B', 6);

            graph.writeMatrix();
            Console.WriteLine();
            graph.AlgorithmKruskal().writeMatrix();
        }

        static void StartProgram()
        {


        }
    }
}
