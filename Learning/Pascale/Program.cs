using System;
using System.Collections.Generic;
using System.Linq;

namespace Pascale
{
    internal class Program
    {


        private const int depth =20;
        
        public static void Main(string[] args)
        {
            List<long> pasc = new List<long>();
            pasc.Add(1);
            
            int row ;
            for (row = 1; row <= depth; row = row + 1)
            {
                List<long> list = new List<long>();
                list.Add(1);

                int index;
                for (index = 1; index < row; index = index + 1)
                {
                    long next = pasc[index - 1] + pasc[index];
                    list.Add(next);
                }

                list.Add(1);
                pasc = list;
                PrintList(pasc);
            }
            Console.ReadLine();
        }

        private static void PrintList(List<long> list)
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
