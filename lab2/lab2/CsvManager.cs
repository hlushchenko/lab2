using System;
using System.IO;

namespace lab2
{
    public class CsvManager
    {
        private string _path;
        public int Length = 0;
        public int Width = 0;

        public CsvManager(string path)
        {
            _path = path;
            FileInfo fi = new FileInfo(_path);
            if (!fi.Exists)
            {
                fi.CreateText();
            }
        }

        private void TableSizes()
        {
            using (var sr = new StreamReader(_path))
            {
                Length = int.Parse(sr.ReadLine());
                Width = sr.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }

        public string[,] ToMatrix()
        {
            try
            {
                TableSizes();
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
            catch (Exception e)
            {
                Console.WriteLine($"Incorrect file: \n {e}");
            }

            return null;
        }

        public static string[] FindCsv(string path)
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

            return csvs.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        public void FromMatrix(string[,] matrix)
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