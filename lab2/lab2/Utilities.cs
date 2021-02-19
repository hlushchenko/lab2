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
            int[] temp = new int[5];
            for (int i = 0; i < matrix.Length / 7; i++)
            {
                for(int j = 0; j<temp.Length; j++)
                {
                    temp[j] = Convert.ToInt32(matrix[i, j + 1]);
                }
                Console.WriteLine($"{matrix[i, 0]}'s average mark is {Student.calculateAverage(temp)}");
            }
        }

        public static void outStudents(Student[] students) //this function is printing the name of the student and his average mark, if student is learning for free :)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{Student.getName(students[i])}'s average mark is {students[i].averageMark}");
            }
        }

        public static void outText(string str, int count)
        {
            outEquality(count);
            Console.WriteLine(str);
            outEquality(count);
        }

        private static void outEquality(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write('=');
            }
            Console.Write('\n');
        }
    }
}
