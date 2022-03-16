using System;

namespace Fibonacci
{
    /// <summary>
    /// This program reveals a number from the Fibonacci sequence, in the
    /// position requested by the user.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Requests a number from the user, and uses it as an index to find
        /// the corresponding number in the Fibonacci sequence, through the 
        /// Fibonacci method.
        /// </summary>
        /// <param name="args">Arguments given through the console</param>
        static void Main(string[] args)
        {
            // Stores the user input
            int n;

            // Stores a number from the Fibonacci sequence
            int fib;

            if (args.Length == 0)
            {
                // Requests user input
                Console.WriteLine("Look for a number in the Fibonacci sequence");
                Console.Write("Number position: ");

                // Store user input in variable
                n = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                // Store command line value in variable
                n = Convert.ToInt32(args[0]);
            }

            // Execute Fibonacci method with user input
            fib = Fibonacci(n);

            // Reveal number in requested position
            Console.WriteLine(
                $"Number in position {n} of the Fibonacci sequence: {fib}");
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
