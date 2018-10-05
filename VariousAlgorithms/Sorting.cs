using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousAlgorithms
{
    class Sorting
    {
        public string name = "";
        public int[] myArray = new int[15];

        public int[] BubbleSort(int[] array, out string sortName)
        {
            sortName = "Bubble sort";
            int temp = 0;
            bool sorted;
            for (int j = 0; j < array.Length; j++)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
                if (sorted)
                    break;
            }

            return array;
        }

        public int[] SelectionSort(int[] array, out string sortName)
        {
            sortName = "Selection sort";
            int smaller = 0;
            int temp = 0;
            bool swap = false;

            for (int j = 0; j < array.Length-1; j++)
            {
                smaller = j;
                for (int i = j; i < array.Length - 1; i++)
                {
                    if (array[smaller] > array[i + 1])
                    {
                        smaller = i + 1;
                        swap = true;
                    }
                }

                if (swap)
                {
                    temp = array[j];
                    array[j] = array[smaller];
                    array[smaller] = temp;
                    swap = false;
                }

            }

            return array;
        }

        public int[] InsertionSort(int[] array, out string sortName)
        {
            sortName = "Insertion sort";

            int j = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                j = i;
                while (j > -1 && array[j + 1] < array[j])
                {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        j--;
                }

            }

            return array;
        }

        private void TimerHelper(int swaps, int comparisons)
        {
            //TO DO - this will measure time for each 
            //sorting method in order to compare them
        }

        public void DisplayArray(int[] array, 
                                string name = "Unsorted series of random numbers:",
                                bool showNumbers = false, bool writeLine = true)
        {
            if (writeLine == true)
                Console.WriteLine("\n");

            Console.WriteLine(name);

            if (showNumbers == true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < (array.Length - 1))
                        Console.Write($"{array[i]}, ");
                    else
                        Console.WriteLine($"{array[i]}");
                }

            }
        }

        public int[] CreateRndArray(int maxNum, int length = 10)
        {
            int[] arrayOfRndInt = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrayOfRndInt[i] = RndNum(maxNum);
            }
            return arrayOfRndInt;
        }

        public int[] CopyArray(int[] array)
        {
            int[] copyOfArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copyOfArray[i] = array[i];
            }

            return copyOfArray;
        }

        public Random random = new Random();

        public int RndNum(int maxNum)
        {
            return random.Next(maxNum);
        }

    }
}
