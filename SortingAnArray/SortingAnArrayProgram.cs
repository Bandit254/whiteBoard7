using System;

namespace SortingAnArray
{
    class SortingAnArrayProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting an Array\n");
            int[] inputArray = new int[5] { 5, 4, 3, 2, 5 };

            PrintArray(SortArray(inputArray));
        }

        public static int[] SortArray(int[] inputArray)
        {
            int placeHolder;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i]<inputArray[j])
                    {
                        placeHolder = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = placeHolder;
                    }
                }
            }
            return inputArray;
        }
        public static void PrintArray(int[] inputArray)
        {
            foreach (int value in inputArray)
            {
                Console.Write($"{value} ");
            }
        }



    }
}
