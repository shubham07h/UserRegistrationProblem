using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserRegistration
{
    internal class ValidUserInfo
    {
        public static string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}";
        public static string LASTNAME = "^[A-Z]{1}[a-z]{2,}";
        //public static string EMAIL = "^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public static string EMAIL = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$";
        public static string PHONE = "^[+][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";
        public static string PASSWORD1 = "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
        //Rule1-min 8 character "^[A-z]{8,}$"       
        //Rule2 - Rule1 + atleast1UpperCaseCharacter "^(?=.*?[A-Z]).{8,}$"
        //Rule3-Rule1 +Rule2 +1 numeric = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"

        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, FIRSTNAME);
        }
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LASTNAME);
        }
        public bool validateEmail(string mail)
        {
            return Regex.IsMatch(mail, EMAIL);
        }
        public bool validatePhone(string phone)
        {
            return Regex.IsMatch(phone, PHONE);
        }
        public bool validatePass1(string pass1)
        {
            return Regex.IsMatch(pass1, PASSWORD1);
        }
    }
}
