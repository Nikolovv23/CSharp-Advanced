// You are given an input binary file (e. g. example.png). Write a program to split it into two equal-sized files (e. g. part-1.bin and part-2.bin).
// When the input file size is an odd number, the first part should be 1 byte bigger than the second.
// After splitting the input file, join the obtained files into a new file(e.g.example - joined.png).
// The obtained result file should be the same as the initial input file.
using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (var source = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (var firstPart = new FileStream(partOneFilePath, FileMode.Create))
                {
                    int odd = source.Length % 2 == 1 ? 1 : 0;

                    byte[] buffer = new byte[source.Length / 2 + odd];
                    source.Read(buffer);
                    firstPart.Write(buffer);
                }

                using (var secondPart = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length / 2];
                    source.Read(buffer);
                    secondPart.Write(buffer);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var joined = new FileStream(joinedFilePath, FileMode.Create))
            {
                using (var firstPart = new FileStream(partOneFilePath, FileMode.Open))
                {

                    byte[] buffer = new byte[firstPart.Length];
                    firstPart.Read(buffer);
                    joined.Write(buffer);
                }

                using (var secondPart = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[secondPart.Length];
                    secondPart.Read(buffer);
                    joined.Write(buffer);
                }
            }
        }
    }
}