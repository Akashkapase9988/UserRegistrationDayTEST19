using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationDay19
{
    public class UC1Name
    {

        public static void ValidationName()
        {
            Console.Write("Please enter your Name:");
            string name = Console.ReadLine();

            string pattern = @"^[A-Z]{1}[a-z]{2,}$";
            //string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";


            System.Text.RegularExpressions.Match match = Regex.Match(name, pattern);

            while (match.Success != true)
            {

                if (match.Success == true)
                {
                    Console.WriteLine(name);
                }
                else
                {
                    Console.WriteLine("Incorrect name - please try again");
                    name = Console.ReadLine();
                    match = Regex.Match(name, pattern);

                }
            }


        }


    }
}
