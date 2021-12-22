using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationDay19
{
    class UC4Number

    {
        public static void validationnumber()
        {
            Console.Write("Please enter your Mobile number:");
            string Mo_number = Console.ReadLine();

            string pattern = @"^([0|\+[0-9]{1,5})?([7-9][0-9]{9})$";
            //string pattern = @" ^ (?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";


            Match match = Regex.Match(Mo_number, pattern);

            while (match.Success != true)
            {

                if (match.Success == true)
                {
                    Console.WriteLine(Mo_number);
                }
                else
                {
                    Console.WriteLine("Incorrect name - please try again");
                    Mo_number = Console.ReadLine();
                    match = Regex.Match(Mo_number, pattern);

                }
            }


        }
    }
}
