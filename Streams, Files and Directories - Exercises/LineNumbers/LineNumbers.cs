// Write a program that reads a text file (e. g. text.txt) and inserts line numbers in front of each of its lines and count all the letters and punctuation marks.
// The result should be written to another text file (e. g. output.txt). Use the static class File to read and write all the lines of the input and output files.
using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            StringBuilder sb = new StringBuilder();

            int lettersCounter = 0;
            int punctuationMarksCounter = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                lettersCounter = lines[i]
                    .Where(char.IsLetter)
                    .Count();
                punctuationMarksCounter = lines[i]
                    .Where(char.IsPunctuation)
                    .Count();
                sb.AppendLine($"Line {i + 1}: {lines[i]} ({lettersCounter}) ({punctuationMarksCounter})");
            }
            File.WriteAllText(outputFilePath, sb.ToString() );
        }
    }
}
