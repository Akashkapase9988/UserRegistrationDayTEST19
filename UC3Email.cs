using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationDay19
{
    class UC3Email
    {
        public static void validationEmail()
        {
            Console.Write("Please enter your Email:");
            string Email = Console.ReadLine();

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //string pattern = @"^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";


            Match match = Regex.Match(Email, pattern);

            while (match.Success != true)
            {

                if (match.Success == true)
                {
                    Console.WriteLine(Email);
                }
                else
                {
                    Console.WriteLine("Incorrect name - please try again");
                    Email = Console.ReadLine();
                    match = Regex.Match(Email, pattern);

                }
            }


        }
    }
}
