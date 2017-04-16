using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFizzBuzz(1, 200);

            Console.WriteLine("Hit the 'Enter' key to close the console window.");

            // Wait with the console open.
            Console.ReadLine();
        }

        /// <summary>
        /// Loop through all integers between the provided start and end integers (incluseively).  For each
        /// integer, if 3 divides it, print "Fizz;" if 5 divides it, print "Buzz;" if both 3 and 5
        /// divide it, print "FizzBuzz."  If neither 3 nor 5 divides it, print the integer.
        /// </summary>
        /// <param name="startInclusive">The lower bounds for loop.  (Inclusive)</param>
        /// <param name="endInclusive">The upper bounds for the loop. (Inclusive)</param>
        private static void PrintFizzBuzz(int startInclusive = 1, int endInclusive = 100)
        {
            // Loop through provided integers.
            for (int i = startInclusive; i <= endInclusive; i++)
            {
                // Check if 3 divides the integer.  If so, print "Fizz" without going
                // to a new line (so we can print "Buzz" on the same line if necessary.
                // Store if 3 divided it, so we can decide if we need to print the integer.
                bool mod3 = false;
                if (mod3 = (i % 3 == 0))
                    Console.Write("Fizz");

                // Check if 5 divides the integer.  If so, print "Buzz."  Store if 5 divided it.
                bool mod5 = false;
                if (mod5 = (i % 5 == 0))
                    Console.Write("Buzz");

                // If neither 3 nor 5 divided the integer, print the integer.
                if (!mod3 && !mod5)
                    Console.Write($"{i}");

                // Move to next line
                Console.WriteLine();
            }
        }
    }
}
