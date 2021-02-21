using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;

namespace lab2
{
    public class CsvManager
    {
        private string _path;
        public bool Writable;
        public int Length = 0;
        public int Width = 0;

        public CsvManager(string path, bool  writable = false)
        {
            _path = path;
            Writable = writable;
            if (!Writable)
            {
                TableSizes();
            }
            else
            {
                if (File.Exists(path))
                {
                    using (var file = File.Create(path)) {}
                }
            }
        }

        public void TableSizes()    //calculates sizes of the table in csv table
        {
            using (var sr = new StreamReader(_path))
            {
                Length = int.Parse(sr.ReadLine());
                Width = sr.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }

        public string[,] ToMatrix() //reads data from file to matrix
        {
            using (var sr = new StreamReader(_path))
                {
                    string[,] output = new string[Length, Width];
                    sr.ReadLine();
                    for (int i = 0; i < Length; i++)
                    {
                        string[] currentLine = sr.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < Width; j++)
                        {
                            output[i, j] = currentLine[j];
                        }
                    }

                    return output;
                }
        }

        public static string[,] ToMatrix(CsvManager[] files)    //puts all data from input files in one matrix
        {
            string[,] output = new string[files.Sum(a => a.Length), files[0].Width];
            int j = 0;
            foreach (var file in files)
            {
                string[,] current = file.ToMatrix();
                for (int k = 0; k < file.Length; k++)
                {
                    for (int i = 0; i < file.Width; i++)
                    {
                        output[j, i] = current[k, i];
                    }

                    j++;
                }
            }

            return output;
        }

        public static CsvManager[] FindCsv(string path)     //find all csv files in certain directory
        {
            string[] allfiles = Directory.GetFiles(path);
            string csvs = "";
            foreach (var file in allfiles)
            {
                if (file.Contains(".csv"))
                {
                    csvs = $"{csvs} {file}";
                }
            }

            string[] csvsArray = csvs.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CsvManager[] filesArray = new CsvManager[csvsArray.Length];
            for (int i = 0; i < csvsArray.Length; i++)
            {
                filesArray[i] = new CsvManager(csvsArray[i]);
            }

            return filesArray;
        }

        public void FromMatrix(string[,] matrix)    //writes data from matrix to file
        {
            using (StreamWriter sw = new StreamWriter(_path))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    string currentLine = "";
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        currentLine += matrix[i, j].Replace(',', '.') + " ";
                    }

                    sw.WriteLine(currentLine);
                }
            }
        }
    }
}