using System;

namespace CountingCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a monetary amount and four coins of different denominations, return the equivalent amount expressed in the fewest number of coins");
            
            CountCoins(1.37M, 0.01M, 0.25M, 0.05M, 0.10M);

        }

        public static void CountCoins(decimal dollarAmount, decimal coin1Denom, decimal coin2Denom, decimal coin3Denom, decimal coin4Denom)
        {
            //Multiply the monetary denominations by 100 and cast the result to INT in order to make the division operations easier to understand
            coin1Denom *= 100;
            coin2Denom *= 100;
            coin3Denom *= 100;
            coin4Denom *= 100;

            int coin1INT = (int)coin1Denom;
            int coin2INT = (int)coin2Denom;
            int coin3INT = (int)coin3Denom;
            int coin4INT = (int)coin4Denom;

            //Initialize variables to hold the number of each type of coin that is required to total the desired monetary amount
            int numCoin1 = 0;
            int numCoin2 = 0;
            int numCoin3 = 0;
            int numCoin4 = 0;

            //Multiple the monetary (dollar) amount by 100, then cast to INT to make the division and modulo operations easier to understand
            dollarAmount *= 100;
            int numCents = (int)dollarAmount;

            //Declare a remainder variable to capture the result of the modulo operations 
            int remainder;

            //Create an array with the INT values of the coin denominations, then sort them from smallest to biggest to ensure you calculate the number of the largest coin first and the number of the smallest coin last
            int[] coinDenomArray = { coin1INT, coin2INT, coin3INT, coin4INT };
            Array.Sort(coinDenomArray);

            //Step 1: Since you do not know in advance which coin will be the largest, initialize a generic variable to hold the number of the largest denomination coins you can obtain from the initial monetary amount
            int num1stBiggest = numCents / coinDenomArray[3];
            //Step 2: Assign the remainder variable to the value of the monetary value modulo the value of the largest coin denomination
            remainder = numCents % coinDenomArray[3];
            //repeate steps 1 and 2 to determine the number of the 2nd and third largest coin denominations
            int num2ndBiggest = remainder / coinDenomArray[2];
            remainder = remainder % coinDenomArray[2];
            int num3rdBiggest = remainder / coinDenomArray[1];
            //The number of the smallest coin that you need is equal to the remainder modulo the 3rd largest coin (essentially, final coin should account for whatever is left over)
            int num4thBiggest = remainder % coinDenomArray[1];

            //Assigning the number of coins of the biggest denomination to the appropriate coin
            if (coinDenomArray[3]==coin1INT)
            {
                numCoin1 = num1stBiggest;               
            }
            else if(coinDenomArray[3]==coin2INT)
            {
                numCoin2 = num1stBiggest;                
            }
            else if (coinDenomArray[3] == coin3INT)
            {
                numCoin3 = num1stBiggest ;               
            }
            else if (coinDenomArray[3] == coin4INT)
            {
                numCoin4 = num1stBiggest;               
            }
            //Assigning the number of coins of the 2nd biggest denomination to the appropriate coin
            if (coinDenomArray[2] == coin1INT)
            {
                numCoin1 = num2ndBiggest;               
            }
            else if (coinDenomArray[2] == coin2INT)
            {
                numCoin2 = num2ndBiggest;                
            }
            else if (coinDenomArray[2] == coin3INT)
            {
                numCoin3 = num2ndBiggest;                
            }
            else if (coinDenomArray[2] == coin4INT)
            {
                numCoin4 = num2ndBiggest;                
            }

            //Assigning the number of coins of the 3rd biggest denomination to the appropriate coin
            if (coinDenomArray[1] == coin1INT)
            {
                numCoin1 = num3rdBiggest;                
            }
            else if (coinDenomArray[1] == coin2INT)
            {
                numCoin2 = num3rdBiggest;                
            }
            else if (coinDenomArray[1] == coin3INT)
            {
                numCoin3 = num3rdBiggest;                
            }
            else if (coinDenomArray[1] == coin4INT)
            {
                numCoin4 = num3rdBiggest;                
            }

            //Assigning the number of coins of the 4th biggest denomination to the appropriate coin
            if (coinDenomArray[0] == coin1INT)
            {
                numCoin1 = num4thBiggest;
            }
            else if (coinDenomArray[0] == coin2INT)
            {
                numCoin2 = num4thBiggest;
            }
            else if (coinDenomArray[0] == coin3INT)
            {
                numCoin3 = num4thBiggest;                
            }
            else if (coinDenomArray[0] == coin4INT)
            {
                numCoin4 = num4thBiggest;                
            }

            Console.WriteLine($"The fewest number of coins needed is {numCoin1} of Coin #1, {numCoin2} of Coin #2, {numCoin3} of Coin #3, and {numCoin4} of Coin #4");

        }
    }
}
