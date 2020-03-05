using System;

namespace Quiz19FEB2020
{
    class Quiz19FEB2020Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz 19 February 2020\n");
            Console.WriteLine($"The answer to Question 1 is {QuestionOne()}\n");
            Console.WriteLine($"The answer to Question 2 is {QuestionTwo()}\n");
            Console.WriteLine($"The answer to Question 3 is {QuestionThree()}\n");
            Console.WriteLine($"The answer to Question 4 is {QuestionFour()}\n");
            Console.WriteLine($"The answer to Question 5 is {QuestionFive()}\n");
            Console.WriteLine($"The answer to Question 6 is {QuestionSix()}\n");
        }

        public static int QuestionOne()
        {
            int[] z = { -99, 0, 1, 2, 3, 5, 8, 13, 21, 34 };
            int x = int.MaxValue;
            foreach (var y in z) x = y < x ? y : x;
            return x;
        }

        public static int QuestionTwo()
        {
            string[] arr = { "the", "quick", "brown", "fox" };
            int x = arr[arr.Length - 1].Length;
            return x;
        }

        public static bool QuestionThree()
        {
            bool x;
            int a = 6;
            int b = 3;
            a = ++a;
            b = b & 1;
            x = (a == b);
            return x;
        }

        public static string QuestionFour()
        {
            string y = "mbilg";
            string x = "";
            for (int i = 0; i < y.Length; i++)
            {
                x += Convert.ToChar(y[i] - i);
            }
            return x;
        }

        public static int QuestionFive()
        {
            int x, y = 93;
            x = y % 10;
            x *= 10;
            x += y / 10;
            return x;
        }

        public static string QuestionSix()
        {
                int happy;
                var hi = true;
                string[] dwarf = { "0:>", ":{", "x)", ":)", "|<", ":|", ":/" };
                for (happy = 0; happy < dwarf.Length; happy++)
                {
                    bool ho = !(hi);
                    hi = ho;
                }
                var x = dwarf[happy / 2] == ":)" ? "hi!" : "ho!";
                return x;
        }
            
        
        


    }
}
