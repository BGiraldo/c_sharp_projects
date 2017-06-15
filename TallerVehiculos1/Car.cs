using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos1
{
    class Car
    {

        private String plaque;

        private int hour;

        private String state;

        public string State { get => state; set => state = value; }

        public string Plaque { get => plaque; set => plaque = value; }

        public int Hour { get => hour; set => hour = value; }

        public Car(string plaque, int hour, string state)
        {
            this.plaque = plaque;
            this.hour = hour;
            this.state = state;
        }
    }
}
