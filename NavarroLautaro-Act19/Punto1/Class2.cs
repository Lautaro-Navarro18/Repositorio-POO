using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {
        int totalP;
        public ReservaHotel(string RtipoH, int RcantN)
        {
            if (RtipoH == "Simple")
            {
                totalP = RcantN * 5000;
            }
            else if (RtipoH == "simple")
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