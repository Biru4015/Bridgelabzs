using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Calculating number of minimun notes and notes too.");
            Console.WriteLine("Press 2 For Finding the day of week of given date by the user");
            Console.WriteLine("Press 3 For Conversion of tempreture celcius to Fahrenheit and vice versa");
            Console.WriteLine("Press 4 For Calculating monthly payment for a loan using formula");
            Console.WriteLine("Press 5 For Calculating square root of a number using Newton's method");
            Console.WriteLine("Press 6 For Converting the decimal value into binary string");
            Console.WriteLine("Press 7 For swapping nibble of binary number and the number is power of 2 or not.");
            Console.WriteLine("Press 8 For Finding all the permutation of a given string.");
            Console.WriteLine("Press 9 For Simulation of binary search.");
            Console.WriteLine("Press 10 For Simulation of Bubble sort for given integer array.");

            Console.Write("Please enter your options and enter: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                //For calculating number of notes and note in vending machice
                VendingMachine machine = new VendingMachine();
                machine.vendingMachine();
                break;

                case 2:
                //Finding the day of week of given date by the user
                DayOfWeek day = new DayOfWeek();
                day.dayOfWeek();
                break;
                
                case 3:
                //Conversion of tempreture celcius to Fahrenheit and vice versa     
                TempretureConversion tempreture = new TempretureConversion();
                tempreture.tempretureConversion();
                break;

                case 4:
                //Calculating monthly payment for a loan using formula
                MonthlyPayment payment = new MonthlyPayment();
                payment.monthlyPayment();
                break;

                case 5:
                //Calculating square root of a number using Newton's method
                SqrtNewtonMethod sqrt = new SqrtNewtonMethod();
                sqrt.sqrtNewtonMethod();
                break;

                case 6:
                //Converting decimal to binary for a given decimal number
                DecimalToBinary binary = new DecimalToBinary();
                binary.decimalToBinary();
                break;

                case 7:
                //Creating static method for binary check,  Swap nibbles and find the new number
                //Find the resultant number is the number is a power of 2.
                Binary bin = new Binary();
                bin.binary();
                bin.BinaryDriverMethod();
                break;

                case 8:
                //Finding the all permutation of given string
                PermutationOfString permutation = new PermutationOfString();
                permutation.permutationOfString();
                break;

                case 9:
                //Simulatation of binary for a string
                BinarySearch search = new BinarySearch();
                search.binarySearch();
                break;

                case 10:
                //Simulation of Bubble sort for given inetegr array
                BubbleSort sort = new BubbleSort();
                sort.bubbleSort();
                break;

                default:
                Console.WriteLine("Please enter the valid option");
                break;
            
            }
        }
    }
}
