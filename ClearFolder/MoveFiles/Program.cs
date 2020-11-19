using System;
using System.IO;
namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveFile();
            Console.WriteLine("Job Done!");
        }

        public static void MoveFile()
        {
            string sourceDirectory = @"C:\Users\Roland Strod\Samples\playerOne";
            string destinationPath = @"C:\Users\Roland Strod\Samples\playerTwo";
            string fileName = "ball.txt";

            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }
    }
}
