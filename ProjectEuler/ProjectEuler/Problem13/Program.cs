using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;

namespace Problem13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> result = new List<int>(0);
            
            string[] lines = File.ReadAllLines("Input.txt");
            
            foreach (string line in lines)
            {
                var lineList = new List<int>();
                int i = 0;
                while (i < line.Length)
                {
                    string digit = line[line.Length - i - 1].ToString();
                    lineList.Add(Int32.Parse(digit));
                    i++;
                }
                result = LongSum(result, lineList);
            }


            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[result.Count - i - 1]);
            }
            
            
            
            
            
        }


        public static List<int> LongSum(List<int> list1, List<int> list2)
        {
            int lenmax = 0;
            int len1 = list1.Count;
            int len2 = list2.Count;
            
            
            if (len1 <= len2)
            {
                lenmax = len2;
                for (int i = len1; i < lenmax; i++)
                {
                    list1.Add(0);
                }
            }
            else
            {
                lenmax = list1.Count;
                for (int i = len2; i < lenmax; i++)
                {
                    list2.Add(0);
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < lenmax; i++)
            {
                result.Add(0);
            }

            int carry = 0;
            for (int i = 0; i < lenmax; i++)
            {
                int res = list1[i] + list2[i] + carry;
                if (res >= 10)
                {
                    carry = 1;
                    res = res - 10;
                }
                else
                {
                    carry = 0;
                }
                result[i] = res;
            }

            if (carry == 1)
            {
                result.Add(1);
            }

            return result;
        }


    }
}