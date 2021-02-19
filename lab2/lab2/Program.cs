using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvFile = new CsvManager("/students1.csv");
            string[,] stas = csvFile.ToMatrix();
            Student[] students = Student.fromMatrix(stas);
        }
    }
}