using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Utilities
    {
        public static void OutMatrix(string[,] matrix) //this function is printing the name of the student and his average mark :)
        {
            int[] temp = new int[5];
            for (int i = 0; i < matrix.Length / 7; i++)
            {
                for(int j = 0; j<temp.Length; j++)
                {
                    temp[j] = Convert.ToInt32(matrix[i, j + 1]);
                }
                Console.WriteLine($"{matrix[i, 0], -25}{Student.CalculateAverage(temp)}");
            }
        }

        public static void OutStudents(Student[] students) //this function is printing the name of the student and his average mark, if student is learning for free :)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{Student.GetName(students[i]), -25}{students[i].averageMark}");
            }
        }

        public static void OutText(string str, int count = 30) //this function is printing some text and '=' :)
        {
            OutEquality(count);
            Console.WriteLine(str);
            OutEquality(count);
        }

        private static void OutEquality(int count = 30) //this function is printing '=' {count} times :)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write('=');
            }
            Console.Write('\n');
        }

        public static void Log(string message, Student[] list, int countEquality = 30)
        {
            OutText(message, countEquality);
            OutStudents(list);
        }
    }
}
