using System;

namespace ReturnLongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the longest word from a given sentence");
            LongestWord();
        }

        public static void LongestWord()
        {
            Console.WriteLine("Input a sentence of at least two words.");
            string inputSentence = Console.ReadLine();
            string[] inputArray = inputSentence.Split(" ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[j].Length<inputArray[i].Length)
                    {
                        string temp = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = temp;
                    }
                }
            }


            string longestWord = inputArray[0];
            Console.WriteLine($"The longest word in the sentence is {longestWord}");
        }


    }
}
