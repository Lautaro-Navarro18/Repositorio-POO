using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    En el segundo archivo, agregar un método que calcule el total a pagar según la habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por noche).
    */
    partial class ReservaHotel
    {
        int totalP;
        public ReservaHotel(string RtipoH, int RcantN)
        {
            if (RtipoH == "Simple")
            {
                totalP = RcantN * 5000;
            }
            else if(RtipoH == "simple")
            {
                totalP = RcantN * 5000;
            }
            if (RtipoH == "Doble")
            {
                totalP = RcantN * 8000;
            }
            else if (RtipoH == "doble")
            {
                totalP = RcantN * 8000;
            }
            if (RtipoH == "Suite")
            {
                totalP = RcantN * 12000;
            }
            else if (RtipoH == "suite")
            {
                totalP = RcantN * 12000;
            }
        }
        public int RtotalP
        {
            set
            {
                totalP = value;
            }
            get
            {
                return totalP;
            }
        }
    }
}
