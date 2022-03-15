using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib = Fibonacci(8);
            Console.WriteLine(fib);
        }

        /// <summary>
        /// Determines the number in the Fibonacci sequence that corresponds
        /// to the given number.
        /// </summary>
        /// <param name="n">An index for a number in the sequence</param>
        /// <returns>The number in the 'n' position of the sequence</returns>
        private static int Fibonacci(int n)
        {
            // Stores the current number in the sequence
            int fib;

            if (n <= 2)
                // Corresponds to index position 1 or 2, which have value of 1
                fib = 1;
            else
                // Execute recursive operation to obtain correct number
                fib = Fibonacci(n - 2) + Fibonacci(n - 1);
            
            // Return number correspondent to given index
            return fib;
        }
    }
}
