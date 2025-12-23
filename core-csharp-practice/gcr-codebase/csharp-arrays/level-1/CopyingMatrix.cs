using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// Copying a matriz or 2 - D array in a 1 - D array
  internal class CopyingMatrix
    {
        static void Main()
        {
            Console.WriteLine("Give the rows and columns of the matrix : ");			// Input rows and columns from the user
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];						// Initialize a matrix
            Console.WriteLine("Give the elements of the matrix : ");
            for (int rowsloop = 0; rowsloop < rows; rowsloop++)					// Initiate a loop to input elements in the matrix
            {
                for (int columnsloop = 0; columnsloop < columns; columnsloop++)
                {
                    matrix[rowsloop, columnsloop] = int.Parse(Console.ReadLine());
                }
            }
            int[] replicate = new int[rows * columns];						// Intialize an array
            int position = 0;
            for(int rowsloop = 0; rowsloop < rows; rowsloop++)					// Initiate a loop to duplicate the matrix in the array
            {
                for (int columnsloop = 0; columnsloop < columns; columnsloop++)
                {
                    replicate[position] = matrix[rowsloop, columnsloop];
                    position++;
                }
            }
            Console.WriteLine("Replicated Matrix : ");						
            for(int loop = 0 ; loop < replicate.Length; loop++)					// Initiate a loop to display the result
            {
                Console.WriteLine(replicate[loop]);
            }
        }
    }

