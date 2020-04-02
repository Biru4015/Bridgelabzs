using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// Harmonic number program 
    /// </summary>
    class HarmonicNumber
    {
        /// <summary>
        /// This method is created for finding the nth harmonic number
        /// By using simple for loop
        /// </summary>
        public void harmonicNumber()
        {
            Console.Write("Enter the number to find the nth harmonic number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            for (int var = 1; var <= number; var++)
            {
                sum = sum + 1.0 / var;

            }
            Console.WriteLine("Nth harmonic number is equals to " + sum);
        }
    }
}
