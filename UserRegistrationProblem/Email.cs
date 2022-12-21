using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Email
    {
        public void UCThree()
        {
            Console.WriteLine("Enter user email");
            var data = Console.ReadLine();
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";


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

