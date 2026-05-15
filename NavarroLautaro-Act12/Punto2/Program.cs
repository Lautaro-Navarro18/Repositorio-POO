using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Cine
    {
        /*
         2. Gestión de Complejo de Cine Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10 asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        ● Definir una matriz irregular de 4 filas para representar los asientos.
        ● Métodos:
        1. Inicializar la matriz con los tamaños de las salas mencionadas (sin intervención del operador).  TA
        2. Crear un método de "Venta de Entradas" que permita cargar la edad del espectador en un asiento específico (fila y columna).  TA
        3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador en cada asiento.  TA
        4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.  TA
        5. Informar cuál es el promedio de edad de los espectadores de todo el complejo.  TA
         */
        private int[][] asientos;
        void IngresarA()
        {
            asientos = new int[4][];
            asientos[0] = new int[10];
            asientos[1] = new int[15];
            asientos[2] = new int[8];
            asientos[3] = new int[12];
        }
        void VentaDeEntradas()
        {
            int auxf = 0, auxc = 0;
            Console.WriteLine("Ingrese la sala a la que desea ir y al asiento que quiere usar: ");
            auxf = int.Parse(Console.ReadLine()) - 1;
            auxc = int.Parse(Console.ReadLine()) - 1;
            if(auxf >= 0 && auxf < 4)
            {
                if (auxc >= 0 && auxc < asientos[auxf].Length)
                {
                    Console.Write("Ingrese su edad: ");
                    asientos[auxf][auxc] = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("El asiento no existe");
                }
            }
            else
            {
                Console.Write("La sala no existe");
            }        
        }
        void ImprimirM()
        {
            for (int i = 0; i < asientos.Length; i++)
            {
                Console.WriteLine("La sala " + (i + 1));
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    Console.Write(asientos[i][j]);
                }
                Console.WriteLine();
            }
        }
        void BuscarM18()
        {
            int M;
            for (int i = 0; i < asientos.Length; i++)
            {
                M = 0;
                Console.Write("La sala " + (i + 1));
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    if (asientos[i][j] < 18  && asientos[i][j] > 0)
                    {
                        M++;
                    }
                }
                Console.Write(" hay " + M + " menores a 18");
                Console.WriteLine();
            }
        }
        void Promedio()
        {
            float promedio;
            int D;
            for (int i = 0; i < asientos.Length; i++)
            {
                promedio = 0;
                D = 0;
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    if (asientos[i][j] > 0)
                    {
                        promedio += asientos[i][j];
                        D++;
                    }
                }
                if(D > 0)
                {
                    promedio /= D;
                    Console.WriteLine("El promedio de las edades de la sala " + (i+1) + " es de " + promedio);
                }
            }
        }
        static void Main(string[] args)
        {
            Cine C = new Cine();
            C.IngresarA();
            C.VentaDeEntradas();
            C.ImprimirM();
            C.BuscarM18();
            C.Promedio();
            Console.ReadKey();
        }
    }
}
