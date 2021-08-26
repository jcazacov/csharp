using System;

namespace Problem6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum = sum + i;
            }

            int sqsum = sum * sum;

            int sumsq = 0;
            for (int i = 1; i < 101; i++)
            {
                sumsq = sumsq + i * i;
            }

            int diff = sumsq - sqsum;
            Console.Write(diff);
        }
    }
}