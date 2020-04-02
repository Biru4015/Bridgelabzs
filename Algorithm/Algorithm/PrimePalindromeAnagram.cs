using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This code contains for checking number is prime in given range and also check 
    /// That number is Palindrome and Anagram or not
    /// </summary>
    class PrimePalindromeAnagram
    {
        /// <summary>
        /// The purpose of this method is control the program and the methods
        /// </summary>
        public void primePalindromeAnagram()
        {
            Console.WriteLine("All these numbers are prime,plaindrome ,Prime(1st column) and anagram number which is same as holizontal line ");
            for(int number=0;number<=1000;number++)
            {
                if(checkPrime(number)&&checkPalindrome(number))
                {
                    for(int var=number+1;var<1001;var++)
                    {
                        if(checkAnagram(number,var))
                        {
                            Console.WriteLine(number+" "+var);
                        }
                    }
                }
            }

        }

        /// <summary>
        /// This method is checking number is prime of not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static Boolean checkPrime(int number)
        {
            int count = 0;

            for (int var = 1; var <= number; var++)
            {
                if (number % var == 0)
                {
                    count++;
                }
            }

            if (count == 2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method is checking that number is palindrome or not which is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static Boolean checkPalindrome(int number)
        {
            int sum = 0;
            int t = number;

            while(t>0)
            {
                int r = t % 10;
                sum = (sum * 10) + r;
                t = t / 10;
            }
            if (sum != number)
                return false;
            else
                return true;
        }

        /// <summary>
        /// This method is created for checking that number is anagram or not which number is prime and palindrome
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        private static Boolean checkAnagram(int number1,int number2)
        {
            String str1 = "" + number1;
            String str2 = "" + number2;

            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();

            Array.Sort(array1);
            Array.Sort(array2);

            string s1 = new string(array1);
            string s2 = new string(array2);

            if (s1 == s2)
                return true;
            else
                return false;

        }


    }
}
