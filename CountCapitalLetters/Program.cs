using System;

namespace CountCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a string with both upper and lower case letters, write a method that returns the number of capital letters in the string:\n");
            string inputString = "Hello World!";
            
            Console.WriteLine($"The number of capital letters in '{inputString}' is {CountCapitalLetters(inputString)}");

        }


        public static int CountCapitalLetters(string inputString)
        {
            int count = 0;
            string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = 0; j < capitalLetters.Length; j++)
                {
                    if (String.Equals(inputString[i], capitalLetters[j]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }


    }
}
