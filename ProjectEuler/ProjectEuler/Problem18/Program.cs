using System;
using System.Collections.Generic;
using System.IO;

namespace Problem18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> numbers = new List<List<int>>();    // Reading File and Creating List of Lists of integers out of it
            
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

            
            
            for (int i = 0; i < numbers.Count; i++)            // Writing the pyramid
            {
                for (int j = 0; j < numbers[i].Count; j++)
                {
                    Console.Write(numbers[i][j]);
                    if (j < numbers[i].Count - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            
            
            int rows = numbers.Count;       // replacing every position in the pyramid with the maximum path sum under it

            for (int row = rows - 2; row >= 0; row--)   //rows from second from the bottom to the top
            {
                for (int pos = 0; pos < numbers[row].Count; pos++)  //position inside the row
                {
                    if (numbers[row + 1][pos] >= numbers[row + 1][pos + 1])     //checking wich of the adjanced numbers below has the biggest path sum
                    {
                        numbers[row][pos] = numbers[row][pos] + numbers[row + 1][pos];      //the left one has the biggest sum => adding this sum to current number
                    }
                    else
                    {
                        numbers[row][pos] = numbers[row][pos] + numbers[row + 1][pos + 1];  //the right one has the biggest sum => adding this sum to current number
                    }
                }
            }
            
            
            
            for (int i = 0; i < numbers.Count; i++)            // Writing the modified pyramid
            {
                for (int j = 0; j < numbers[i].Count; j++)
                {
                    Console.Write(numbers[i][j]);
                    if (j < numbers[i].Count - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            
            
            Console.WriteLine($"The maximum path sum is {numbers[0][0]}.");     //Writing maximum path sum
        }
    }
}