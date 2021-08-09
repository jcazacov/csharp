using System;


namespace MonteCarlo
{
    internal class Program
    {
        private const int N = 100000000;
        private const int scale = 1000000;
        
        public static void Main(string[] args)
        {
            int index;
            int inside = 0;
            double pi;
            Random rnd = new Random();

            for (index = 0; index < N; index = index + 1)
            {
                double x = (double)rnd.Next(scale + 1) / scale;
                double y = (double)rnd.Next(scale + 1) / scale;

                if (x * x + y * y < 1)
                {
                    inside = inside + 1;
                }
                else
                {
                    
                }

                if ((index + 1) % 10000000 == 0)
                {
                    pi = ((double) inside / (double) index) * 4;
                    Console.WriteLine(pi);
                }
                
            }

        }
    }
}