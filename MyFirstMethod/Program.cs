using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invoke CountTo10 method twice
            CountTo10();
            CountTo10();

            // Invoke CountToN method with 2 different values
            CountToN(5);
            CountToN(7);
        }

        private static void CountTo10()
        {
            // Invoke CountToN method with 10 as value
            CountToN(10);
        }

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
