using System;

namespace Problem7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            int num = 0;
            long zahl = 2;
            while (num < 10001)
            {
                if (Prime(zahl))
                {
                    num++;
                    Console.WriteLine($"{num} ; {zahl}");
                }

                zahl++;
            }
        }

        public static bool Prime(long N)
        {
            int i = 2;
            while (i < N)
            {
                if (N % i == 0)
                {
                    return false;
                }
                else
                {
                    i = i + 1;
                }
            }
            return true;
        }
    }
}