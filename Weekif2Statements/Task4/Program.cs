using System;
using System.Reflection.Metadata;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* write a program that checks whether a given number
             * is positive or negative
             */

            Console.WriteLine("What  your number?");
            string UserInput = Console.ReadLine();
            int Number = Int32.Parse(UserInput);

            if(Number > 0)
            {
                Console.WriteLine("The Number is positive.");
            }
            else if (Number < 0)
            {
                Console.WriteLine("The number is negative.");

            }
            else
            {
                Console.WriteLine("The number is  0");

           
            
            
            }















        }
    }
}
