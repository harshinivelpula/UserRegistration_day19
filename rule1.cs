using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    internal class rule1
    {
        public void Checkpassward(string Passward)
        {
            string passwardpattern = "^[A-Za-z0-9]{8,20}$";
            if (Regex.IsMatch(Passward, passwardpattern))
                Console.WriteLine("Passward is valid");
            else
                Console.WriteLine("Invalid passward!!");
        }
    }
}
