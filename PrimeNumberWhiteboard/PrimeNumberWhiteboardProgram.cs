﻿using System;

namespace PrimeNumberWhiteboard
{
    class PrimeNumberWhiteboardProgram
    {

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Determining if a Number is a Prime Number");
            int number = 73;
            IsPrime(number);
            Console.WriteLine($"{number} is a prime number: {IsPrime(number)}");






        }
    }
}
