using System;

namespace MyFirstMethod
{
    /// <summary>
    /// This class contains 2 methods that print one number per line, 
    /// and invokes them both twice.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Execute both methods in the class.
        /// </summary>
        /// <param name="args">Arguments given through the console</param>
        static void Main(string[] args)
        {
            // Invoke CountTo10 method twice
            CountTo10();
            CountTo10();

            // Invoke CountToN method with 2 different values
            CountToN(5);
            CountToN(7);
        }

        /// <summary>
        /// Print one number per line in order until number 10 is reached.
        /// </summary>
        private static void CountTo10()
        {
            // Invoke CountToN method with 10 as value
            CountToN(10);
        }

        /// <summary>
        /// Print one number per line in order until given number is reached.
        /// </summary>
        /// <param name="n">The given number to count towards</param>
        private static void CountToN(int n)
        {   
            // Loop until given number is equal to 'i'
            for (int i = 1; i <= n; i++)
            {
                // Print one number per line
                Console.WriteLine(i);
            }
        }
    }
}
