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
            //4. Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
            int num1, num2, num3;
            Console.Write("Ingrese primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.Write(num1);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.Write(num2);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            Console.ReadKey();
        }
    }
}
