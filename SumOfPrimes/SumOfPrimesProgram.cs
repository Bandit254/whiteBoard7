using System;
namespace SumOfPrimes
{
    class SumOfPrimesProgram
    {

        public static int SumOfPrimes(int numberOfPrimes)
        {
            int sumOfPrimes = 0;
            int counter;
            int currentNumber = 0;
            for (counter = 0; counter < numberOfPrimes;)
            {
                if (currentNumber < 2)
                {
                    currentNumber++;
                    continue;
                }
                else if (currentNumber == 2)
                {
                    sumOfPrimes += currentNumber;
                    counter++;
                    currentNumber++;
                    continue;
                }
                else if (currentNumber > 2)
                {
                    bool isPrime = false;
                    for (int i = 2; i < currentNumber; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;
                        }
                    }
                    if (isPrime)
                    {
                        sumOfPrimes += currentNumber;
                        currentNumber++;
                        counter++;
                        continue;
                    }
                    else
                    {
                        currentNumber++;
                        continue;
                    }
                }
            }
            return sumOfPrimes;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Return the Sum of N Prime Numbers");
            int numPrimes = 5;
            Console.WriteLine($"The sum of the first {numPrimes} prime numbers is {SumOfPrimes(numPrimes)}");
        }
    }
}
