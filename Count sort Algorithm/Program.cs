using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_sort_Algorithm
{
    internal class Program
    {
        public static void CountingSortAlgorithm(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            
            int[] countArray = new int[max + 1];

            
            foreach (int num in arr)
            {
                countArray[num]++;
            }

            int index = 0;
            for (int i = 0; i < countArray.Length; i++)
            {
                while (countArray[i] > 0)
                {
                    arr[index] = i;
                    index++;
                    countArray[i]--;
                }
            }
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
            Console.WriteLine("Original Array:");
            DisplayArray(arr);

            CountingSortAlgorithm(arr);

            Console.WriteLine("\nSorted Array:");
            DisplayArray(arr);
            Console.ReadLine();
        }

    }
}

