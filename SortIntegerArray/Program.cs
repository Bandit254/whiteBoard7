using System;

namespace SortIntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an integer array, sort the integers from least to greatest.\n");
            int[] inputArray = new int[] { 5, 2, 6, 1, 7 };
            int[] sortedArray = SortIntegerArray(inputArray);
            PrintArray(sortedArray);
        }

        public static int[] SortIntegerArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i]< inputArray[j])
                    {
                        int x = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = x;
                    }

                }
            }

            return inputArray;
        }
        public static void PrintArray(int[] inputArray)
        {
            foreach (int x in inputArray)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
