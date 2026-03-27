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
            /*2. Realizar un programa que lea los lados de n triángulos, e informar:
                 a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
                 iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
                 b) Cantidad de triángulos de cada tipo.
                 c) Tipo de triángulo que posee menor cantidad.*/
            int equi=0, esca=0, iso=0;
            float lado1, lado2, lado3;
            for(int i = 0; i<3; i++)
            {
                Console.Write("Ingrese el primer lado: ");
                lado1 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo lado: ");
                lado2 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el tercer lado: ");
                lado3 = float.Parse(Console.ReadLine());
                if(lado1 == lado2)
                {
                    if(lado2 == lado3)
                    {
                        Console.Write("Es un equilatero ");
                        equi++;
                    }
                    else
                    {
                        Console.Write("Es un isosceles ");
                        iso++;
                    }
                }
                else
                {
                    if(lado1 == lado3)
                    {
                        Console.Write("Es un isosceles ");
                        iso++;
                    }
                    else
                    {
                        Console.Write("Es un escaleno ");
                        esca++;
                    }
                }
                Console.Write("\n");
            }
            Console.Write("La cantidad de equilateros es: " + equi + ", la cantidad de isosceles es: " + iso + " y la cantidad de escaleno es: " + esca);
        }
    }
}
