using System;

namespace ArrayIntegerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort an array of integers.");

            int[] input = new int[] { 4, 2, 7, 1, 10 };
            int[] sortedArray = ArrayIntegerSort(input);
            foreach (int x in sortedArray)
            {
                Console.Write($"{x} ");
            }
        }

        public static int[] ArrayIntegerSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j]>input[i])
                    {
                        int temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                    }
                }
            }
            return input;
        }
    }
}
