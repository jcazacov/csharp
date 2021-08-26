using System;

namespace Problem9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;

            for (int a = 1; a < 999; a++)
            {
                for (int b = 1; a + b < 1000; b++)
                {
                    int c = 1000 - a - b;
                    if (a * a + b * b == c * c)
                    {
                        result = a * b * c;
                        break;
                    }
                    
                }

                if (result != 0)
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
