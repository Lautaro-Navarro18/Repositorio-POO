using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor,
    calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.
    */
    internal class Operaciones
    {
        private float num1, num2;
        public Operaciones()
        {
            Console.Write("Ingrese los valores: ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
        }
        void Suma()
        {
            Console.WriteLine("La suma de los 2 numeros es: " + (num1 + num2));
        }
        void Resta()
        {
            Console.WriteLine("La resta de los 2 numeros es: " + (num1 - num2));
        }
        void Multi()
        {
            Console.WriteLine("La multiplicación de los 2 numeros es: " + (num1 * num2));
        }
        void Divi()
        {
            Console.Write("La división de los 2 numeros es: " + (num1 / num2));
        }
        static void Main(string[] args)
        {
            Operaciones O = new Operaciones();
            O.Suma();
            O.Resta();
            O.Multi();
            O.Divi();
            Console.ReadKey();
        }
    }
}
