using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        public void insertionSort()
        {
            Console.WriteLine("Please Enter the list of word file ");
            String str = Console.ReadLine();
            String[] arr = str.Split(" ");

            String sortedArray[] = sort_sub(arr[], arr.Length);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
        }

            private static String[] sort_sub(String array[], int f)
            {
                String temp = "";
                for (int i = 0; i < f; i++)
                {
                    for (int j = i + 1; j < f; j++)
                    {
                        if (array[i].CompareTo(array[j]) > 0)
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
      
    }
}
