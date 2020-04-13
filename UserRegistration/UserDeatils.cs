using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// This class cantains the code of user deatils 
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// Purpose of this method is creating for validate first name
        /// </summary>
        public void FirstNameMethod()
        {
            Console.Write("Enter your frist name: ");
            String fname = Console.ReadLine();
            Regex firstname = new Regex(@"^[A-Z][a-z]{2,}$");
            if (firstname.IsMatch(fname))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        /// <summary>
        /// Purpose of this method is creating for validate last name
        /// </summary>
        public void LastNameMethod()
        {
            Console.Write("Enter your last name: ");
            String fname = Console.ReadLine();
            Regex firstname = new Regex(@"^[A-Z][a-z]{2,}$");
            if (firstname.IsMatch(fname))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
