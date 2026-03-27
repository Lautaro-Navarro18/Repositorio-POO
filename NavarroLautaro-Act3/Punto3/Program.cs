using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez"
            int num1, num2, num3;
            Console.Write("escriba su primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("segundo: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("tercero y ultimo: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.WriteLine("Todos los numeros son menores a diez");
            }
            else
            {
                Console.Write("gaga");
            }
            Console.ReadKey();
        }
    }
}
