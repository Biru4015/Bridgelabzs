using System;
using System.Collections.Generic;
using System.Text;

namespace Functionals
{
    /// <summary>
    /// This class contains the code about two dimension array
    /// </summary>
    class TwoDArray
    {
        /// <summary>
        /// This method is created for displaying two dimension array
        /// Enter the row and columns size and elements in each case
        /// </summary>
        public void twoDArray()
        {
            Console.Write("Please enter the number of row: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            //Enter the element in two dimension array
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < columns; col++)
                {

                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());

                }

            }

            // Printing the two dimension array            
            Console.WriteLine("The two dimension matrix is as follows:");

            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < columns; col++)
                {

                    Console.Write(matrix[row, col] + " ");

                }

                Console.WriteLine();

            }

        }
    }
}
