using System;
using System.Numerics;

namespace Problem16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BigInteger num = 1;
            for (int i = 0; i < 1000; i++)
            {
                num = num * 2;
            }

            string line = num.ToString();
            int sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                int digit = Int32.Parse(line[i].ToString());
                sum = sum + digit;

            }
            Console.WriteLine(num);
            Console.WriteLine(sum);
        }
    }
}