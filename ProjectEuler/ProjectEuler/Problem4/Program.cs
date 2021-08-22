using System;
using System.Collections.Generic;

namespace Problem4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int max = 0;
            for (int n = 100; n < 1000; n++)
            {
                for (int m = 100; m < 1000; m++)
                {
                    int prod = n * m;
                    if (Poly(prod))
                    {
                        if (prod > max)
                        {
                            max = prod;
                        }
                    }
                    
                }
            }
            Console.WriteLine(max);

            

        }

        public static bool Poly(int args)
        {
            List<int> list = new List<int>();
            while (args != 0)
            {
                list.Insert(0,args % 10);
                args = args / 10;
            }

            int digit = list.Count;

            for (int i = 0; i < digit / 2; i ++)
            {
                if (list[i] == list[digit - 1 - i])
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}