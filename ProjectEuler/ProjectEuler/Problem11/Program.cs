using System;
using System.Collections.Generic;
using System.IO;

namespace Problem11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int rows = 20;
            int colums = 20;
            int len = 4;
            
            
            
            List<List<int>> numbers = new List<List<int>>();
            
            string[] lines = File.ReadAllLines("Input.txt");
            
            foreach (string line in lines)
            {
                var lineList = new List<int>();
                var strs = line.Split(new char[] {' '});
                foreach (String doble in strs)
                {
                    lineList.Add(Int32.Parse(doble));
                }                
                numbers.Add(lineList);
            }
            
            

            int max = 0;
            
            

            for (int i = 0; i < rows; i++)  // horizontal len
            {
                for (int k = 0; k < colums - len; k++)
                {
                    int prod = 1;
                    for (int r = 0; r < len; r++)
                    {
                        prod = prod * numbers[i][k + r];
                    }

                    if (prod > max)
                    {
                        max = prod;
                    }
                    
                }
            }
            
            
            
            for (int i = 0; i < rows - len; i++)  // vertical len
            {
                for (int k = 0; k < colums; k++)
                {
                    int prod = 1;
                    for (int r = 0; r < len; r++)
                    {
                        prod = prod * numbers[i + r][k];
                    }

                    if (prod > max)
                    {
                        max = prod;
                    }
                    
                }
            }
            
            
            
            for (int i = 0; i < rows - len; i++)  // diagonal Southeast len
            {
                for (int k = 0; k < colums - len; k++)
                {
                    int prod = 1;
                    for (int r = 0; r < len; r++)
                    {
                        prod = prod * numbers[i + r][k + r];
                    }

                    if (prod > max)
                    {
                        max = prod;
                    }
                    
                }
            }



            for (int i = 0; i < rows - len; i++)  // diagonal Southwest len
            {
                for (int k = len - 1; k < colums; k++)
                {
                    int prod = 1;
                    for (int r = 0; r < len; r++)
                    {
                        prod = prod * numbers[i + r][k - r];
                    }

                    if (prod > max)
                    {
                        max = prod;
                    }
                    
                }
            }



            Console.WriteLine(max);
        }
    }
}