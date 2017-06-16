using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_Abstraccion
{
    abstract class ClaseA_Sobrescritura
    {

        public abstract void mostrarConsola();

        // public virtual
        public virtual String ejecutar()
        {
            return "I´m the original Function";
        }





    }



}
