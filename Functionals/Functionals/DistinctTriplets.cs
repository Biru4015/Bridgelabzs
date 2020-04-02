using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class contains the code about disticnt triplets 
    /// </summary>
    class DistinctTriplets
    {
        /// <summary>
        /// This method is for finding distinct triplet in the given one dimension array
        /// We have to find the triplets which has sum of that triplet is equals to zero 
        /// </summary>
        public void distinctTriplets()
        {
            Console.Write("Plaese enter the length of array: ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] maxtix = new int[arraysize];

            for (int col = 0; col < arraysize; col++)
            {
                maxtix[col] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The triplets of given array are as:");
            for (int var1 = 0; var1 < arraysize - 2; var1++)
            {

                for (int var2 = var1 + 1; var2 < arraysize - 1; var2++)
                {

                    for (int var3 = var2 + 1; var3 < arraysize; var3++)
                    {

                        if (maxtix[var1] + maxtix[var2] + maxtix[var3] == 0)
                        {
                            Console.WriteLine(maxtix[var1] + " " + maxtix[var2] + " " + maxtix[var3]);
                        }

                    }

                }

            }

        }
    }
}
