using System;

namespace Quiz1___28JAN2020
{
    class Program
    {

        public static int QuestionOne()
        {
            int x = 4;
            int y = 0;

            for (int i = 0; i < x; i++)
            {
                y += i;
            }

            x = y;
            return x;
        }

        public static int QuestionTwo()
        {
            int y = 7;
            int x = ++y;
            x *= 5;
            return x;
            
        }

        public static int QuestionThree()
        {
            int y = 7;
            int x = 0;

            do
            {
                x += y;
            }
            while (y-- > 1);
            return x;
        }

        public static string QuestionFour()
        {
            int y = 10;
            string x = "";
            string text = "TheQuickBrownFox";

            while (y > 0)
            {
                x += text[y];
                y -= 2;
            }
            return x;
        }

        public static int QuestionFive()
        {
            int x = 8;
            int y = 4;

            x = x % y;
            return x;
        }

        public static void QuestionSix()
        {

        }


        static void Main(string[] args)
        {
            Console.WriteLine("C# Quiz 1 - 28JAN2020");
            Console.WriteLine($"The answer to Question #1 is: {QuestionOne()}");
            Console.WriteLine($"The answer to Question #2 is: {QuestionTwo()}");
            Console.WriteLine($"The answer to Question #3 is: {QuestionThree()}");
            Console.WriteLine($"The answer to Question #4 is: {QuestionFour()}");
            Console.WriteLine($"The answer to Question #5 is: {QuestionFive()}");
        }
    }
}
