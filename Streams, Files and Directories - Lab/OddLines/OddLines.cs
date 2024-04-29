// Write a program that reads a text file (e. g. input.txt) and writes every odd line in another file. Line numbers start from 0. 
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream)
                    {
                        lineNumber++;
                        string line = reader.ReadLine();
                        if (lineNumber % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}
