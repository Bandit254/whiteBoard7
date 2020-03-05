using System;

namespace AlphabeticalCharacterStringWhiteboard
{
    class AlphabeticalCharacterStringWhiteboard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a string, return the characters of the string in alphabetical order as a string\n");
            string inputString = "Today is the 13th of February";
            Console.WriteLine($"The alphabetical list of characters in the input string is {AlphabeticalString(inputString)}");
        }


        public static string AlphabeticalString(string inputString)
        {
            string resultString = "";
            inputString = inputString.ToLower();

            for (int i = 'a'; i < 'z'; i++)
            {
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == i)
                    {
                        resultString += (char)i;
                        break;
                    }
                }
            }
            return resultString;
        }




    }
}
