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
            //3. Se ingresa por teclado un número positivo de uno o dos dígitos (1..99)
            //mostrar un mensaje indicando si el número tiene uno o dos dígitos.
            //(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
            int num;
            Console.Write("Ingrese un número (1-99): ");
            num = int.Parse(Console.ReadLine());


            if (num < 10)
            {
                if(num > 0)
                {
                    Console.WriteLine("Tiene un dígito");
                }
                
            }
            else
            {
                if(num < 100)
                {
                    Console.WriteLine("Tiene dos dígitos");
                }
            }
        }
    }
}
