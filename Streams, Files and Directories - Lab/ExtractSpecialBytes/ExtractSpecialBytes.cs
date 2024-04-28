// You are given a binary file (e. g. example.png) and a text file (e. g. bytes.txt), holding a list of bytes in the range [0…255].
// Write a program to extract occurrences of all given bytes from the input file to an output binary file (e. g. output.bin).
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using StreamReader streamReader = new StreamReader(bytesFilePath);
            byte[] fileBytes = File.ReadAllBytes(binaryFilePath);
            var bytesList = new List<String>();
            var sb = new StringBuilder();

            while (!streamReader.EndOfStream)
            {
                bytesList.Add(streamReader.ReadLine());
            }
            foreach (var item in fileBytes)
            {
                if (bytesList.Contains(item.ToString()))
                {
                    sb.AppendLine(item.ToString());
                }

            }
            using StreamWriter file = new System.IO.StreamWriter(outputPath);
            file.WriteLine(sb.ToString().Trim());
        }
    }
}
