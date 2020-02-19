using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the Vowels in a Word");
            CountVowels();
        }

        public static void CountVowels()
        {
            Console.Write("Input a string to count the vowels: ");
            string input = Console.ReadLine();
            string lowerInput = input.ToLower();
            int counter = 0;
            for (int i = 0; i<input.Length; i++)
            {
                if (lowerInput[i] == 'a' || lowerInput[i] == 'e' || lowerInput[i] == 'i' || lowerInput[i] == 'o' || lowerInput[i] == 'u')
                    {
                        counter++;
                }
            }
            Console.WriteLine("There are " + counter + " vowels in the string.");
        }
    }
}
