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
            int[] sortedArray = new int[array.Length];
            sortedArray[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int position = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] > sortedArray[j])
                        position++;
                    else
                        break;
                }
                if (position == i)
                    sortedArray[i] = array[i];
                else
                {
                    for (int j = i; j > position; j--)
                    {
                        sortedArray[j] = sortedArray[j - 1];
                    }
                    sortedArray[position] = array[i];
                }
            }
            return sortedArray;
        }

        private void TimerHelper(int swaps, int comparisons)
        {
            //TO DO - this will measure time for each 
            //sorting method in order to compare them
        }

        public void DisplayArray(int[] array, string name = "", bool sorted = true)
        {
            if (sorted == false)
                name = "Unsorted series of random numbers:";
        
            // Console.WriteLine("\n"); //remove

            Console.WriteLine(name);

            for (int i = 0; i < array.Length; i++)
            {
                if (i < (array.Length - 1))
                    Console.Write($"{array[i]}, ");
                else
                    Console.Write($"{array[i]}");

            }
            Console.WriteLine("\n");
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
