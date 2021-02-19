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
            tableSizes();
        }

        private void tableSizes()
        {
            using (var sr = new StreamReader(_path))
            {
                Length = int.Parse(sr.ReadLine());
                Width = sr.ReadLine().Split().Length;
            }
        }

        public string[,] ToMatrix()
        {
            try
            {
                using (var sr = new StreamReader(_path))
                {
                    string[,] output = new string[Length, Width];
                    for  (int i = 0; i < Length; i++)
                    {
                        string[] currentLine = sr.ReadLine().Split();
                        for (int j = 0; j < currentLine.Length; j++)
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