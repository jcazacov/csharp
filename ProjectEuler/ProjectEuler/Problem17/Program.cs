using System;
using System.Collections.Generic;
using System.Xml;

namespace Problem17
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            List<string> ones = new List<string>();
            ones.Add("Zero");
            ones.Add("One");
            ones.Add("Two");
            ones.Add("Three");
            ones.Add("Four");
            ones.Add("Five");
            ones.Add("Six");
            ones.Add("Seven");
            ones.Add("Eight");
            ones.Add("Nine");
            ones.Add("Ten");
            ones.Add("Eleven");
            ones.Add("Twelve");
            ones.Add("Thirteen");
            ones.Add("Fourteen");
            ones.Add("Fifteen");
            ones.Add("Sixteen");
            ones.Add("Seventeen");
            ones.Add("Eighteen");
            ones.Add("Nineteen");
            
            List<string> tens = new List<string>();
            tens.Add("Zero");
            tens.Add("Ten");
            tens.Add("Twenty");
            tens.Add("Thirty");
            tens.Add("Forty");
            tens.Add("Fifty");
            tens.Add("Sixty");
            tens.Add("Seventy");
            tens.Add("Eighty");
            tens.Add("Ninety");
            
            string hundred = "Hundred";
            string thousand = "OneThousand";

            string and = "And";


            int letters = 0;
            letters = letters + thousand.Length;

            for (int num = 1; num < 1000; num++)
            {
                string sum = "";
                if (num >= 100)
                {
                    int hun = num / 100;
                    sum = sum + ones[hun];
                    sum = sum + hundred;
                    if (num % 100 != 0)
                    {
                        sum = sum + and;
                    }
                }

                int twos = num % 100;
                if (twos < 20 && twos != 0)
                {
                    sum = sum + ones[twos];
                }
                else
                {
                    int sec = twos / 10;
                    if (sec != 0)
                    {
                       sum = sum + tens[sec]; 
                    }
                    
                    int fir = twos % 10;
                    if (fir != 0)
                    {
                        sum = sum + ones[fir];
                    }
                }
                Console.WriteLine($"The number: {num} ({sum}) has {sum.Length} letters.");
                letters = letters + sum.Length;

            }
            
            Console.WriteLine(letters);
            
        }
    }
}