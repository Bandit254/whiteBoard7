using System;

namespace InterfaceExample
{
    class InterfaceExampleProgram
    {

        public static void Main(string[] args)
        {
            var mediaPlayer = new DVDPlayer();
            Console.WriteLine($"My new media player is called {mediaPlayer}");
        }
    }
}
