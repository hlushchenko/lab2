using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvManager Testfile = new CsvManager("https://www.youtube.com/watch?v=_z0m7TozqUo");
            Testfile.ToMatrix();
        }
    }
}