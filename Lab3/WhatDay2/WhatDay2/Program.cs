using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatDay2
{
    class WhatDay
    {
        enum MonthName
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            try 
            {
                const int minDayNum = 1;
                const int maxDayNum = 365;
                Console.Write("Please input a day number between 1 and 365: ");

                int dayNum = int.Parse(Console.ReadLine());

                if (dayNum < minDayNum || dayNum > maxDayNum)
                {
                  throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }


                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);

            }
            catch (Exception caught)
            {
                Console.WriteLine("An exception encountered: {0}", caught);
            }

            
        }
        // Don't modify anything below here
        static System.Collections.ICollection DaysInMonths
            = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
