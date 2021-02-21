using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input plz");
            CsvManager[] files = CsvManager.FindCsv("/");
            Student[] students = Student.fromMatrix(CsvManager.ToMatrix(files));
        }
    }
}