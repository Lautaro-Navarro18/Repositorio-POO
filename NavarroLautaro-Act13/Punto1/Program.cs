using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
     1. Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. En el constructor cargar los atributos
    y luego en otro método imprimir sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
     */
    internal class Empleado
    {
        private string nombre;
        private int sueldo;
        public Empleado()
        {
            Console.Write("¿Nombre? ");
            nombre = Console.ReadLine();
            Console.Write("¿Sueldo? ");
            sueldo = int.Parse(Console.ReadLine());
        }
        void Imprimir()
        {
            Console.Write("Señor " + nombre + " tiene un sueldo de " + sueldo);
        }
        void Impuesto()
        {
            if (sueldo > 3000)
            {
                Console.Write(" Lamentamos informarle que tiene que pagar un impuesto por plata");
            }
        }
        static void Main(string[] args)
        {
            Empleado E = new Empleado();
            E.Imprimir();
            E.Impuesto();
            Console.ReadKey();
        }
    }
}