using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_Abstraccion
{
    class ClsB_Sobrescritura : ClaseA_Sobrescritura
    {

        
        public override String ejecutar()
        {
            return "Soy la funcion Sobrescrita";
        }
        

        public override void mostrarConsola()
        {
            System.Console.WriteLine("Soy yo desde la consola");
        }


    }
}
