using System;

namespace QuizAnswers_11FEB2020
{
    class QuizAnswers_11FEB2020
    {
        public static int QuestionOne()
        {
            int x = 0b01100011;
            return x;
        }
        public static int QuestionTwo()
        {
            int x = 1;
            do
            {
                x += 10;
            } while (false);
            return x;
        }

        public static int QuestionThree()
        {
            int i;
            for (i = 0; i < 10; i++)
            {

            }
            int x = i;
            return x;
        }
        public static int QuestionFour()
        {
            int y = 4;
            int x = 2;
            do
            {
                x += y;
            } while (y-->1);
            return x;
        }

        public static int QuestionFive()
        {
            int x;
            int value1 = 1;

            do
            {
                var Value1 = 'A';
                Console.WriteLine(Value1++);
            } while (value1-->0);
            x = value1;
            return x;
        }

        public static int QuestionSix()
        {
            int x, y = 55;
            x = y % 10;
            x *= 10;
            x += y / 10;
            return x;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Quiz 11 FEB 2020 Answers");
            Console.WriteLine($"\nThe Answer to Question 1 is: {QuestionOne()}");
            Console.WriteLine($"\nThe Answer to Question 2 is: {QuestionTwo()}");
            Console.WriteLine($"\nThe Answer to Question 3 is: {QuestionThree()}");
            Console.WriteLine($"\nThe Answer to Question 4 is: {QuestionFour()}");
            Console.WriteLine($"\nThe Answer to Question 5 is: {QuestionFive()}");
            Console.WriteLine($"\nThe Answer to Question 6 is: {QuestionSix()}");
        }
    }
}
