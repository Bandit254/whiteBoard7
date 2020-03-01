using System;

namespace ArrayValuesInOrderOfIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define an integer array of 64 values, assign each value to its corresponding index position, and then print the array to the console\n");
            int[] myArray = CreateArray();
            PrintArray(myArray);
        }
        public static int[] CreateArray()
        {
            int[] myArray = new int[64];
            for (int i = 0; i < 64; i++)
            {
                myArray[i] = i;
            }
            return myArray;
        }
        public static void PrintArray(int[] inputArray)
        {
            foreach (int arrayValue in inputArray)
            {
                Console.Write($"{arrayValue} ");
            }
        }

    }
}
