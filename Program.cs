using UserRegistration1;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Validate first name ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("First letter should be capital");
                        Console.WriteLine("length should be Minimum three characters");
                        Console.WriteLine("Enter First name");
                        string fname = Console.ReadLine();
                        FirstName Checkpattern = new FirstName();
                        Checkpattern.Checkfirstname(fname);
                        break;
                    case 2:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter Last name :");
                        string lname = Console.ReadLine();
                        lastname Lastname = new lastname();
                        Lastname.Checklastname(lname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id :");
                        string email = Console.ReadLine();
                        email Email = new email();
                        Email.Checkemail(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile No. :");
                        string mobilenum = Console.ReadLine();
                        mobile Mobile = new mobile();
                        Mobile.Checkmobilenum(mobilenum);
                        break;
                    case 5:
                        Console.WriteLine("Enter Passward :");
                        string password = Console.ReadLine();
                        rule1 passwordruleone = new rule1();
                        passwordruleone.Checkpassword(password);
                        break;
                    case 6:
                        Console.WriteLine("Enter Passward :");
                        string password = Console.ReadLine();
                        string password1 = Console.ReadLine();
                        rule2 passwordruletwo = new rule2();
                        passwordruletwo.Checkpassword(password);
                        break;
                    case 7:
                        Console.WriteLine("Enter Passward :");
                        string passwordpattern = Console.ReadLine();
                        string passwordpattern1 = Console.ReadLine();
                        string passwordpattern2 = Console.ReadLine();
                        rule3 passwordrulethree = new rule3();
                        passwordrulethree.Checkpassword(password);
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}