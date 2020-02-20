using System;

namespace IsPalindrome
{
    class Program
    {
        //How do you determine if a string is a palindrome?

        public static bool IsPalindrome(string input)
        {
            
            int palindromeIndex = input.Length;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[palindromeIndex--])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Whiteboard Exercise");

            Console.WriteLine("\nEnter a string to test if it is a palindrome");
            string input = Console.ReadLine();
            Console.WriteLine($"The length of {input} is {input.Length}");
            //Console.WriteLine($"\nThe string {input} is a palindrome, true or false? {IsPalindrome(input)}");
        }
    }
}
