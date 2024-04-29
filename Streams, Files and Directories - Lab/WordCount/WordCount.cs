// Write a program that reads a list of words from a given file (e. g. words.txt) and finds how many times each of the words occurs in another file (e. g. text.txt).
// Matching should be case-insensitive. The result should be written to an output text file (e. g. output.txt). Sort the words by frequency in descending order.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader readWords = new StreamReader(wordsFilePath))
            {
                using (StreamReader readText = new StreamReader(textFilePath))
                {
                    string[] words = readWords.ReadToEnd().Split(" ").ToArray();
                    Dictionary<string, int> wordList = new Dictionary<string, int>();
                    foreach (string word in words)
                    {
                        wordList.Add(word, 0);
                    }
                    while (!readText.EndOfStream)
                    {
                        string[] currentText = readText.ReadLine()
                        .ToLower()
                        .Replace("-", " ")
                        .Replace(".", " ")
                        .Replace("...", " ")
                        .Replace(",", " ")
                        .Replace("!", " ")
                        .Replace("?", " ")
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                        foreach (string currentWord in currentText)
                        {
                            if (wordList.ContainsKey(currentWord))
                            {
                                wordList[currentWord]++;
                            }
                        }
                    }

                    using (StreamWriter writeWords = new StreamWriter(outputFilePath))
                    {
                        var orderedList = wordList.OrderByDescending(word => word.Value);
                        foreach (var word in orderedList)
                        {
                            writeWords.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}
