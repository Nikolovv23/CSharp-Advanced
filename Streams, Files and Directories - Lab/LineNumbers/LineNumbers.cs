﻿// Write a program that reads a text file (e. g. input.txt) and inserts line numbers in front of each of its lines.
// The result should be written to another text file (e. g. output.txt). Use StreamReader and StreamWriter.
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int line = 1;
                    while (!reader.EndOfStream)
                    {
                        writer.WriteLine($"{line++}. {reader.ReadLine()}");
                    }
                }
            }
        }
    }
}
