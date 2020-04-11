namespace DataStructures
{
    using DataStructure;
    using System;
    using DataStructures;

    /// <summary>
    /// This class contains code for main method 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is main method for controlling this project
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For create unordered List");
            Console.WriteLine("Press 2 For create order list of number in list");
            Console.WriteLine("Press 3 For checking balanced paranthesis");
            Console.WriteLine("Press 4 For cashcounter implementattion usinig queue");
            Console.WriteLine("Press 5 For checking the given string is palindrome or not.");
            Console.WriteLine("Press 6 For Checking prime number in range and store in 2d array");
            Console.WriteLine("Press 7 For Checking prime and anagram in given range and storing the values in 2d.");
            Console.WriteLine("Press 8 For calander printing of given month and year.");
            Console.WriteLine("Press 9 For Add the number is prime and anagram too.");
            Console.WriteLine("Press 10 For Add the number in queue which in prime and anagram too.");
            Console.WriteLine("Press 11 For simulation of hashing algorithm");

            Console.Write("Enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    //For create unordered List in file
                    UnoderList list = new UnoderList();
                    list.driverMethod();
                    break;

                case 2:
                    //For create order list of number in list
                    OrderedListDriver ordered = new OrderedListDriver();
                    ordered.driverMethod();
                    break;

                case 3:
                    //For checking balanced paranthesis
                    BalancedParentheses balanced = new BalancedParentheses();
                    balanced.DriverBalanced();
                    break;

                case 4:
                    //Implementation of cashcounter using queue
                    CashCounter cash = new CashCounter();
                    cash.Count();
                    break;

                case 5:
                    //For checking string is palindrome or not.
                    Palindrome palindrome = new Palindrome();
                    palindrome.isPalindrome();
                    break;

                case 6:
                    //Checking prime number in range and store in 2d array
                    PrimeNumber prime = new PrimeNumber();
                    prime.DriverPrime2D();
                    break;

                case 7:
                    //Checking prime and anagram in given range and storing the values in 2d.
                    PrimeAnagram anagram = new PrimeAnagram();
                    anagram.primeAnagram();
                    break;

                case 8:
                    //For printing calendar of given month and year.
                    Calendar calendar = new Calendar();
                    calendar.calanderDriver();
                    break;

                case 9:
                    //Add the number is prime and anagram too.
                    AnagramStack anagram1 = new AnagramStack();
                    anagram1.DriverMethod();
                    break;

                case 10:
                    //Add the number in queue which in prime and anagram too.
                    AnagramQueue queue = new AnagramQueue();
                    queue.DriverMthod();
                    break;

                case 11:
                    //Simulation of hashing algorithm
                    Hashing hashing = new Hashing();
                    hashing.HashingDriver();
                    break;

                default:
                    //This is for default options
                    Console.WriteLine("Please select the correct options.");
                    break;
            
            }

        }
    }
}