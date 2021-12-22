using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationDay19
{
    class UC5678Password
    {
        public static void validationPassword()
        {
            Console.Write("Please enter your password:");
            string password = Console.ReadLine();


            //++++++++++++++++++++++++++++++for uc5 user defined password=+++++++++++++++++++++++++++++++++++++++++++++=

            //string pattern = @"^[A-Za-z]{8,}$";


            //++++++++++++++++++++++++++++ UC6 At least one upper case character++++++++++++++++++++++++++++++++++

            string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z]).{8,}$";

            //++++++++++++++++++++++++++ UC7 at least one number++++++++++++++++++++++++++++

            //string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";

            //++++++++++++++++++++++++++++++++UC8 at least one special character+++++++++++++++++++++++++++++++=\

            //string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";


            //(?!^[0-9]*$)
            System.Text.RegularExpressions.Match match = Regex.Match(password, pattern);

            while (match.Success != true)
            {

                if (match.Success == true)
                {
                    Console.WriteLine(password);
                }
                else
                {
                    Console.WriteLine("Incorrect name - please try again");
                    password = Console.ReadLine();
                    match = Regex.Match(password, pattern);

                }
            }


        }
    }
}
