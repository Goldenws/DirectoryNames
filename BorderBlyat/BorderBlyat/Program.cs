using System;

namespace BorderBlyat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the  border please provide indefication!");
            Console.WriteLine("Your name comrade : ");
            string name = Console.ReadLine();
            Console.WriteLine("Our Secret password comrade :");
            string password = Console.ReadLine();

            if ((name == "Tovarish"&&password == "StalinForever"))
            {
                Console.WriteLine("Welcome to our country, Tovarish");

            }
            else if((name != "Tovarish"&&password == "StalinForever"))
            {
                Console.WriteLine("Oh so youre the outborder diplomat huh ?, Ok pass but remember Stalin is watching!");
            }
            else if((name == "Tovarish"&&password != "StalinForever"))
            {
                Console.WriteLine("Who are you, go to gulag western spy!");
            }
            else
            {
                Console.WriteLine("Your not passing trough capitalist pig!");
            }






        }
    }
}
