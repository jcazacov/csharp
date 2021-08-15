using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    internal class Program
    {
        private const int N = 10000;
        private const int scale = 1000;
        
        public static void Main(string[] args)
        {
            var list = InitList();

            DateTime startTime = DateTime.Now;
            BubbleSort(list);
            DateTime endTime = DateTime.Now;            
            PrintList(list);
            Console.WriteLine($"Execution time: {(endTime - startTime).TotalMilliseconds} ms.");
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