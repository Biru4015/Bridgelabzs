using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class conatins the code about distinct coupan number
    /// </summary>
    class DistinctCoupan
    {
        /// <summary>
        /// To find distinct coupan for the given number by the user
        /// This program done by using random function which is inbuilt method in Random class in c#
        /// </summary>
        public void distinctCoupan()
        {
            Console.Write("Please enter how many number to be genrated: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            while (number > 0)
            {
                int random1 = random.Next(10);
                int random2 = random.Next(10, 20);
                int random3 = random.Next(100, 200);
                int random4 = random.Next(500, 1000);
                Console.Write("The coupan " + number + " is:");
                Console.WriteLine(random1 + "" + random2 + "" + random3 + "" + random4);
                number--;
            }

        }
    }
}
