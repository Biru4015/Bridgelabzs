using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class contains the code about power of two
    /// </summary>
    class PowerOfTwo
    {
        /// <summary>
        /// This method is created for calculating the power of two upto a given postive number
        /// It is done by using math class pow function 
        /// </summary>
        public void powerOfTwo()
        {
            Console.Write("Please enter any positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The power of two upto given number is as follows:");
            for (int var = 1; var <= number; var++)
            {
                Console.WriteLine(Math.Pow(2, var));
            }
        }
    }
}
