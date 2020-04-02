using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class contains the code for calculationg monthly payment of a loan
    /// </summary>
    class MonthlyPayment
    {
        /// <summary>
        /// Purpose of this method is creating for calculating monthly payment using the formula
        /// </summary>
        public void monthlyPayment()
        {
            Console.Write("Please enter the principle:");
            double princ = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the year:");
            double year = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the rate of interst:");
            double rate = Convert.ToDouble(Console.ReadLine());

            double time = 12 * year;
            double rate1 = rate / (12 * 100);

            double payment = (princ * rate1) / (1 - Math.Pow(1 + rate1, -time));

            Console.WriteLine("The monthly payment of loan= "+payment);

        }
    
    }
}
