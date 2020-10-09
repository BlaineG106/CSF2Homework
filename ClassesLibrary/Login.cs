using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //fields
        private string _userName;
        private string _password;

        //properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }//end UserName
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }//end Password

        //constructors
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }//end fully qualified constructor
        public Login() { }//end default constructor

        //methods
        public override string ToString()
        {
            return string.Format("User Name: {0}\n" +
                "Password: {1}\n", UserName, Password);
        }

    }
}
