using System;

namespace Quiz_04FEB2020
{
    class Quiz_04FEB2020Program
    {
        public static int QuestionOne()
        {
            int y = 5;
            int x = 1;
            do
            {
                x += y;
            } while (y-- > 1);

            return x;
        }

        public static bool QuestionTwo()
        {
            bool x;
            int a = 4;
            int b = 4;

            a = ++a;
            b = b & 1;
            x = (a == b);
            return x; 
        }

        public static int QuestionThree(int x=5)
        {
            int y = 2;
            if (x > y)
            {
                x %= y;
                QuestionThree(x);
            }
            return x;
        }

        public static int QuestionFour()
        {
            int x = 0;
            int y = 5;
            for (int i = y; i > 0; i--)
            {
                x += (i % 2 == 1) ? i : y;
            }
            return x;
        }

        public static int QuestionFive()
        {
            int x = 0;
            int y = 3;
            bool isTrue = true;
            while (!isTrue)
            {
                x += ++y;
                if (x >= 12)
                {
                    isTrue = (!false);
                }
            }
            return x;
        }

        public static int QuestionSix()
        {
            string string1 = "Mississippi";
            string string2 = "";
            //bool isTrue = true;
           
            foreach (var s in string1.Split('i'))
            {
                string2 += s;
            }
            int x = string2.Length;
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quiz Answers 04FEB2020");
            Console.WriteLine($"{QuestionOne()}");
            Console.WriteLine($"{QuestionTwo()}");
            Console.WriteLine($"{QuestionThree()}");
            Console.WriteLine($"{QuestionFour()}");
            Console.WriteLine($"{QuestionFive()}");
            Console.WriteLine($"{QuestionSix()}");
        }
    }
}
