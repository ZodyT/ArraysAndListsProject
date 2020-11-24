using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var Evens = new List<int>();
            var Odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var num in Array)
            {
                if (num % 2 == 0)
                {
                    Evens.Add(num);
                    Console.WriteLine($"{num} is an even number.");
                }
                else
                {
                    Odds.Add(num);
                    Console.WriteLine($"{num} is an odd number.");
                }

                /* Now using foeach or for loops,
                 * display each List of even and odd numbers
                 */


                //foreach (var Even in Evens)
                //{
                //    Console.WriteLine($"{Even} is an even number.");
                //}

                //foreach (var Odd in Odds)
                //{
                //    Console.WriteLine($"{Odd} is an odd number.");
                //}


            }
        }
    }
}
