using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class conatins the code about prime factors  
    /// </summary>
    class PrimeFcators
    {
        /// <summary>
        /// Finding the prime factors of a given number 
        /// </summary>
        public void primeFactors()
        {
            Console.Write("Please enter the number to be find prime factors: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors are as follows: ");
            for (int var = 2; var <= number; var++)
            {
                while (number % var == 0)
                {
                    Console.WriteLine(var);
                    number = number / var;
                }
            }
            if (number > 2)
                Console.WriteLine(number);
        }
    }
}
