using System;
using System.Collections.Generic;
using System.Text;

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
