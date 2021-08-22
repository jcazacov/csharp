using System;

namespace Problem1
{
    internal class Problem1
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (var i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                    continue;
                }

                if (i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}