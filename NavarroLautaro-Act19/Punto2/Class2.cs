using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        public void Resumen()
        {
            Console.Write("El libro " + Rtitulo + " del autor " + Rautor + " tiene una duración ");
            if (Rpaginas < 100)
            {
                Console.WriteLine(" Corto");
            }
            else
            {
                Console.WriteLine(" Largo");
            }
        }
    }
}