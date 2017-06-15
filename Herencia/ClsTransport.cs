using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class ClsTransport : ClsEntidad
    {

        private int numeroVehiculos;
        private int precioCupo;

        public ClsTransport(String nit, String nombre, String direccion,int numeroVehiculos, int precioCupo)
        {
            this.Nit = nit;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.numeroVehiculos = numeroVehiculos;
            this.precioCupo = precioCupo;
        }

        public int NumeroVehiculos { get => numeroVehiculos; set => numeroVehiculos = value; }
        public int PrecioCupo { get => precioCupo; set => precioCupo = value; }
    }
}
