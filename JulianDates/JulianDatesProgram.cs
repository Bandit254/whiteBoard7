using System;

namespace JulianDates
{
    class JulianDatesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the Julian Date");
            //Given a Month and Day, calculate the corresponding Julian Date
            //Julian Date = the number of days past 01 January 

            Month month = new Month();
            month = Month.November;
            int day = 6;
            GetJulian(month, day);
            Console.WriteLine($"The Julian Date of month = {month} and day = {day} is {GetJulian(month, day)}");
        }

        public static int GetJulian(Month month, int day)
        {
            int julianDate = 0;
            switch (month)
            {
                case Month.January: //January
                    return julianDate = day;
                    //break;
                case Month.February://February
                    return julianDate = 31 + day;
                   // break;
                case Month.March://March
                    return julianDate = 59 + day;
                   // break;
                case Month.April://April
                    return julianDate = 90 + day;
                    //break;
                case Month.May://May
                    return julianDate = 120 + day;
                    //break;
                case Month.June://June
                    return julianDate = 151 + day;
                   // break;
                case Month.July://July
                    return julianDate = 181 + day;
                   // break;
                case Month.August://August
                    return julianDate = 212 + day;
                   // break;
                case Month.September://September
                    return julianDate = 243 + day;
                   // break;
                case Month.October://October
                    return julianDate = 273 + day;
                   // break;
                case Month.November://November
                    return julianDate = 304 + day;
                   // break;
                case Month.December://December
                    return julianDate = 334 + day;
                   // break;
            }
            return julianDate;
            
        }

       public enum Month { January, February, March, April, May, June, July, August, September, October, November, December };
    }

}
