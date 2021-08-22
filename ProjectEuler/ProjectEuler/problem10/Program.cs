using System;
using System.Collections.Generic;

namespace problem10
{
    internal class Program
    {
        private const int N = 2000000;
        
        public static void Main(string[] args)
        {
            List<bool> list = new List<bool>();
            for (int i = 0; i < N; i++)
            {
                list.Add(true);
            }

            for (int pos = 2; pos < N; pos++)
            {
                if (list[pos])
                {
                    for (int repos = pos * 2; repos < N; repos = repos + pos)
                    {
                        list[repos] = false;
                    }
                }
            }

            long result = 0;
            for (int k = 2; k < N; k++)
            {
                if (list[k])
                {
                    result = result + k;
                }
            }
            Console.WriteLine(result);
        }
    }
}