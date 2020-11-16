﻿using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CreditCard
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
                if (age >= 18) {
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




        public static bool Validate(string IDCode)
        {
            if (IDCode.Length == 11)
            {
                try
                {
                    long.Parse(IDCode);
                    return true;

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong fromat: {e}");
                    return false;

                }

            }
            else
            {
                return false;
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

        public static int GetYear(string idCode)
        {

            string yearFromCode = idCode.Substring(1, 2);
            string year;
            if (int.Parse(idCode[0].ToString()) > 4)
            {
                year = "20" + yearFromCode;
            }
            else
            {
                year = "19" + yearFromCode;

            }

            Console.WriteLine($"you were born in {year}");
            int yearPassed = Int32.Parse(year);

            return yearPassed;

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
        public static bool CreditCard()
        {
            //MasterCard CreditCard Number: 53 87 46 21 34 57 98 34

            Console.WriteLine("Please Enter Your Credit Card Number: ");
            string CreditCardNumber = Console.ReadLine();

            if (Validate(CreditCardNumber))
            {
                if (CreditCardNumber.Length == 16)
                {
                    try
                    {
                        long.Parse(CreditCardNumber);
                        Console.WriteLine("Successfuly Parsed");
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Wrong Format, {e} ");
                        return false;
                    }
                }
                else
                    return false;

            }
            else
            {
                return false;
            }
            
           /* Console.WriteLine("Enter your CVV code: ");
            string UserCVV = Console.ReadLine();
            if (ValidateCVV(UserCVV))
            {
                Console.WriteLine("Welcome !");
            }

            else
            {
                Console.WriteLine("Wrong Format!");
            }*/
        }

        public static bool ValidateCVV(string UserCVV)
        {
            if (UserCVV.Length == 3)
            {
                try
                {
                    long.Parse(UserCVV);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }


        }


    }

}

    

