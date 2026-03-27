using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
            int dia, mes;
            string linea;
            Console.Write("escriba un dia (del 1 al 31): ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.Write("escriba un mes (del 1 al 12: ");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            if (dia == 25 && mes == 12)
            {
                Console.Write("es esa fecha");
            }
            else
            {
                Console.Write("todo mal");
            }
            Console.ReadKey();
        }
    }
}
