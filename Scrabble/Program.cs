using System;
using System.Collections.Generic;

namespace Scrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrabble Game\n");
            //string input = "apple";
            //Console.WriteLine($"The point value of {input} is {ScrabbleScore(input)}");

            List<string> inputWords = new List<string>();
            int x = 1;
            while (x==1)
            {
                inputWords.Add(Console.ReadLine());
                Console.Write("Enter 1 to keep going: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            int totalScore = 0;
            foreach (string s in inputWords)
            {
                totalScore += ScrabbleScore(s);
            }
            Console.WriteLine($"Total Score is {totalScore}");
            Console.ReadKey();
        }
        public static int[] PointValues = new int[] { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 4, 4, 8, 4, 10 };
        public static int ScrabbleScore(string input)
        {
            string inputUpper = input.ToUpper();
            int score = 0;
            for (int i = 0; i < inputUpper.Length; i++)
            {
                score += PointValues[(int)(inputUpper[i]-'A')];
            }
            return score;
        }
    }
}
