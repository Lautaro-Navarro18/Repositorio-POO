using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{

    /*Implementar la clase operaciones. Se deben cargar dos valores enteros, calcular su suma, resta, multiplicación y división, cada una en un método,
     * imprimir dichos resultados. */

    class Operaciones
    {
        private int num1, num2;
        private float resultado;
        public void Datos()
        {
            Console.Write("Inserte el primero numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Inserte el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
        }

        public void Suma()
        {
            Console.WriteLine("La suma de los valores es: ");
            resultado = num1 + num2;
            Console.WriteLine(resultado);
        }

        public void Resta()
        {
            Console.WriteLine("La resta de los valores es: ");
            resultado = num1 - num2;
            Console.WriteLine(resultado);
        }

        public void Multiplicacion()
        {
            Console.WriteLine("La multiplicacion de los valores es: ");
            resultado = num1 * num2;
            Console.WriteLine(resultado);
        }

        public void Division()
        {
            Console.WriteLine("La division de los valores es: ");
            resultado = num1 / num2;
            Console.WriteLine(resultado);
        }

        static void Main(string[] args)
        {
            Operaciones operaciones1 = new Operaciones();
            operaciones1.Datos();
            operaciones1.Suma();
            operaciones1.Resta();
            operaciones1.Multiplicacion();
            operaciones1.Division();
            Console.ReadKey();
        }
    }
}