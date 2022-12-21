using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class MobileFormat
    {
        public void Mobileno()
        {
            Console.WriteLine("Enter user mobile number");
            var data = Console.ReadLine();
            string pattern = "^[1-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is valid");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is invalid");
                Console.ResetColor();

            }
        }
    }
}
