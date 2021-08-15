using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace quicksort
{
    internal class Program
    {
        private const int N = 100000;
        private const int scale = 1000;
        
        public static void Main(string[] args)
        {
            var list = InitList();
            var list2 = new List<int>();
            list2.AddRange(list);

            var sw = new Stopwatch();
            sw.Start();
            BubbleSort(list2);
            sw.Stop();
            Console.WriteLine($"Execution time: {sw.ElapsedMilliseconds} ms.");
            
            sw.Reset();
            sw.Start();
            QuickSort(list, 0, list.Count - 1);
            sw.Stop();            
            Console.WriteLine($"Execution time: {sw.ElapsedMilliseconds} ms.");
        }

        private static void BubbleSort(List<int> list)
        {
            int row;
            for (row = 0; row < N - 1; row++)
            {
                int pos;
                for (pos = 0; pos < N - row - 1; pos++)
                {
                    if (list[pos] > list[pos + 1])
                    {
                        int temp = list[pos + 1];
                        list[pos + 1] = list[pos];
                        list[pos] = temp;
                    }
                }
            }
        }

        private static void QuickSort(List<int> list, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivotindex = partition(list, left, right);
            QuickSort(list, left, pivotindex - 1);
            QuickSort(list, pivotindex + 1, right);


        }

        private static int partition(List<int> list, int left, int right)
        {
            int pivot = list[right];
            int pivotindex = left;
            for (int i = left; i < right; i++)
            {
                if (list[i] < pivot)
                {
                    int temp = list[i];
                    list[i] = list[pivotindex];
                    list[pivotindex] = temp;
                    pivotindex++;
                }
            

            }
            int temp2 = list[right];
            list[right] = list[pivotindex];
            list[pivotindex] = temp2;
            return pivotindex;
        }


        private static List<int> InitList()
        {
            List<int> list = new List<int>();

            Random rnd = new Random();

            int fill;
            for (fill = 0; fill < N; fill++)
            {
                int nextNumber = rnd.Next(scale);
                list.Add(nextNumber);
            }

            return list;
        }

        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i != list.Count - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        
    }
}