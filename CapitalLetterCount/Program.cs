using System;

namespace CapitalLetterCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that counts the number of capital letters in a string.\n");

            string input = "The San Diego Zoo";
            Console.WriteLine($"The number of capital letters in the string '{input}' is {CapitalLetterCount(input)}.\n");
        }


        public static int CapitalLetterCount(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
