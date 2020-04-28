using System;

namespace SelectionSortV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing a selection sort algorithm\n");
            int[] array = new int[] { 6, 3, 7, 2, 1, 4, -3, 5, 5 , 100, 1, 3, 67};
            int[] sortedArray = SelectionSort(array);
            foreach (int x in sortedArray)
            {
                Console.Write($"{x} ");
            }
        }
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                //Assume that the starting index also corresponds to the minimum value in the array.
                //Call this index 'indexOfMin'
                int indexOfMin = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    //Check the rest of the array to see if the values at other indexes are smaller than the value at the current 'indexOfMin'
                    //If the value at an index other than indexOfMin is smaller than the value at indexOfMin, 
                    //then you need to update indexOfMin
                    if (array[j]<array[indexOfMin])
                    {
                        //update indexOfMin to the index of the current smallest value:
                        indexOfMin = j;
                    }
                }
                //If the indexOfMin has changed from the original asumption that is was equal to i,
                //then that means the value at i is not the smallest value.
                //Therefore, you need to swap the value at index i with the value at index indexOfMin:
                if (indexOfMin!=i)
                {
                    int temp = array[i];
                    array[i] = array[indexOfMin];
                    array[indexOfMin] = temp;
                }
            }
            return array;
        }
    }
}
