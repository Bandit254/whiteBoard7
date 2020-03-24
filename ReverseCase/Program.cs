using System;

namespace ReverseCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Receive a string from the user and reverse the case of each letter in the string (don't give spaces).\n");
            ReverseCase();
            ReverseStringCase();
        }

        public static void ReverseCase()
        {
            Console.WriteLine("Input a string with no spaces:");
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            char[] reverseArray = new char[input.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (Char.IsUpper(inputArray[i]))
                {
                    reverseArray[i]=Char.ToLower(inputArray[i]);
                }
                else if (Char.IsLower(inputArray[i]))
                {
                    reverseArray[i] = Char.ToUpper(inputArray[i]);
                }
            }
            foreach (char c in reverseArray)
            {
                Console.Write($"{c}");
            }
        }
        public static void ReverseStringCase()
        {
            Console.WriteLine("Input a string with no spaces:");
            string input = Console.ReadLine();
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string reversedCase = "";
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < lowercase.Length; j++)
                {
                    if (String.Equals(input[i], uppercase[j]))
                    {
                        reversedCase+=Char.ToLower(input[i]);
                    }
                    else if (String.Equals(input[i], lowercase[j]))
                    {
                        reversedCase += Char.ToUpper(input[i]);
                    }
                }
            }
            Console.WriteLine($"{reversedCase}");
        }
    }
}
