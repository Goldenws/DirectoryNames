using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Roland Strod\Friday";
            string[] allDirectories = Directory.GetDirectories(rootPath);
            string[] NestedDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            ReadArray(NestedDirectories);
            string[] files = Directory.GetFiles(rootPath, "*");
           
            WriteFilePaths();
            
        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array) 
            {
                Console.WriteLine(line);
            }




        }
        public static void WriteFilePaths()
        {
            string filePath = @"C:\Users\Roland Strod\Samples";
            string fridayDirectoryFile= @"C:\Users\Roland Strod\Friday\sampleDirectories.txt";

            string[] files = Directory.GetDirectories(filePath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(fridayDirectoryFile, files);
        }

    }
}
