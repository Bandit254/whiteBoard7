using System;

namespace SortStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort an array of strings alphabetically.\n");
            SortStringArray();
        }
        public static void SortStringArray()
        {
            Console.WriteLine("How many strings do you want to store in the array?");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter string #{i + 1}: ");
                string input = Console.ReadLine();
                string lowerInput = input.ToLower();
                strings[i] = lowerInput;
            }
            for (int k = 0; k < arraySize; k++)
            {
                for (int x = 0; x < arraySize; x++)
                {
                    if (k!=x)
                    {
                        string first = strings[k];
                        string second = strings[x];
                        if (first[0] < second[0])
                        {
                            string temp = strings[k];
                            strings[k] = strings[x];
                            strings[x] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("\nThe sorted array is as follows:\n");
            foreach (string s in strings)
            {
                Console.Write($"{s} ");
            }
        }
    }
}
