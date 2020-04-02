using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class contains the code about flipping the coin
    /// </summary>
    class FlipCoin
    {
        /// <summary>
        /// This method is created to find the head and tail percentage
        /// To find head and tail percentage flip the coin upto given number and find number of tails and heads
        /// </summary>
        public void flippingCoins()
        {
            Console.Write("Please enter the number of trails");
            int trails = Convert.ToInt32(Console.ReadLine());
            float heads = 0;
            float tails = 0;
            int trails1 = trails;
            while (trails > 0)
            {
                Random random = new Random();
                if (random.Next() % 2 == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
                trails--;
            }

            Console.WriteLine(heads);
            Console.WriteLine(tails);


            float headpercent = (heads / trails1) * 100;
            float trailpercent = (tails / trails1) * 100;
            Console.WriteLine("The head percentage is: " + headpercent);
            Console.WriteLine("The tail percentage is: " + trailpercent);
        }
    }
}
