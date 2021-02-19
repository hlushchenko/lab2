using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            var csvFile = new CsvManager("/students1.csv");
            string[,] stas = csvFile.ToMatrix();
            Student[] students = Student.fromMatrix(stas);
        }
    }
}