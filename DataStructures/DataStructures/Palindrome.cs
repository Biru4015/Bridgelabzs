namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DataStructures;

    /// <summary>
    /// Purpose of this class is Palindrome checking of string using dequeue
    /// </summary>
    class Palindrome
    {
        /// <summary>
        /// Purpose of this method is for checking string is palindrome or not 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string str)
        {
            ////Adding elements to queue
            Dequeue<char> dq = new Dequeue<char>();
            for (int i = 0; i < str.Length; i++)
            {
                dq.AddRear(str[i]);
            }
            while (!dq.IsEmpty())
            {
                if (dq.Size() == 1)
                {
                    break;
                }
                if (!(dq.RemoveFront().Equals(dq.RemoveRear())))
                {
                    return false;
                }
            }

            return true;
        }

        public void isPalindrome()
        {
            Console.WriteLine("Enter word to check palindrome");
            string word = Console.ReadLine();
            Console.WriteLine(IsPalindrome(word));
        }

    }
}