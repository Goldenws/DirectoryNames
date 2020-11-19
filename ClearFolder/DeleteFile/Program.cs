﻿using System;
using System.IO;
namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDelete();
        }

        public static void FileDelete()
        {
            string rootPath = @"C:\Users\Roland Strod\Samples\playerTwo";
            string fileName = "ball.txt";

            if(File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }

    }
}
