using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.IO;

namespace lab2
{
    public class CsvManager
    {
        private string _path;
        public int Length;
        public int Width;
        public CsvManager(string path)
        {
            _path = path;
            var sr = new StreamReader(_path); 
            TableSizes();
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
                using (var sr = new StreamReader(_path))
                {
                    string[,] output = new string[Length, Width];
                    sr.ReadLine();
                    for  (int i = 0; i < Length; i++)
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
            catch(Exception e)
            {
                Console.WriteLine($"Incorrect file: \n {e}");
            }

            return null;
        }
    }
}