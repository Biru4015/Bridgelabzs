using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class  conatins the code about find the roots of quadratic equation
    /// </summary>
    class QuadraticRoots
    {
        /// <summary>
        /// This method is created for finding the roots of quadratic equations
        /// It is for only one condition when delta value is positive
        /// </summary>
        public void quadraticRoots()
        {
            Console.WriteLine("Please the coeffients of quadratic equation");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The roots of quadratic equation are:");
                Console.WriteLine(root1);
                Console.WriteLine(root2);
            }
            else
            {
                Console.WriteLine("The delta is less than or equals to zero!!");
            }
        }
    }
}
