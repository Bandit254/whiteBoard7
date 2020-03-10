using System;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ReadTextFile();
            //PrintFileToConsole();
            //CountTextFileLines();
            //CountEmpyLines();
            //CountWords();
            CountUniqueWords();
        }
        public static void ReadTextFile()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\pc\Desktop\Eisbrecher_Metall_Lyrics");
        }

        public static void PrintFileToConsole()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\pc\Desktop\Eisbrecher_Metall_Lyrics");
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
        public static void CountTextFileLines()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\pc\Desktop\Eisbrecher_Metall_Lyrics");
            Console.WriteLine($"The number of lines in the song is {lines.Length}");
        }
        public static void CountEmpyLines()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\pc\Desktop\Eisbrecher_Metall_Lyrics");
            Console.WriteLine($"The number of lines in the song is {lines.Length}");
            int counter = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] =="")
                {
                    counter++;
                }
            }
            Console.WriteLine($"The number of lines in the song is {lines.Length}, {counter} of which are empty (blank spaces between verses)");
        }
        public static void CountWords()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\pc\Desktop\Eisbrecher_Metall_Lyrics");
            string[] words = text.Split(' ');
            int numWords = words.Length;
            Console.WriteLine($"The number of words in the song is {numWords}");
        }

        public static void CountUniqueWords()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\pc\Desktop\Eisbrecher_Metall_Lyrics");
            string[] words = text.Split(' ');
            int numUniqueWords = 0;
            int numRepeatedWords = 0;
            
            for (int i = 0; i < words.Length-1; i++)
            {
                bool isDistinct = true;
                for (int j = i+1; j < words.Length; j++)
                {
                    if (words[i]==words[j])
                    {
                        isDistinct = false;
                        
                        //break;
                    }
                }
                if (isDistinct)
                {
                    numUniqueWords++;
                }
            }
            //numUniqueWords = words.Length - numRepeatedWords;
            Console.WriteLine($"The number of unique words in the song is {numUniqueWords}");

        }

    }
}
