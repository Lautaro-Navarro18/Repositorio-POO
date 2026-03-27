using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
            int num1, num2, num3, num4, num5, num6;
            double suma = 0;
            Console.Write("Ingrese primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cuarto número: ");
            num4 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese quinto número: ");
            num5 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese sexto número: ");
            num6 = int.Parse(Console.ReadLine());
            suma = num1 + num2 + num3 + num4 + num5 + num6;
            double promedio = suma / 6;

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            Console.ReadKey();
        }
    }
}
