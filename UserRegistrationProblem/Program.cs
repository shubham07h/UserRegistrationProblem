using System;
using System.Text.RegularExpressions;//namespace for regex
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            ValidUserInfo re = new ValidUserInfo();

            Console.WriteLine("Enter first Name");
            string first = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Last Name");
            string last = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Valid Email ");
            string mail = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Valid Phone number ");
            string phone = Convert.ToString(Console.ReadLine());

            // Console.WriteLine("Enter Valid Password with minimum 8 characters ");
            // Console.WriteLine("Enter Valid Password with minimum 8 characters with Atleast 1 Upper Case ");
            Console.WriteLine("Enter Password with min 8 element ,Atleast 1 UpperCase, 1 NumericValue, 1 special character");
            string pass1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(re.validateFirstName(first));
            Console.WriteLine(re.validateLastName(last));
            Console.WriteLine(re.validateEmail(mail));
            Console.WriteLine(re.validatePhone(phone));
            Console.WriteLine(re.validatePass1(pass1));
        }
    }
}