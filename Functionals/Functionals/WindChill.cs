using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class conatins the code about windchill of whether
    /// </summary>
    class WindChill
    {
        /// <summary>
        /// Calcualted the windchill for given tempreture and velocity
        /// By using the formula of windchill and math functions
        /// </summary>
        public void windChill()
        {
            Console.Write("Please enter the temptreture of the windchill: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the speed of windchill: ");
            int velocity = Convert.ToInt32(Console.ReadLine());

            if (temp > 50 && velocity > 120 || velocity < 3)
                Console.WriteLine("Please enter the correct inputs!!");

            else
            {
                double windchill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * (Math.Pow(velocity, 0.16));
                Console.WriteLine("The windchill is: " + windchill);
            }

        }
    }
}
