using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using DataStructure;
namespace DataStructures
{
    /// <summary>
    /// This class checks a equation has balanced parentheses or not
    /// </summary>
    public class BalancedParentheses
    {
        /// <summary>
        /// Drivers method to take data.
        /// </summary>
        public void DriverBalanced()
        {
            Console.WriteLine("Enter Arithmetic Equation: ");
            string aeq = Console.ReadLine();
            Console.WriteLine(CheckParentheses(aeq));
        }

        /// <summary>
        /// Checking  the parentheses balanced or not.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>bool value</returns>
        public static bool CheckParentheses(string str)
        {
            DataStructures.Stack<char> stack = new DataStructures.Stack<char>(20);
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.IsEmpty())
                    {
                        return true;
                    }

                    if (ch == ')' && stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }
            return stack.IsEmpty();
    
        }
    }
}