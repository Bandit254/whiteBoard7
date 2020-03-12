using System;

namespace UniqueArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the number of unique elements in an array.\n");
            int[] inputArray = new int[] { 1, 2, 3, 3, 3, 4, 5, 6, 4, 5, 7 };
            //Unique items should be 7
            //int count = CountUniqueArrayItems(inputArray);
            //Console.WriteLine($"The number of unique items in the array is {count}");

            //int dicstint = CountDistinctArrayItems(inputArray);
            //Console.WriteLine($"The number of distinct items in the array is {count}");

            int countDistinct = DistinctArrayCount(inputArray);
            Console.WriteLine($"The count of the distinct items is {countDistinct}");
        }

        public static int CountUniqueArrayItems(int[] inputArray)
        {//Does not count the first duplicated number if it is adjacent to a number of the same value
            int notDistinct = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i+1; j <= inputArray.Length-1; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        notDistinct++;
                    }
                }
            }
            int distinct = inputArray.Length - notDistinct;

            return distinct;
        }

        public static int CountDistinctArrayItems(int[] inputArray)
        {//Does not count the first duplicated number if it is adjacent to a number of the same value
            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isNew = true;
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i]==inputArray[j] && j!=i)
                    {
                        isNew = false;
                    }
                }
                if (isNew==true)
                {
                    count++;
                }

            }
            return count;
        }


        public static int DistinctArrayCount(int[] inputArray)
        {
            int countDistinct = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isNew = true;
                for (int j = i-1; j > 0; j--)
                {
                    if (inputArray[j]==inputArray[i])
                    {
                        isNew = false;
                    }
                }
                if (isNew)
                {
                    countDistinct++;
                }
            }

             

            return countDistinct;
        }
    }
}
