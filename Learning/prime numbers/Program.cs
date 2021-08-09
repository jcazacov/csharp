using System;

namespace prime_numbers
{
    internal class Program
    {
        private const int N = 1000;
        public static void Main(string[] args)
        {
            bool[] sieb = new bool[N+1];
            int i;
            for (i = 0; i < N+1; i++)
            {
                sieb[i] = true;
            }

            int index;
            for (index = 2; index < N/2 + 1; index++)
            {
                if (sieb[index])
                {
                    int step;
                    for (step = index * 2; step < N + 1; step = step + index)
                    {
                        sieb[step] = false;
                    }
                }
            }

            int num;
            for (num = 2; num < N + 1; num++)
            {
                if (sieb[num])
                {
                    Console.Write(num);
                    Console.Write(" ");
                }
            }
        }
    }
}