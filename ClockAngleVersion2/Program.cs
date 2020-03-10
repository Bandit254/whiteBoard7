using System;

namespace ClockAngleVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given the time in two separate numbers (hours and minutes), calculate the angle between the two clock hands.");
            AngleOfClockHands(10, 8);
        }

        public static void AngleOfClockHands(int hour, int minutes)
        {
            decimal hourAngle = ((decimal)hour) * 360 / 12;
            decimal minuteAngle = ((decimal)minutes * 360 / 60);
            decimal clockAngle=0;
            if (hourAngle>minuteAngle)
            {
                clockAngle = hourAngle - minuteAngle;
            }
            else if (minuteAngle>hourAngle)
            {
                clockAngle = minuteAngle - hourAngle;
            }
            Console.WriteLine($"The angle between {hour} on the hour hand and {minutes} on the minute hand is {clockAngle}");
        }
    }
}
