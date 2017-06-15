using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryLogin
{

    class LoginController
    {

        public static LinkedList<User> users = new LinkedList<User>();
        public static User userLog = null;

        public LoginController()
        {

        }

        public bool login(String user, String pass)
        {

            foreach (var u in users)
            {
                if(u.Customer.Equals(user) & u.Pass.Equals(pass))
                {
                    userLog = u;
                    return true;
                }
            }

            return false;
        }

    }
}
