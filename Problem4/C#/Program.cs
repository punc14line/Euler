using System;

namespace Problem4
{
    class Program
    {
        /* This function here is for checking if the given number is a Palindrome
         * 
         * The runtime for this function is O(n + log n)
         * Since we first have to see how many digits there are the runtime for the 
         * while loop would be O(log n)
         * Next, the first for loop runtime would be O(n) where n is the number of Digits 
         * the given number is
         * Last, the second for loop runtime woulb be O(n/2) where n is the number of Digits
         * in total the runtime for this function is O(log n) + O(n) + O(n/2) = O(3n/2 + log n) = O(n + log n)
         */
        static bool IsPalindrome(int value)
        {
            int numOfDigits = 0;
            int check = value;

            // Find out how many digits does the number have
            while (check >= 1)
            {
                numOfDigits++;
                check /= 10;
            }
            
            // Create an array with the lenght of the digits
            int[] palArray = new int[numOfDigits];

            check = value;
          
            // Add each digit to the newly created array
            for (int i = 0; i < palArray.Length; i++)
            {
                palArray[i] = check % 10;
                check /= 10;
            }
           
            // Go through half of the array check each element going from the outside to the middle 
            for (int i = 0; i < (palArray.Length / 2); i++)
            {
                if (palArray[i] != palArray[palArray.Length - i - 1])
                {
                    return false;
                }
            } 
            
            return true;
        }

        /* This function takes the given number of digits then generates the largest posible number given that digit.
         * 
         * The runtime for this function would be O( (n + log n)^2) where n is the product of the largest number
         * possible for the given number of digits. Example: Number of digits is 3 so the largest number is 999
         * therefore n = 998001
         */
        static int LargestPalindrome(int numOfDigits)
        {
            int product = 0;
            int rValue = 0;
            int upperBound = (int)Math.Pow(10.0, numOfDigits) - 1;
            int lowerBound = (int)Math.Pow(10.0, (double)numOfDigits - 1);

            // Since we have to find the highest Palindrome, then we will have to check the entire combination
            for (int i = upperBound; i >= lowerBound; i--)
            {
                for (int j = i; j >= lowerBound; j--)
                {
                    product = i * j;
                    if (IsPalindrome(product))
                    {
                        if (product > rValue)
                        {
                            rValue = product;
                        }
                    }
                }
            }

            return rValue;
        }

        static void Main(string[] args)
        {
            int num = 4;
            Console.WriteLine("Problem " + num + " of Project Euler\n" +
                                "https://projecteuler.net/problem=" + num + "\n" +
                                "\n" +
                                "A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\n" +
                                "\n" +
                                "Find the largest palindrome made from the product of two 3-digit numbers.\n" +
                                "\n" +
                                "Here is the answer:");
            Console.WriteLine(LargestPalindrome(3));
        }
    }
}


