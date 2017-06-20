using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerNavegacion_2
{

    class LoginController
    {
        public static LinkedList<Proffesor> proffesors = new LinkedList<Proffesor>();
        public static Proffesor proffesor ;

        public LoginController()
        {
            Proffesor p = new Proffesor(-1,"Waldo", "a", "a");
            proffesors.AddLast(p);
        }


        public bool login(String user, String pass)
        {

            foreach(var p in proffesors)
            {
                if(p.User.Equals(user) & p.Pass.Equals(pass))
                {
                    proffesor = p;
                    return true;
                }
            }
            return false;

        }

       



    }
}
