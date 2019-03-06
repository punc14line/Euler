using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        /* This is a brute force implementation of finding prime factors for the given number
         * 
         * The runtime on this function is O(n) where n is the given number in question. 
         * The reason being is if the given number is in fact prime then the largest prime 
         * factor would be itself.
         */
        static long LargestPrimeFactor(long max)
        {
            long rValue = max;
            long factorCheck = 2;

            // loop until factorCheck is equal to given number.
            while (factorCheck <= max)
            {
                // Check if the current factorCheck is a factor of the max number
                if (max % factorCheck == 0)
                {
                    rValue = factorCheck;
                    // In order to try and reach a solution faster go ahead and 
                    // divide by the given number by the current factor
                    max = max / factorCheck;
                }
                factorCheck++;
            }
            
            return rValue;
        }

        static void Main(string[] args)
        {
            int num = 2;
            long check = 600851475143;
            Console.WriteLine("Problem " + num + " of Project Euler\n" +
                                "https://projecteuler.net/problem=" + num + "\n" +
                                "\n" +
                                "The prime factors of 13195 are 5, 7, 13 and 29.\n" +
                                "\n" +
                                "What is the largest prime factor of the number 600851475143?\n" +
                                "\n" +
                                "Here is the answer to " + check + ":");

            Console.WriteLine(LargestPrimeFactor(check));
        }
    }
}


