using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryLogin
{
    class SigninController
    {

        public SigninController()
        {

        }


        public bool checkIn(User u)
        {
            foreach(var user in LoginController.users)
            {
                if (user.Document.Equals(u.Document))
                {
                    return false;
                }
            }

            LoginController.users.AddLast(u);
            return true;
        }

       



    }
}
