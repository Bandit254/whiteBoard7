using System;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prompt the user to input an array of numbers, copy the given array, and print the copied array to the console");
            CopyArray();
        }

        public static void CopyArray()
        {
            Console.WriteLine("How many numbers do you want in your array?");
            int numItems = Convert.ToInt32(Console.ReadLine());

            int[] inputArray = new int[numItems];
            int userInput;

            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine("Enter the next number:");
                userInput = Convert.ToInt32(Console.ReadLine());
                inputArray[i] = userInput;
            }

            int[] copyArray = new int[numItems];

            for (int i = 0; i < numItems; i++)
            {
                copyArray[i] = inputArray[i];
            }

            foreach (int x in copyArray)
            {
                Console.Write($"{x} ");
            }           
                
            

        }

    }
}
