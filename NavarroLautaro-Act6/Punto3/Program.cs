using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Empleado
    {
        //Confeccionar una clase que represente un empleado.Definir como atributos su nombre y su sueldo.Confeccionar los métodos para la carga, otro para imprimir
        //sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)

        private int sueldo;
        private string nombre;
        public void cargarDatos()
        {
            Console.WriteLine("Ingresa un nombre de un empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa un sueldo para ese empleado: ");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void imprimirDatos()
        {
            Console.WriteLine("su sueldo es: ");
            Console.WriteLine(sueldo);
            Console.WriteLine("su nombre es: ");
            Console.WriteLine(nombre);
        }

        public void debePagarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("este empleado debe pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.cargarDatos();
            empleado.imprimirDatos();
            empleado.debePagarImpuestos();
            Console.ReadKey();
        }
    }
}