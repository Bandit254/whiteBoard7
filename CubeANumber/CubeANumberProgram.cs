using System;

namespace CubeANumber
{
    class CubeANumberProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cube a Number");
            CubeANumber();

        }

        public static void CubeANumber()
        {
            Console.Write("Enter a number to see its cube: ");
            string numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);
            Console.WriteLine("The cube of " + number + " is " + number * number * number);
        }

    }
}
