using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class contains the code for convrting the tempreture 
    /// </summary>
    class TempretureConversion
    {
        /// <summary>
        /// Purepose of creating this method is conversion of tempreture in fahrenhiet to celcius and vice versa
        /// </summary>
        public void tempretureConversion()
        {
            Console.WriteLine("Welcome to tempreture conversion please.");
            Console.WriteLine("Press 1 to to Perform Celsius to Fahrenheit Conversion.");
            Console.WriteLine("Press 2 to to Perform Fahrenheit to Celsius Conversion.");

            Console.Write("Please enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    int celsius, faren;
                    Console.Write("Enter the Temperature in Celsius(°C) : ");
                    celsius = int.Parse(Console.ReadLine());
                    faren = (celsius * 9) / 5 + 32;
                    Console.WriteLine("0Temperature in Fahrenheit is(°F) : " + faren);
                    break;


                case 2:
                    double celsius1, fahrenheit;
                    Console.Write("Enter the Temperature in Fahrenheit(°F) : ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius1 = (fahrenheit - 32)*5/9;
                    Console.WriteLine("Temperature in celcius is(°C) : " + celsius1);
                    break;

                default:
                    Console.WriteLine("Please enter the options either 1 or 2");
                    break;
            }
        }
    }
}
