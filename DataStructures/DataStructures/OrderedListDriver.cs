using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// This class contains the code for driver method
    /// </summary>
    public class OrderedListDriver
    {
        /// <summary>
        /// This method is created for driver purpose
        /// </summary>
        public void driverMethod()
        {
            Console.Write("Enter your File Path : ");
            String filest = Path.GetFullPath(Console.ReadLine());
            String[] strarr= File.ReadAllText(filest).Split(" ");
            Array.Sort(strarr);
            OrderedList<String> list = new OrderedList<String>();
            for(int i=0;i<strarr.Length;i++)
            {
                list.Add(strarr[i]);
            }

            string origfile = File.ReadAllText(filest);
            Console.WriteLine("Your original file");
            Console.WriteLine(origfile);

            Console.WriteLine("Enter number to be searched");
            string number = Console.ReadLine();
            if (list.Search(number))
            {
                Console.WriteLine(number + " found so it will be removed from list");
                list.Remove(number);
            }
            else
            {
                Console.WriteLine(number + " not found so it will be added to list");
                list.Add(number);
            }

            Console.WriteLine("After processing final list is as below and your file is modified ");
            Console.WriteLine(list.DisplayInString());
            string filecontent = list.DisplayInString();
            File.WriteAllText(filest, filecontent);
        }
    }
}
