using System;
using PrimeNumberWhiteboard;
namespace SumOfPrimes
{
    class Program
    {

        public static int SumOfPrimes(int n)
        {
            int sumOfPrimes = 0;
            int numberOfPrimes = 0;
            int primeNumber = 0;
            int checkNumber = 2;

            while (numberOfPrimes < n)
            {
                //if (                 )
                {
                    checkNumber = primeNumber;
                    sumOfPrimes += primeNumber;
                    checkNumber++;
                }
                checkNumber++;
            }



            return sumOfPrimes;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Return the Sum of N Prime Numbers");
        }
    }
}
