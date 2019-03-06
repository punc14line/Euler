using System;

namespace Problem5
{
    class Program
    {
        /* The run time for this fucntion is O(n * k) 
         *  
         * The while loop runtime is O(n) where n is the MaxValue of int.
         * The for loop runtime is O(k) where k is the amount of numbers we have to check.
         * 
         */
        static int SmallestNumber(int min, int max)
        {
            int rValue = max;
            bool found = false;

            // Loop untile the value is found or we reach the MaxValue for int
            while (!found && rValue < int.MaxValue)
            {
                // Check the divisible of each number
                for (int i = min; i <= max; i++)
                {
                    found = true;
                    if (rValue % i != 0)
                    {
                        found = false;
                        /* We increment the rValue by the max number since
                         * we need the rValue to be divisible by all numbers
                         * since max number can not be a factor of smaller 
                         * numbers we need to make sure that rValue can 
                         * have the max number as a factor.
                         */
                        rValue += max;
                        break;
                    }
                }
            }

            if (rValue == int.MaxValue)
            {
                rValue = -1;
            }

            return rValue;
        }

        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Problem " + num + " of Project Euler\n" +
                                "https://projecteuler.net/problem=" + num + "\n" +
                                "\n" +
                                "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\n" +
                                "\n" +
                                "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?\n" +
                                "\n" +
                                "Here is the answer:");

            Console.WriteLine(SmallestNumber(1, 20));
        }
    }
}
