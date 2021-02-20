using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvFile = new CsvManager("/students1.csv");

            Utilities.outText("The list of all students:", 30);
            string[,] allStudents = csvFile.ToMatrix();
            Utilities.outMatrix(allStudents);

            Utilities.outText("The list of students, who are learning for free:", 30);
            Student[] students = Student.fromMatrix(allStudents);
            Utilities.outStudents(students);

            Utilities.outText("The list of students, who are getting paid:", 30);
            Student[] studentsWhoGetPaid = Student.findThoseWhoGetPaid(students);
            Utilities.outStudents(studentsWhoGetPaid);

            Console.ReadKey();
        }
    }
}