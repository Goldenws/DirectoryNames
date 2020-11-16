using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Roland Strod\Samples";

            //get the full path of all the directories at the rootPath
            string[] allDirectories = Directory.GetDirectories(rootPath);
            ReadArray(allDirectories);

            //get nested directories
            string[] includeNestedDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            ReadArray(includeNestedDirectories);

            //get directory files
            string[] files = Directory.GetFiles(rootPath, "*.*");



        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }

    }
}
