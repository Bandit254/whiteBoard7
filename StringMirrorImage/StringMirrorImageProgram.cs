using System;

namespace StringMirrorImage
{
    public class StringMirrorImageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mirror Image of a Given String");
            string mirrorString = MirrorImageString("Hello");
            Console.WriteLine($"{mirrorString}");
        }

        public static string MirrorImageString(string inputString)
        {
            string mirrorString = "";
            for (int i = 0; i <= inputString.Length - 1; i++)
            {
                mirrorString+= inputString[inputString.Length - 1 - i];
            }

            return mirrorString;
        }
    }
}
