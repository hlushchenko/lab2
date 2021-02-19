using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Utilities
    {
        public static void outMatrix(string[,] matrix) //this function is printing the name of the student and his average mark :)
        {
            for (int i = 0; i < matrix.Length / 2; i++)
            {
                Console.WriteLine($"{matrix[i, 0]}'s average mark is {matrix[i, 1]}");
            }
        }
    }
}
