using System;
using System.Collections.Generic;

namespace Euler
{
    class Program
    {
        /* This is the Function created to solve the problem in question.
         * The way that I have implement the solution will get to the answer faster.
         * Instead of checking 1 number at a time, I am going through all 
         * multiples of 3 and adding them to the solution. Then going through 
         * all multiples of 5 and adding them to the solution. When I am going
         * through the multiples of 5 I double check that it is not a multiple of 
         * 3 and has already been added to the sum.
         */
        static int Mult3and5(int max)
        {
            int sum = 0;
            
            // Go through all mulptiples of 3
            for (int i = 1; (i * 3) < max; i++)
            {
                sum += (i * 3);
            }

            // Go through all multiples of 5
            for (int i = 1; (i * 5) < max; i++)
            {
                // Make sure that it is not a multiple of 3
                if (((i * 5) % 3) != 0)
                {
                    sum += (i * 5);
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1 of Project Euler");
            Console.WriteLine("https://projecteuler.net/problem=1");
            Console.WriteLine();
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            Console.WriteLine();
            Console.WriteLine("Here is the answer to 1000:");
            Console.WriteLine(Mult3and5(1000));
        }
    }
}
