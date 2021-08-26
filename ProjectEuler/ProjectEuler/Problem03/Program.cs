using System;

namespace Problem3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long N = 600851475143;
 
            int i = 2;
            while (i < N)
            {
                if (N % i == 0)
                {
                    N = N / i;
                }
                else
                {
                    i = i + 1;
                }
            }
            Console.WriteLine(N);
        }
    }
}