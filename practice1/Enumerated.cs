using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Enumerated
    {

        public enum Days : byte { Sat = 1 , Sun, Mon, Tue, Wed, Thu, Fri };

        public byte traerPosicionDia()
        {
            return (byte)Days.Sun;
        }

    }
}
