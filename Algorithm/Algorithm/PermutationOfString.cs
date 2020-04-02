using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class contains the code for permutations of a given string. 
    /// </summary>
    class PermutationOfString
    {
        /// <summary>
        /// This method is created for using driver purpose
        /// </summary>
        public void permutationOfString()
        {
            Console.WriteLine("Please enter any string");
            String str = Console.ReadLine();

            int length = str.Length;
            permute(str, 0, length - 1);
        }

        /// <summary>
        ///  permutation function 
        /// param str string to
        /// calculate permutation for 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void permute(String str,int left, int right)
        {
            if (left == right)
                Console.WriteLine(str);
            else
            {
                for (int i = left; i <= right; i++)
                {
                    str = swap(str, left, i);
                    permute(str, left + 1, right);
                    str = swap(str, left, i);
                }
            }
        }
        /// <summary>
        ///  Swap Characters at position 
        ///  return swapped string
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static String swap(String a,int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

    }
}
