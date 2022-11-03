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
                        FirstNumber Checkpattern = new FirstNumber();
                        Checkpattern.Checkfirstname(fname);
                        break;
                    case 2:
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