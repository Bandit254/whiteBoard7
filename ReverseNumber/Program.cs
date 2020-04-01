using System;
using System.Collections.Generic;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a number, reverse the digits of a given number.\n");
            Console.WriteLine($"{ReverseNumber(63534287)}");
        }

        public static int ReverseNumber(int input)
        {
            int reverseNum=0;
            List<int> reversedDigits = new List<int>();
            do
            {
                int nextDigit = input % 10;
                input /= 10;
                reversedDigits.Add(nextDigit);
            } while (input>0);
            for (int i = 0; i < reversedDigits.Count; i++)
            {
                reverseNum += Convert.ToInt32((reversedDigits[i] * Math.Pow(10, (reversedDigits.Count - 1 - i))));
            }
            return reverseNum;
        }
    }
}
