// Write a program that reads a text file (e. g. text.txt) and prints on the console its even lines. Line numbers start from 0. Use StreamReader.
// Before you print the result, replace {'-', ', ', '. ', '! ', '? '} with '@' and reverse the order of the words.

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            char[] charArray = { '-', ',', '.', '!', '?' };
            int lineCounter = 0;
            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (lineCounter % 2 == 0)
                    {
                        foreach (char c in line)
                        {
                            if (charArray.Contains(c))
                            {
                                line = line.Replace(c, '@');
                            }
                        }
                        string[] temp = line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Reverse()
                             .ToArray();
                        sb.AppendLine(string.Join(" ", temp));
                    }
                    lineCounter++;
                }
            }
            return sb.ToString();
        }
    }
}
