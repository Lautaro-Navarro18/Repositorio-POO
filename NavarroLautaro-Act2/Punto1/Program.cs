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
            //1. Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia,
            //en caso contrario informar el producto y la división del primero respecto al segundo.
            double num1, num2;
            Console.Write("Ingrese primer número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Suma: " + (num1 + num2));
                Console.WriteLine("Diferencia: " + (num1 - num2));
            }
            else
            {
                Console.WriteLine("Producto: " + (num1 * num2));
                Console.WriteLine("División: " + (num1 / num2));
            }
        }
    }
}
