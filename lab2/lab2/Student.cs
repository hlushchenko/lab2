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

        
    }
}
