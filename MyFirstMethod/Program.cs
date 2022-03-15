using System;

namespace MyFirstMethod
{
    /// <summary>
    /// This class contains 3 methods that print one number per line, 
    /// and invokes them each twice.
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

            // Invoke CountToN method with 2 arguments, with different values
            CountToN(5, 7);
            CountToN(1, 10);
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

        /// <summary>
        /// Print one number per line in order, between first and second
        /// given numbers.
        /// </summary>
        /// <param name="n1">The number that defines the lowest limit</param>
        /// <param name="n2">The number that defines the highest limit</param>
        private static void CountToN(int n1, int n2)
        {
            // Loop until 'i' is equal to last number before second given number
            for (int i = n1 + 1; i < n2; i++)
            {
                // Print one number per line
                Console.WriteLine(i);
            }
        }
    }
}
