using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Write a program that asks user's year of birth
             *and decides if the user is old enough to get permanent
             *driving license



             */

            Console.WriteLine("What is your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            if (Age > 18) 
            {
                Console.WriteLine($"you are old enough to get pernament driving license");
            }
            else if (Age < 18)
            {

                Console.WriteLine($"śorry, but you are not old enough to get pernament driving license");

            }
            else
            {
                Console.WriteLine("you are old enough to get pernament driving license");
            }
        }
    }
}
