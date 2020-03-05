using System;

namespace DistinctElementsInArray
{
    class DistinctElementsInArrayProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distinct Array Elements\n");
            //Given an integer array, return the number of distinct elements in that array

            int[] inputArrayOne = new int[5]{ 1, 2, 3, 4, 5 };
            Console.WriteLine($"The number of distinct elements in the array is {CountDistinctArrayElements(inputArrayOne)}\n");
            int[] inputArrayTwo = new int[5] { 1, 1, 1, 1, 5 };
            Console.WriteLine($"The number of distinct elements in the array is {CountDistinctArrayElements(inputArrayTwo)}\n");

        }

        public static int CountDistinctArrayElements(int[] inputArray)
        {
            int count = 0;
            

            for (int i = 0; i < inputArray.Length; i++)
            {
                int checkX = inputArray[i];
                bool isDistinct = true;

                for (int j = 0; j < i; j++)
                {
                    int checkY = inputArray[j];

                    if (checkX == checkY)
                    {
                        isDistinct = false;
                    }
                    
                }
                if (isDistinct) count++;
            }
            return count;
        }
    }
}
