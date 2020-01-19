using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjectRed
{
    class Files
    {
        public void WriteNumbersToFile(string filePath)
        {
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                string numbers = "";
                for (int i = 1; i <= 500; i++)
                {
                    numbers = numbers + i + ",";
                }
                File.WriteAllText(filePath, numbers);
            }
        }

        public void WriteArrayToFile(string[] array, string filePath)
        {
            FileStream file1 = new FileStream(filePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i]);
            }
            writer.Close();
            file1.Close();
        }

        public int GetMaxLengthLine(string filePath)
        {
            FileStream file = new FileStream(filePath, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            int maxLength = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            reader.Close();
            file.Close();
            return maxLength;
        }
    }
}
