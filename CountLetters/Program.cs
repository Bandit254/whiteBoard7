using System;

namespace CountLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the number of letters in a string, ignoring spaces, numbers, and/or punctuation");

            string inputString = "We're in MSSA CAD #7 in San Diego";
            Console.WriteLine($"The number of letters in the string is {CountLetters(inputString)}");
        }

        public static int CountLetters(string inputString)
        {
            int count = 0;
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c in inputString)
            {
                if (letters.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
