using System;

namespace Weekif2Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;

            Console.WriteLine("How old are you?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);

            if (Age < 18)
            {
                Console.WriteLine($"you are {Age},you are too young");

            }
            else if (Age > 18)
            {
                Console.WriteLine($"you are {Age},you are old enough.");
            }


        
        
        }
    }
}
