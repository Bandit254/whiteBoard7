using System;

namespace Quiz09APR2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz answers from 09APR2020.\n");
            Console.WriteLine($"{Question1()}");
            Console.WriteLine($"{Question2()}");
            Console.WriteLine($"{Question3()}");
            Console.WriteLine($"{Question4()}");
            Console.WriteLine($"{Question5()}");
            Console.WriteLine($"{Question6()}");
        }
        public static int Question1()
        {
            int y = 5;
            int x = 1;
            do
            {
                x += y;
            } while (y-- > 1);

            return x;
        }
        public static bool Question2()
        {
            bool x;
            int a = 4;
            int b = 4;
            a = ++a;
            b = b & 1;
            x = (a == b);
            return x;
        }
        public static int Question3(int x = 5)
        {
            int y = 2;
            if (x > y)
            {
                x %= y;
                Question3(x);
            }
            return x;
        }
        public static int Question4()
        {
            int x = 0;
            int y = 5;

            for (int i = y; i > 0; i--)
            {
                x += (i % 2 == 1) ? i : y;
            }
            return x;
        }
        public static int Question5()
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
        public static int Question6()
        {
            string string1 = "Mississippi";
            string string2 = "";
            foreach (var s in string1.Split('i'))
            {
                string2 += s;
            }
            int x = string2.Length;
            return x;
        }
    }
}
