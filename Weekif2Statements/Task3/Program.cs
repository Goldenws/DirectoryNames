using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

            Console.WriteLine("What is the first numebr?");

            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);
            Console.WriteLine("What is your second number?");
            UserInput = Console.ReadLine();
            int Num2 = Int32.Parse(UserInput);

            if (Num1 == Num2)
            {
                Console.WriteLine("the numbers you proided are equal");
            } else
            {

                Console.WriteLine("The numbers you provided are NOT equal");




            }

        }
    }
}
