using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for number of rows
            Console.WriteLine("Enter the number of rows in the matrices: ");
            int row = Convert.ToInt32(Console.ReadLine());

            //ask for number of columns    
            Console.WriteLine("Enter the number of columns in the matrices: ");
            int column = Convert.ToInt32(Console.ReadLine());

            // creating the 10 by 10 matrix
            int[,] myArray = new int[20, 20];

            Console.Write("Enter the first matrix: ");

            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < column; j++)
                {
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }
            int[,] myArray2 = new int[20, 20];     // array for second matrix
            Console.Write("Enter the second matrix:");

            // populate the array with user input
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    myArray2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            // clear the console
            Console.Clear();

            Console.WriteLine("The first matrix: ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Second Matrix: ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(myArray2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] result = new int[20, 20];
            bool value = true;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                }
            }



        }
    }
}
