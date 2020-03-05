using System;

namespace ClockAngle
{
    public class CLockAngleProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a time (int hr, int min), calculate the angle made between the hour hand and the minute hand.\n");
            int hour = 12;
            int minutes = 15;
            double angleDiff = ClockAngle(hour, minutes);
            Console.WriteLine($"The angle between {hour} and {minutes} is {angleDiff}");
        }

        public static double ClockAngle(int hour, int minutes)
        {
            double hourAngle = 0;
            double minuteAngle = 0;
            if (hour <= 12 && hour >0)
            {
                hourAngle = (double)hour / 12*360;
            }
            else
            {
                Console.WriteLine("Invalid Hour Value");
            }
            if (minutes <= 59 && minutes > 0)
            {
                minuteAngle = (double)minutes / 60*360;
            }
            else
            {
                Console.WriteLine("Invalid Minutes Value");
            }
            double angleDiff = hourAngle - minuteAngle;

            return angleDiff;
        }
    }
}
