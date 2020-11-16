using System;

namespace TestUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your IDCode: ");
            string usersID = Console.ReadLine();
            if (Validate(usersID))
            {

                HelloUser(usersID);
                int age = GetAge(usersID);
                Console.WriteLine($"age {age}");
                if (age >= 18)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("not okay");
                }


            }
            else
            {
                Console.WriteLine("Sorry.Wrong Format! ");
            }
        }

        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            // || - alt gr + <>
            if (firstNum == 1 || firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("Hello, Sir!");

            }
            else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }
        }
        public static int GetAge(string idCode)
        {
            int yearOfBirth = GetYear(idCode);

            DateTime now = DateTime.Now;
            int yearNow = Int32.Parse(now.Year.ToString());
            int age = yearNow - yearOfBirth;
            Console.WriteLine($"you are{age} years old.");
            return age;


        }

    }
    
}  
