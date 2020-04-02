using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class contain the code about replace the string with username
    /// </summary>
    class UserName
    {
        /// <summary>
        /// Taking input from user to username and replace it by <<username>>
        /// Length of username should by greater than three
        /// </summary>
        public void UserName1()
        {
            Console.WriteLine("Please enter the user name:");

            String name = Console.ReadLine(); //Taking input as username by user

            if (name.Length >= 3) //Checking the length of username
            {
                Console.WriteLine("Hello " + name + ", how are you?");
            }
            else
            {
                Console.WriteLine("Please enter a valid name");
            }
        }
    }
}
