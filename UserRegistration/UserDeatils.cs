using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDetails
    {
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
    }
}
