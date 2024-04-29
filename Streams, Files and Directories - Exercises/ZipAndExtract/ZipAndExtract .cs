// Write a program that creates a ZIP file (archive), holding a given input file, and extracts the ZIP-ed file from the archive into in separate output file.
// •	Use the copyMe.png file from your resources as input and zip it into a ZIP file of your choice, e. g. archive.zip.
// •	Extract the file from the archive into a new file of your choice, e. g. extracted.png.
// If your code works correctly, the input and output files should be the same.

using System.IO.Compression;
using System.IO;

namespace ZipAndExtract
{
    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);
            var fileName = Path.GetFileName(inputFilePath);
            archive.CreateEntryFromFile(inputFilePath, fileName);
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using var archive = ZipFile.OpenRead(zipArchiveFilePath);
            var extraction = archive.GetEntry(fileName);
            extraction.ExtractToFile(outputFilePath);
        }
    }
}