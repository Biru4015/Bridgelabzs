using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Functionals
{
    /// <summary>
    /// This class contains the code of stop watch
    /// </summary>
    class StopWatch
    {

        /// <summary>
        /// This method is created the time elapsed between start and stop
        /// It is done by using Stopwatch class which is inbuilt class in c#
        /// </summary>
        public void stopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            stopwatch.Stop();

            Console.WriteLine("Time elapsed is: " + stopwatch.Elapsed);
        }
    }
}
