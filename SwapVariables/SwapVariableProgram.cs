using System;

namespace SwapVariables
{
    class SwapVariableProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swapping Variable Values\n");
            //Given a pair of values, switch their positions without declaring any additional temporary variables
            int x = 1;
            int y = 5;
            Console.WriteLine($"The initial value of x is {x} and the initial value of y is {y}\n");
            SwapVariables(ref x,ref y);

        }

        public static void SwapVariables(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($"The value of x is now {x} and the value of y is now {y}");
        }
    }
}
