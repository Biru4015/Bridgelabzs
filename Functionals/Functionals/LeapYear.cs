using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class conatins the code about leap year
    /// </summary>
    class LeapYear
    {
        /// <summary>
        /// For finding the leap year of given number
        /// The number should be geater than or equals to 1000
        /// Checking the condition of leap year and print leap year or not
        /// </summary>
        public void leapYear()
        {
            Console.Write("Please enter any year greater than 999:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1000)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    Console.WriteLine("The entered year is leap year");
                else
                    Console.WriteLine("The entered year is not leap year");
            }
            else
                Console.WriteLine("Please enter the valid in input");
        }
    }
}
