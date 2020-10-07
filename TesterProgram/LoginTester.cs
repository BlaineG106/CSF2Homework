using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
namespace TesterProgram
{
    class LoginTester
    {
        static void Main(string[] args)
        {
            string userName = "SpongeBob";
            string password = "pinapple";

            Login attempt1 = new Login(userName, password);
            Console.WriteLine(attempt1);

            Login attempt2 = new Login(userName, password);
            Console.WriteLine(attempt2);

        }
    }
}
