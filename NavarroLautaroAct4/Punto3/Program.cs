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
            /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
             * valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/
            int suma = 0, num;
            bool es = true;
            while (es)
            {
                Console.Write("Ingrese valores: ");
                num = int.Parse(Console.ReadLine());
                if (num != 9999)
                {
                    suma = suma + num;
                }
                else
                {
                    es = false;
                }
            }
            if(suma > 0)
            {
                Console.Write("Es mayor a 0 (" + suma + ")");
            }
            else
            {
                if(suma == 0)
                {
                    Console.Write("Es 0 (" + suma + ")");
                }
                else
                {
                    Console.Write("Es menor a 0 (" + suma + ")");
                }
            }
        }
    }
}
