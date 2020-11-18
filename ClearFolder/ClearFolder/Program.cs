using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootPath = @"C:\Users\Roland Strod\Samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            DeleteAllFiles();

            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllFolders(dir.FullName, true);
            }

            
        }


        //a function to delete all the files

        public static void DeleteAllFiles()
        {
            string rootPath = @"C:\Users\Roland Strod\Samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }


        }
        //a function to delete all the folders
        public static void DeleteAllFolders(string directoryname, bool ifExists)
        {
            if (Directory.Exists(directoryname))
            {
                Directory.Delete(directoryname, true);
            }else if (ifExists)
            {
                throw new SystemException("No such directory to delete");
            }
        }
        

        
    }
}
