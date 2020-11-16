using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //to get the files names only 
            string rootPath = @"C:\Users\Roland Strod\Samples";
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach(string file in files)
            {
                Console.WriteLine(file);
                //get file objects
                var fileData = new FileInfo(file);
                Console.WriteLine(fileData);
                string fileName = fileData.Name;
                string filedirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name: {fileName}; location: {filedirectory}; Size: {fileSize}");
                string line = $"File name: {fileName}; location: {filedirectory}; Size: {fileSize} bytes";
                lines.Add(line);
            }
            string fileDataPath = @"C:\Users\Roland Strod\FileData.txt";
            File.WriteAllLines(fileDataPath, lines);
        }
    }
}
