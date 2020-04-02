using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class conatains the code of gambler game simulation
    /// </summary>
    class Gambler
    {
        /// <summary>
        /// Welcome to gambler game
        /// Here a gambler is playing game who start with some stake
        /// And finally he either reaches the gaol or lost all the cash
        /// There should be given number of trails also
        /// </summary>
        public void gambler()
        {
            Console.Write("Please enter the stake: ");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the goal: ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the number of trails: ");
            double trails = Convert.ToInt32(Console.ReadLine());
            int bets = 0;
            double wins = 0;

            //repeat trails time
            for (int t = 0; t < trails; t++)
            {
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    Random random = new Random();
                    bets++;
                    if (random.Next() % 2 == 0)
                        cash++;
                    else
                        cash--;
                }
                if (cash == goal)
                    wins++;
            }
            Console.WriteLine("Number of wins is equals to: " + wins);
            double winpercent = (wins / trails) * 100;
            double losspercent = ((trails - wins) / trails) * 100;
            Console.WriteLine("Win percentage is: " + winpercent);
            Console.WriteLine("Loss percentage is: " + losspercent);
        }
    }
}
