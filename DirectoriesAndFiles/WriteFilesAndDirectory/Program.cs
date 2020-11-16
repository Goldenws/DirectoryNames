using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace WriteFilesAndDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Roland Strod\Samples\files.txt";
            string directoryPath = @"C:\Users\Roland Strod\Samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", System.IO.SearchOption.AllDirectories);
            //save to file
            File.WriteAllLines(filePath, files);

        }
    }
}
