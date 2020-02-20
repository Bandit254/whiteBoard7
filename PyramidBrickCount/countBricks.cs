using System;

namespace PyramidBrickCount
{
    public class countBricks
    {
        public static int CountOfBricks(int pyramidBase, int pyramidHeight, double brickSize)
        {
            int count = 0;

            int area = (pyramidBase * pyramidHeight) / 2;
            count = Convert.ToInt32(Convert.ToDouble(area) / brickSize);

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("PyramidBrickCount.CountBricks.Main()");

            Console.WriteLine($"{CountOfBricks(100, 30, .17)} bricks");
        }
    }
}
