using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    internal class rule3
    {
        public void Checkpassword(string Password)
        {
            string passwordpattern = "^[A-Za-z0-9]{8,20}$";
            string passwordpattern1 = "^(?=.*[A-Z])(?=.*[a-z]{8,}).*$";
            string passwordpattern2 = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            if (Regex.IsMatch(Password, passwordpattern))
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Invalid password!!");
        }

    }
}
