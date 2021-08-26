using System;

namespace Problem02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int prev = 0;
            int cur = 1;
            int sum = 0;

            while (cur < 4000000)
            {
                if (cur % 2 == 0)
                {
                    sum = sum + cur;
                }
                
                int temp = cur;
                cur = cur + prev;
                prev = temp;
            }
            Console.WriteLine(sum);
        }
    }
}