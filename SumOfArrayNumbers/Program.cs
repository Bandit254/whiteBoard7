using System;

namespace SumOfArrayNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an array of numbers (doubles), return the sum of all items in the array");

            double[] inputArray = new double[] { 0, 3.14, 9.99999, 17.6, 4067.1, 2 };
            double sumOfArray = SumOfArrayNumbers(inputArray);
            Console.WriteLine($"The sum of the array is {sumOfArray}");
        }

        public static double SumOfArrayNumbers(double[] inputArray)
        {
            double sumOfArray = 0;
            foreach (double x in inputArray)
            {
                sumOfArray += x;
            }
       

            return sumOfArray;
        }
    }
}
