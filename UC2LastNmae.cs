using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationDay19
{
    class UC2LastNmae
    {
        public static void validationlastname()
        {
            Console.Write("Please enter your LastName:");
            string Last_name = Console.ReadLine();

            string pattern = @"^[A-Z]{1}[a-z]{2,}$";
            //string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";


            System.Text.RegularExpressions.Match match = Regex.Match(Last_name, pattern);

            while (match.Success != true)
            {

                if (match.Success == true)
                {
                    Console.WriteLine(Last_name);
                }
                else
                {
                    Console.WriteLine("Incorrect name - please try again");
                    Last_name = Console.ReadLine();
                    match = Regex.Match(Last_name, pattern);

                }
            }


        }
    }
}
