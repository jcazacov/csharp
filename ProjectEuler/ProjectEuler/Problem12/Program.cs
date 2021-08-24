using System;
using System.Text.RegularExpressions;

namespace Problem12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long N = 0;
            long step = 1;
            bool nfound = true;


            while (nfound)
            {
                N = N + step;
                step++;


                int count = divisor(N);
                Console.WriteLine($"{N} --- {count}");
                if (count >= 500)
                {
                    nfound = false;
                    
                }
            }
            Console.WriteLine(N);
        }

        public static int divisor(long N)
        {
            int divid = 1;
            int i = 2;
            int tem = 1;
            long Zahl = N;
            while (i < Math.Sqrt(Zahl))
            {
                
                if (N % i == 0)
                {
                    N = N / i;
                    tem ++;
                }
                else
                { 
                    divid = divid * tem;
                    tem = 1;
                    i = i + 1;   
                }
                
                
            }

            return divid;
        }
        
        
    }
}