using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.OutText("Input the directory with .csv files:", 30);
            CsvManager[] files = CsvManager.FindCsv(Console.ReadLine());

            Utilities.OutText("The list of those students who are learning for free:", 30);
            Student[] students = Student.FromMatrix(CsvManager.ToMatrix(files));
            Utilities.OutStudents(students);

            Utilities.OutText("Those who get a scholarship:", 30);
            Student[] scholarship = Student.Scholarship(students);
            Utilities.OutStudents(scholarship);

            CsvManager output = new CsvManager("/output/output.csv", true);
            output.FromMatrix(Student.ToMatrix(scholarship));
        }
    }
}