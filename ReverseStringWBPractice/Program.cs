using System;

namespace ReverseStringWBPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a string, retrun a string that is the rverse of the given string\n");
            string input = "I love whiteboarding!";
            Console.WriteLine($"The reverse of {input} is {ReverseString(input)}");
        }

        public static string ReverseString(string input)
        {
            input.Split(" ");
            char nextChar = ' ';
            string reverseInput = "";
            for(int i = input.Length-1; i >= 0; i--)
            {
                nextChar = input[i];
                reverseInput += nextChar;
            }
            return reverseInput;
        }



    }
}
