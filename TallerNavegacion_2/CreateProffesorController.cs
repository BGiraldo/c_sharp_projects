using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerNavegacion_2
{

    


    class CreateProffesorController
    {

        public CreateProffesorController()
        {

        }






        public bool addedProffesor(Proffesor pro)
        {
            foreach (var p in LoginController.proffesors)
            {
                if (p.User.Equals(pro.User))
                {
                    return false;
                }
            }

            LoginController.proffesors.AddLast(pro);
            return true;

        }










    }
}
