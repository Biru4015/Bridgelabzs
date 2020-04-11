namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This class cantains the code of printing the calendar of given month and year
    /// </summary>
    public class Calendar
    {
        public static int day(int month, int day, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }

        /// <summary>
        /// return true if the given year is a leap year
        /// </summary>
        /// <param name="year"></param>
        /// <returns>boolean</returns>
        public static bool isLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                return true;
            else
               return false;
        }

        /// <summary>
        /// Purpose of this method is for driver 
        /// </summary>
        public void calanderDriver()
        {
            Console.Write("Please eneter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());     // month (Jan = 1, Dec = 12)
            Console.Write("Please enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());     // year

            // months[i] = name of month i
            String[] months = {
            "",                               // leave empty so that months[1] = "January"
            "January", "February", "March",
            "April", "May", "June",
            "July", "August", "September",
            "October", "November", "December"
        };

            // days[i] = number of days in month i
            int[] days = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (month == 2 && isLeapYear(year)) days[month] = 29;     // check for leap year
            Console.WriteLine("   " + months[month] + " " + year);      //// print calendar header
            Console.WriteLine(" S  M Tu  W Th  F  S");
            int d = day(month, 1, year); // // starting day

            // print the calendar
            for (int i = 0; i < d; i++)
            {
                Console.Write("   ");
            }
            for (int i = 1; i <= days[month]; i++)
            {
              String msg = String.Format("{0,2} ", i);
                Console.Write(msg);
                if (((i + d) % 7 == 0) || (i == days[month])) 
                    Console.WriteLine();
            }

        }
    }
}
