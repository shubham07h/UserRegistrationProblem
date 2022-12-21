using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class FirstName
    {
        public void First()
        {
            Console.WriteLine("Enter first name");
            var data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}