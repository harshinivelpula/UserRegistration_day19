using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    internal class lastname
    {
        public void Checklastname(string Lastname)
        {
            string lastnamepattern = "^[A-Z][a-z]{3,10}$";
            if (Regex.IsMatch(Lastname, lastnamepattern))
                Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
    }
}
