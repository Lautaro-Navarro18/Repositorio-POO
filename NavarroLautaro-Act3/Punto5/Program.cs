using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0).
            float x, y;
            Console.Write("x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = float.Parse(Console.ReadLine());
            if (x == 0 || y == 0)
            {
                Console.Write("no 0");
            }
            else
            {
                if (x > 0 && y > 0)
                {
                    Console.Write("1 cuadrante");
                }
                if (x > 0 && y < 0)
                {
                    Console.Write("4 cuadrante");
                }
                if (x < 0 && y > 0)
                {
                    Console.Write("2 cuadrante");
                }
                if (x < 0 && y < 0)
                {
                    Console.Write("3 cuadrante");
                }
            }
            Console.ReadKey();
        }
    }
}
