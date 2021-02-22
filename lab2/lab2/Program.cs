using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the directory with .csv files:");
            CsvManager[] files = CsvManager.FindCsv(Console.ReadLine());

            Console.WriteLine("Input the percentage:");
            int percent = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input the minimal rating:");
            double minimalRating = double.Parse(Console.ReadLine());

            Student[] students = Student.FromMatrix(CsvManager.ToMatrix(files));
            Utilities.Log("The list of those students who are learning for free:", students);

            Student[] scholarship = Student.Scholarship(students, percent, minimalRating);
            Utilities.Log("Those who get a scholarship:", scholarship);

            Utilities.OutText("The minimal mark for scholarship:");
            Console.WriteLine(Student.FindMinMark(scholarship));

            CsvManager output = new CsvManager("/output/rating.csv", true);
            output.FromMatrix(Student.ToMatrix(scholarship));
        }
    }
}