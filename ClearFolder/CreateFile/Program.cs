using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateNewFile();
            Console.WriteLine("enter the file name (INCLUDE EXTENSION): ");
            string userInput = Console.ReadLine();
            //CreateUserFile(userInput);
            CreateFileWithExtension(userInput);
        }

        public static void CreateNewFile()
        {
            string rootPath = @"C:\Users\Roland Strod\Samples\playerOne";
            string fileName = "ball.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }
        public static void CreateUserFile(string fileName)
        {
            string rootPath = @"C:\Users\Roland Strod\Samples\playerTwo";
            File.Create(Path.Combine(rootPath, fileName));
        }

        public static void CreateFileWithExtension(string fileName)
        {
            string rootPath = @"C:\Users\Roland Strod\Samples\playerTwo";
            string fullfileName = $"{fileName}.txt";
            File.Create(Path.Combine(rootPath, fullfileName));
        }

    }
}
