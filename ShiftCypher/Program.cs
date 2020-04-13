using System;

namespace ShiftCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement a shift-cypher that can encrypt a plain text message by shifting a certain number of characters. It should also be able to receive an encrypted message and decrypt it by providing the number of spaces used to shift the message originally.\n");
            Console.WriteLine("\nAssume the input strings are in all-caps.\n");
            string encryptedMessage = EncryptMessage("HELLO", 3);
            Console.WriteLine($"{EncryptMessage("HELLO", 3)}.");
            Console.WriteLine($"{EncryptMessage(encryptedMessage, -3)}.");
        }
        public static string EncryptMessage(string input, int numPlaces)
        {
            string encryptedMessage = "";
            char currentChar=' ';
            for (int i = 0; i < input.Length; i++)
            {
                currentChar = (char)(input[i] + numPlaces);
                if (currentChar<'A')
                {
                    int leftOver = Math.Abs(currentChar - 'A');
                    currentChar = (char)('Z' + 1 - leftOver);
                }
                if (currentChar>'Z')
                {
                    int leftOver = Math.Abs(currentChar - 'Z');
                    currentChar = (char)('A' - 1 + leftOver);
                }
                encryptedMessage += currentChar;
            }
            return encryptedMessage;
        }
    }
}
