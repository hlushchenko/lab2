using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvManager Testfile = new CsvManager("/students1.csv");
            string[,] test = Testfile.ToMatrix();
        }
    }
}