/*
Dado el array
4 7 -5 4 9
0 3 -2 6 -2
1 2 4 1 1
6 1 0 3 -4
8 9 -2 4 -4
escriba un programa en C# que encuentre la suma de todos los elementos que no pertenecen a la diagonal
principal.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumExcludingMainDiagonal
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declaration and initialization of array
            int[,] array = new int[,] {
                { 4, 7, -5, 4, 9 },
                { 0, 3, -2, 6, -2 },
                { 1, 2, 4, 1, 1 },
                { 6, 1, 0, 3, -4 },
                { 8, 9, -2, 4, -4 } };

            //Declare variable to represent the total of the sum
            int total = 0;

            //print matrix
            //GetLength is used to get the value of i and j
            //GetLength(0) = i
            //GetLength(1) = j
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //If the numbers are not part of the main diagonal, they are added
                    if (i != j)
                    {
                        total += array[i, j];
                    }
                }
            }
            //print the sum result
            Console.WriteLine("The sum of the elements that do not belong to the main diagonal is: " + total);

        }
    }
}