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
            Sorting p = new Sorting(500);

            while (true)
            {
                Stopwatch sw = new Stopwatch();

                //p.myArray = p.CreateRndArray(1000, p.myArray.Length);
                //p.DisplayArray(p.myArray, showNumbers:true, writeLine:false);

                sw.Start();
                p.DisplayArray(p.BubbleSort(p.myArray, out p.name), p.name, showNumbers:true);
                sw.Stop();
                Console.WriteLine("Elapsed={0}", sw.Elapsed);
                sw.Reset();

                sw.Start();
                p.DisplayArray(p.SelectionSort(p.myArray, out p.name), p.name, showNumbers:true);
                sw.Stop();
                Console.WriteLine("Elapsed={0}", sw.Elapsed);
                sw.Reset();

                sw.Start();
                p.DisplayArray(p.InsertionSort(p.myArray, out p.name), p.name, showNumbers:true);
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
