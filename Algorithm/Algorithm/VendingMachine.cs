using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class VendingMachine
    {

        /// <summary>
        /// Purpose : currency return by vending machine
        /// ouput should be  one the number of minimum Note needed to give the change 
        /// and second list of Rs Notes that would given in the Change
        /// </summary>
        public void vendingMachine()
        {
            Console.Write("Please enter the amount to be return change: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            countCurrency(amount);
        }

        // function to count and  
        // print currency notes 
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noteCounter = new int[9];

            // count notes using Greedy approach 
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }
            // Print notes 
            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "+ noteCounter[i]);
                }
            }
        }

    }
}
