using System;

namespace lab2
{
    public class Student
    {
        private string _name; //the name of the student
        public double averageMark; //the average student's mark 
        private bool _donater; //checks if the student is a contractor


        public Student(string name, int[] marks, bool donater) //students constructor :)
        {
            _name = name;
            averageMark = calculateAverage(marks);
            _donater = donater;
        }

        private static double calculateAverage(int[] data) //this function was created to calculate the average value of marks :)
        {
            double result = 0;
            int sum = 0;
            foreach (int mark in data)
            {
                sum += mark;
            }
            result = Convert.ToDouble(sum) / data.Length;

            return result;
        }

        public static void sortStudents(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                if (students[i].averageMark < students[i + 1].averageMark)
                {
                    swapStudents(students[i], students[i + 1]);
                }
            }
        }

        private static void swapStudents(Student student1, Student student2)
        {
            Student student;
            student = student1;
            student1 = student2;
            student2 = student;
        }

        private static string[,] toMatrix(Student[] students)
        {
            string[,] matrix = new string[students.Length, 2];
            for (int i = 0; i < students.Length; i++)
            {
                matrix[i, 0] = students[i]._name;
                matrix[i, 1] = students[i].averageMark.ToString();
            }
            return matrix;
        }

        private static void outMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.Length/2; i++)
            {
                Console.WriteLine($"{matrix[i, 0]}'s average mark is {matrix[i, 1]}");
            }
        }
    }
}
