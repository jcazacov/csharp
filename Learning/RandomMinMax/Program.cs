using System;

namespace RandomMinMax
{
    internal class Program
    {
        private const int N = 100;
        private const int RANGE = 1000;
        
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int index ;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for (index = 0; index < N; index = index + 1)
            {
                int nextNumber = rnd.Next(RANGE + 1);
                
                if (nextNumber < min)
                {
                    min = nextNumber;
                }
                if (nextNumber > max)
                {
                    max = nextNumber;
                }
                
                Console.Write(nextNumber);
                
                if (index % 10 == 9)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("/");
                }
            }
            Console.WriteLine($"Min value: {min}");
            Console.WriteLine($"Max value: {max}");
        }
    }
}