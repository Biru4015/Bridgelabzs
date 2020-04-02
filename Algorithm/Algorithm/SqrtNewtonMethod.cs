using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class contains code for Square roots using Newton's
    /// </summary>
    class SqrtNewtonMethod
    {
        /// <summary>
        /// Purpose of creating this method is calculating square root using Newton's method
        /// For any nonnegative number like sqrt root of 2 = 1.414213562373095
        /// </summary>
        public void sqrtNewtonMethod()
        {
            Console.Write("Please enter any number to find square root: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1.0e-15;
            double number1 = number;

            //Repeatly apply Netwon update step until desied precision is achieved
            while(Math.Abs(number1-number/number1)>epsilon*number1)
            {
                number1 = (number / number1 + number1) / 2.0;
            }

            //Print the estimated value of square root of number
            Console.WriteLine("The square root of "+number+" = "+number1);
        }
    }
}
