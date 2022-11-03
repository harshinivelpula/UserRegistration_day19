using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    internal class mobile
    {
        public void Checkmobilenum(string Mobilenum)
        {
            string mobilenumpattern = "^[1,9]{2}-[6-9]{1}[0-9]{9}";
            if (Regex.IsMatch(Mobilenum, mobilenumpattern))
                Console.WriteLine("Mobile number is valid");
            else
                Console.WriteLine("Invalid mobile number!!");
        }
    }
}
