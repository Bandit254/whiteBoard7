using System;

namespace IsLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prompt user for a year, and determine if that year is a leap year.");
            IsLeapYear();
        }

        public static void IsLeapYear()
        {
            Console.WriteLine("Please enter a 4-digit year:");
            int year = Convert.ToInt32(Console.ReadLine());
            int diffYear = 2020 - year;
            bool isLeapyear = false;
            if (diffYear%4==0)
            {
                isLeapyear = true; 
            }
            Console.WriteLine($"{year} is a Leap Year, true or false? {isLeapyear}");
        }

    }
}
