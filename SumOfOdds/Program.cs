using System;

namespace _22JAN2020_Class_Examples
{
    class Program
    {

        public static int SUmOfOdds(int nCount)
        //always try to make your method names descriptive
        //make the method "public" because you might want to use them later on
        //public methods should always be named with capital letters in Pascal Case so that you can call them again
        //the method is "static" because you're not instantiating the class (more on this later)
        {
            int sum = 0;
            int nextOddNumber = 1;
            for (int i = 0; i < nCount; i++)
            {
                sum += nextOddNumber;
                nextOddNumber += 2;
                //the "+=" operator is the same as saying variable = variable + number (nextOddNumber = nextOddNumber + 2)
                Console.Beep();
           
            }
            //if you want to be able to see the final value of your counter, you need to define it outside of the method
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfOdds");
            int n = 3;
            Console.WriteLine($"\tsum of first {n} odds is: {SUmOfOdds(n)}");
        }




    }

}
