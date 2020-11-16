using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            /*
             1. Program asks for user's first and lastname
            2. Program asks for user's year of birth
            3. Program greets the user by their name displays their age

           
            NB! To Display the result use one WriteLine line only
             */
            Console.WriteLine("What is your first name?");
             string FirstName;
              string LastName;
              string UserInput;
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What is your year of birth?");
            UserInput = Console.ReadLine();
            int YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine($"Your name is {FirstName} {LastName} {Age}");
















        }
    }
}
