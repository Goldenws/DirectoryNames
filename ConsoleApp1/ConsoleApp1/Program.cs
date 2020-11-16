using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Seasons
             * A program asks the user what month they were born
             * December, January or February - You were born in winter
             * March, April or May - you were born in spring
             * June, July or August - you were born in summer
             * September, October or November - you were born in autumn
             
              */
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine().ToLower();
            // || - pipes alt gr + <
            if(month == "december" || month == "january" || month == "february")
            {
                Console.WriteLine("You were born in winter.");
            }else if (month == "march" || month == "april" ||month == "may")
            {
                Console.WriteLine("You were born in spring.");
            }else if (month == "june" || month == "july" || month == "august")
            {
                Console.WriteLine("You were born in summer.");
            }else if(month == "september" || month == "october" || month == "november")
            {
                Console.WriteLine("You were born in autumn");
            }
            else
            {
                Console.WriteLine("Tovarish are you retarded?");

            }
        }
    }
}
