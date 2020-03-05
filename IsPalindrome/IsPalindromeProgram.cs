using System;

namespace IsPalindrome
{
    class Program
    {
        public static bool IsPalindrome(string input)
        {
            int j = input.Length-1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[j--])
                    return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "racecar";
            Console.WriteLine($"racecar? {IsPalindrome(input)}");
            input = "car";
            Console.WriteLine($"car? {IsPalindrome(input)}");
            input = "Mom";
            Console.WriteLine($"Mom? {IsPalindrome(input)}");
            input = "mom";
            Console.WriteLine($"mom? {IsPalindrome(input)}");
        }
    }
}
