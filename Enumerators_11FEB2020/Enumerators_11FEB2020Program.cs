using System;

namespace Enumerators_11FEB2020
{
    class Enumerators_11FEB2020Program
    {
        public enum CardSuits { Hearts, Diamonds, Clubs, Spades}
        //A string array of n items (you can specifiy the number or let the IDE determine based on how many items you enter)
        //An array is a variable
        //You can reference items in the array by specify the index position of the desired item - monthNames[n]
        //Ensure that the index of the array matches the index of the enum you are refrencing 
        string[] monthNames =
        {
            "jan", "feb", "mar","apr","may","jun",
            "jul","aug","sep","oct","nov","dec",
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Playinw with Enumerators\n");

            for (int i = 0; i <= (int)CardSuits.Spades; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
