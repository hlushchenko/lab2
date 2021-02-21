using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input plz");
            CsvManager[] files = CsvManager.FindCsv(Console.ReadLine());
            Student[] students = Student.fromMatrix(CsvManager.ToMatrix(files));
            Student[] scholarship = Student.findThoseWhoGetPaid(students);
            CsvManager output = new CsvManager("/output/output.csv", true);
            output.FromMatrix(Student.toMatrix(scholarship));
        }
    }
}