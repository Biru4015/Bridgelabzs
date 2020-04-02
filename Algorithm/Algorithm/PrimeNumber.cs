using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class contains the code for finding prime number in the given range
    /// </summary>
    class PrimeNumber
    {
        /// <summary>
        /// Purpose of this method is enter the  range and find prime number
        /// </summary>
        public void primeNumber()
        {
            Console.WriteLine("Please enter the starting number: ");
            int sn = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter the ending number: ");
            int en = Convert.ToInt32(Console.ReadLine());

            for(int var=sn;var<=en;var++)
            {
                if(isPrime(var))
                {
                    Console.WriteLine(var);
                }
            }

        }

        /// <summary>
        /// This method check the given number is prime or not
        /// and return the boolean value to above method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static Boolean isPrime(int number)
        {
            int count = 0;

            for(int var=1;var<=number;var++)
            {
                if(number%var==0)
                {
                    count++;
                }
            }

            if (count == 2)
                return true;
            else
                return false;
        }
    
    }
}
