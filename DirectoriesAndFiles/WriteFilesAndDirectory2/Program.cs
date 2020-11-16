using System;
using System.IO;

namespace WriteFilesAndDirectory2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePaths();
        }

        public static void WriteFilePaths()
        {
            string filePath = @"C:\Users\Roland Strod\Samples\files.txt";
            string directoryPath = @"C:\Users\Roland Strod\Samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(filePath, files);
        }
    }
}
