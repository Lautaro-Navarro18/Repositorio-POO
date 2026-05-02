using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Matrices
    {
        /*
         1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
            componentes por columna (es decir primero ingresar toda la primer
            columna, luego la segunda columna y así sucesivamente)
            Imprimir luego la matriz.
        */
        private int[,] M;
        void CargarV()
        {
            M = new int[2, 5];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Ingrese los valores: ");
                    M[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        void Imprimir()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Matrices m = new Matrices();
            m.CargarV();
            m.Imprimir();
            Console.ReadKey();
        }
    }
}