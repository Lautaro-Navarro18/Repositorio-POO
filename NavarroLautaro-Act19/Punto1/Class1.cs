using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), 
    validando que la cantidad de noches sea mayor a 0. Estos valores son cargados desde la consola.
    */
    partial class ReservaHotel
    {
        private string nombreC, tipoH;
        private int cantN;
        public ReservaHotel()
        {
            Console.Write("Ingrese su nombre: ");
            nombreC = Console.ReadLine();
            Console.Write("Ingrese el tipo de habitacion deseada (tenemos Simple, Doble y Suite: ");
            tipoH = Console.ReadLine();
            Console.Write("Ingrese cuantas noches se va a quedar ");
            cantN = int.Parse(Console.ReadLine());
            while(cantN < 0)
            {
                Console.Write("La cantidad de noches ingresadas no es valida, por favor ingrese la correcta: ");
                cantN = int.Parse(Console.ReadLine());
            }
        }
        public string RnombreC
        {
            set
            {
                nombreC = value;
            }
            get
            {
                return nombreC;
            }
        }
        public string RtipoH
        {
            set
            {
                tipoH = value;
            }
            get
            {
                return tipoH;
            }
        }
        public int RcantN
        {
            set
            {
                cantN = value;
            }
            get
            {
                return cantN;
            }
        }
    }
}
