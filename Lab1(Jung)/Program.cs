//Student Name: Siyoon Jung
//Student ID: 1558288
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Lab1_Jung_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Performance testing capability with timer
            ///it will go through all four methods
            ///1. it shows generated array first
            ///2. show sorted array by bubble sort with time spent
            ///3. show sorted array by insertion sort with time spent
            ///4. show time spent to find value by linear search
            ///5. show time spent to find value by binary search
            ///</summary>

            Stopwatch stopwatch = new Stopwatch();

            
            int[] arrayOne = CreateArray.CreateUnsortedArray(10);
            //1. generate unsorted array one

            Console.Write("unsorted array: ");
            print(arrayOne);
            //1. show the array one

            stopwatch.Start();
            int[] arrayOneBubbleSorted = Sort.BubbleSort(arrayOne);
            stopwatch.Stop();
            //2. sort the array one with bubble sort

            Console.Write("BubbleSorted array: ");
            print(arrayOneBubbleSorted);
            Console.WriteLine($"Elapsed Time for BubbleSort is {stopwatch.Elapsed}\n");
            //2. show the sorted array one by bubble sort

            stopwatch.Start();
            int[] arrayOneInsertionSorted = Sort.InsertionSort(arrayOne);
            stopwatch.Stop();
            //3. sort the array one with insertion sort

            Console.Write("InsertSorted array: ");
            print(arrayOneInsertionSorted);
            Console.WriteLine($"Elapsed Time for InsertionSort is {stopwatch.Elapsed}\n");
            //3. show the sorted array one by insertion sort


            Console.WriteLine("type integer you want to find");
            string integerValue = Console.ReadLine();
            int.TryParse(integerValue, out int _value);

            stopwatch.Start();
            int i = Search.LinearSearch(arrayOneBubbleSorted, _value);
            stopwatch.Stop();
            //4.find value in linearSearch
            PrintSearch(i);
            Console.WriteLine($"Elapsed Time for LinearSearch is {stopwatch.Elapsed}\n");
            //4.show time spent with linearSearch

            stopwatch.Start();
            int k = Search.BinarySearch(arrayOneBubbleSorted, _value);
            stopwatch.Stop();
            //5.find value in BinarySearch
            PrintSearch(k);
            Console.WriteLine($"Elapsed Time for BinarySearch is {stopwatch.Elapsed}\n");
            //5.show time spent with BinarySearch

            Console.ReadLine();

            void print(int[] array)
                //print for Sort methods
            {
                for (int l = 0; l < array.Length; l++)
                {
                    Console.Write(" [" + l + "]" + array[l]);
                }
                Console.WriteLine();
            }


            void PrintSearch(int j)
                //print for search methods
            {
                if (j == -1)
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    Console.WriteLine($"Found in {j}times");
                }
            }
        }
    }
}
