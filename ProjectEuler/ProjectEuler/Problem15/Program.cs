using System;
using System.Numerics;

namespace Problem15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long ten = 1;
            BigInteger twenty = 1;

            for (int i = 20; i > 0; i--)
            {
                ten = ten * i;
            }
            
            for (int i = 40; i > 0; i--)
            {
                twenty = twenty * i;
            }

            BigInteger result = twenty / ten;
            result = result / ten;
            
            Console.WriteLine(result);
        }
    }
}