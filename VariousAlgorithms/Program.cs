using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting p = new Sorting();

            while (true)
            {
                Stopwatch sw = new Stopwatch();

                p.myArray = p.CreateRndArray(100, p.myArray.Length);
                p.DisplayArray(p.myArray, sorted: false);

                sw.Start();
                p.DisplayArray(p.BubbleSort(p.CopyArray(p.myArray), out p.name), p.name);
                sw.Stop();
                Console.WriteLine("Elapsed={0}", sw.Elapsed);
                sw.Reset();

                sw.Start();
                p.DisplayArray(p.SelectionSort(p.CopyArray(p.myArray), out p.name), p.name);
                sw.Stop();
                Console.WriteLine("Elapsed={0}", sw.Elapsed);
                sw.Reset();

                sw.Start();
                p.DisplayArray(p.InsertionSort(p.CopyArray(p.myArray), out p.name), p.name);
                sw.Stop();
                Console.WriteLine("Elapsed={0}", sw.Elapsed);

                if (Console.ReadLine() == "e")
                    break;
                else
                    Console.Clear();

            }

        }
    }
}
