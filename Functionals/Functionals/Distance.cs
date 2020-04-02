using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class contains the code about calculate    Euclidean distance
    /// </summary>
    class Distance
    {
        /// <summary>
        /// This program is for finding  Euclidean distance between origin and given coordinates
        /// Using math class inbuilt method 
        /// </summary>
        public void distance()
        {
            Console.WriteLine("Please enter any two points coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine("The distance between any coordinate to origin: " + distance);
        }
    }
}
