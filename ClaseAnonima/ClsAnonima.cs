using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnonima
{

    interface IMyInterface
    {
        String function();
    }



    class ClsAnonima
    {

        public class Anonim : IMyInterface
        {

            String x = "XD";

            public String function()
            {
                return x;
            }

        }

        public String probarAnonima()
        {
            Anonim anonima = new Anonim();
            return anonima.function();
        }



       






    }
}
