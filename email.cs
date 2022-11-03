using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    internal class email
    {
        
        public void Checkemail(string Emailid)
        {
            string emailpattern = "^[a-z][a-zA-Z0-9._-]{3,20}@[a-z]{3,10}.(com)$";
            if (Regex.IsMatch(Emailid, emailpattern))
                Console.WriteLine("Email id is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
    }
}
