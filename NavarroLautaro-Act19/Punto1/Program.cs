using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Plantear una clase parcial ReservaHotel.
    En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), 
    validando que la cantidad de noches sea mayor a 0. Estos valores son cargados desde la consola.
    En el segundo archivo, agregar un método que calcule el total a pagar según la habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por noche).
    Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.
    */
    internal class Principal
    {
        ReservaHotel[] hotel = new ReservaHotel[3];
        public Principal()
        {
            for(int i = 0; i < hotel.Length; i++)
            {
                hotel[i] = new ReservaHotel();
            }
        }
        public void MayorP()
        {
            int auxI = 0;
            for (int i = 0; i < hotel.Length - 1; i++)
            {
                if (hotel[i].RtotalP > hotel[i + 1].RtotalP)
                {
                    auxI = i;
                }
                else
                {
                    auxI = i + 1;
                }
            }
            Console.WriteLine("El cliente " + hotel[auxI].RnombreC + " fue el que mas pago, ospedando se en " + hotel[auxI].RtipoH + " durante " + hotel[auxI].RcantN);
        }
        static void Main(string[] args)
        {
            Principal p = new Principal();
            p.MayorP();
            Console.ReadKey();
        }
    }
}
