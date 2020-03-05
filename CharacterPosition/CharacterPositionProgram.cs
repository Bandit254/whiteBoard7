using System;

namespace CharacterPosition
{
    class CharacterPositionProgram
    {
        //Given a string, calculate the position of a specific character in that string. 
        //If the character does not exist in the string, then return a zero.
        //Note: Position = Index +1
        public static int CharacterPosition(string input, char desiredChar)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == desiredChar) return i + 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Character Position");
            Console.WriteLine($"{CharacterPosition("San Diego Zoo", 'g')}");
            Console.WriteLine($"{CharacterPosition("San Diego Zoo", 'l')}");
            Console.WriteLine($"{CharacterPosition("San Diego Zoo", 'Z')}");
            Console.WriteLine($"{CharacterPosition("San Diego Zoo", 'o')}");
            Console.WriteLine($"{CharacterPosition("San Diego Zoo", 'S')}");
        }
    }
}
