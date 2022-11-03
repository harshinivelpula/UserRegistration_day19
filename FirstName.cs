using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    internal class FirstName
    {
        public void Checkfirstname(string firstname)
        {
            string Firstnamepattern = "^[A-Z][a-z]{2}$";
            if (Regex.IsMatch(firstname, Firstnamepattern))
                Console.WriteLine("First Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
    }
}
