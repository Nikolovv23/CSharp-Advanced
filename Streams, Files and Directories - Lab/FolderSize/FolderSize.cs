// You are given a folder in the file system (e. g. TestFolder). Calculate the size of all files in the folder and its subfolders.
// The result should be written to another text (e. g. оutput.txt) file in kilobytes.
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] infos = dir.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (FileInfo fileInfo in infos)
            {
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText(outputFilePath, sum.ToString());
        }
    }
}
