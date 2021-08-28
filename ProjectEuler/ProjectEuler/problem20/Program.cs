using System;
using System.Numerics;


namespace problem20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BigInteger factor = 1;
            for (int i = 0; i < 100; i++)
            {
                factor = factor * (100 - i);
            }
            
            Console.WriteLine(factor);
            int sum = 0;

            string line = factor.ToString();
            for (int i = 0; i < line.Length; i++)
            {
                int dig = Int32.Parse(line[i].ToString());
                sum = sum + dig;
            }
            Console.WriteLine(sum);
            
        }
    }
}