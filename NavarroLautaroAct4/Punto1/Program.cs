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
            /*1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los sueldos que cobra cada empleado e 
             * informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. Además el programa deberá informar el importe que gasta la empresa 
             * en sueldos al personal.*/
            int x, n, sueldo, suma, menos, mas;
            x = 0;
            menos = 0;
            mas = 0;
            suma = 0;
            Console.Write("Ingrese cuantos empleados hay: ");
            n = int.Parse(Console.ReadLine());
            while(x < n)
            {
                Console.Write("ingrese el salario del empleado: ");
                sueldo = int.Parse(Console.ReadLine());
                if(sueldo > 100 && sueldo < 300)
                {
                    menos++;
                    suma = suma + sueldo;
                }
                else
                {
                    if(sueldo > 300)
                    {
                        mas++;
                        suma = suma + sueldo;
                    }
                }
                x++;
            }
            Console.Write("La cantidad que combran mas de 300 son: " + mas + "\n");
            Console.Write("La cantidad que cobran menos de 300 son: " + menos + "\n");
            Console.Write("Lo que gasta la empresa es: " + suma);
            Console.ReadKey();
        }
    }
}
