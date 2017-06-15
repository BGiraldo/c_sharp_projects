using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Auto
    {

        public String placa { get; set; }

        public String marca { get; set; }

        public String color { get; set; }


        public Auto(string placa, string marca, string color)
        {
            this.placa = placa;
            this.marca = marca;
            this.color = color;
        }


    }
}
