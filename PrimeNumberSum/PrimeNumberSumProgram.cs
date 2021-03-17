using System;

namespace PrimeNumberSum
{
    class PrimeNumberSumProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Return the sum of an arbitrary number of prime numbers");
            int numPrimes = 5;
            Console.WriteLine($"The sum of the first {numPrimes} prime numbers is {PrimeNumberSum(numPrimes)}");
        }
        public static int PrimeNumberSum(int numberOfPrimes)
        {
            int sumOfPrimes = 0;
            int counter = 0;
            int nextNumber = 2;
            bool isPrime = false;
            while(counter<numberOfPrimes)
            {
                isPrime = CheckPrime(nextNumber);
                if (isPrime)
                {
                    sumOfPrimes += nextNumber;
                    counter++;
                }
                nextNumber++;
            }
            return sumOfPrimes;
        }
        public static bool CheckPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
