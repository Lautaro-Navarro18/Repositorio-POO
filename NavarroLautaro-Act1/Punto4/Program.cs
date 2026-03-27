using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.*/
            int precio, cantidad, resultado;
            string linea;
            Console.Write("Ingrese el precio: ");
            linea = Console.ReadLine();
            precio = int.Parse(linea);
            Console.Write("Ingrese la cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            resultado = precio * cantidad;
            Console.Write("tenes que pagar: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
