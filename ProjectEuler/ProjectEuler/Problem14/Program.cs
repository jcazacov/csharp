using System;
using System.Collections.Generic;

namespace Problem14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long max = 0;
            int maxstart = 0;

            List<long> Lengths = new List<long>();
            



            for (int start = 1; start < 1000000; start++)
            {
                long chains = 1;
                long num = start;
                bool nfound = true;
                while (num != 1 && nfound)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = 3 * num + 1;
                    }
                    
                    chains = chains + 1;
                    
                    if (num <= Lengths.Count)
                    {
                        int tem = (int) num;

                        chains = chains + Lengths[tem - 1] - 1;
                        nfound = false;
                    }
                }
                
                Lengths.Add(chains);
                

                if (chains > max)
                {
                    max = chains;
                    maxstart = start;
                }
                
            }
            Console.WriteLine($"The Start {maxstart} gives the longest chain with a length of {max}.");
            
        }
    }
}