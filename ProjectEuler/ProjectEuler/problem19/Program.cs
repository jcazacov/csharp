using System;

namespace problem19
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int year = 1900;
            int month = 1;
            int day = 1;
            int weekday = 1;
            int sundays = 0;

            while (year < 2001)
            {
                if (month == 12 && day == 31)
                {
                    day = 1;
                    month = 1;
                    year ++;
                }
                else
                {
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        if (day == 31)
                        {
                            day = 1;
                            month++;
                        }
                        else
                        {
                            day++;
                        }
                    }
                    else
                    {
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            if (day == 30)
                            {
                                day = 1;
                                month++;
                            }
                            else
                            {
                                day++;
                            }
                        }
                        else
                        {
                            if (month == 2)
                            {
                                if (day == 28)
                                {
                                    if (year % 4 != 0)
                                    {
                                        day = 1;
                                        month++;
                                    }
                                    else
                                    {
                                        if (year % 100 == 0)
                                        {
                                            day = 1;
                                            month++;
                                            
                                        }
                                        else
                                        {
                                            day++;
                                        }
                                    }
                                }
                                else
                                {
                                    if (day == 29)
                                    {
                                        day = 1;
                                        month++;
                                    }
                                    else
                                    {
                                        day++;
                                    }
                                }
                            }
                        }
                    }
                }
                weekday = weekday % 7;
                weekday++;

                if (day == 1)
                {
                     Console.WriteLine($"{day}.{month}.{year} was a weekday number {weekday}.");
                }
               

                if (day == 1 && weekday == 7 && 1900 < year && year < 2001)
                {
                    sundays++;
                }
            }
            Console.WriteLine(sundays);
        }
    }
}