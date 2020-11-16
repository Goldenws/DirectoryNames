using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what day of the week is it");
            string day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "sunday":
                    Console.WriteLine("1");
                    break;
                case "monday":
                    Console.WriteLine("2");
                    break;
                case "tuesday":
                    Console.WriteLine("3");
                    break;
                case "wednesday":
                    Console.WriteLine("4");
                    break;
                case "thursday":
                    
                    Console.WriteLine("5");
                    break;
                case "Friday":
                    
                    Console.WriteLine("6");
                    break;
                 default:
                    Console.WriteLine("Something went wrong");
                    break;

            }   

        }
    }
}
