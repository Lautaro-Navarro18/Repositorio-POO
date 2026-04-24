using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Matrices
    {/*
     2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
        primer fila con la segunda. Imprimir luego la matriz. 
     */
        private int[,] Ma;
        private int F, C;
        void CargarV()
        {
            Console.WriteLine("Ingree la cantidad de filas y columnas de la matris: ");
            F = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            Ma = new int[F, C];

            for (int i = 0; i < F; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write("Ingrese los valores: ");
                    Ma[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        void CO()
        {
            for (int i = 0; i < F; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(Ma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Matrices M = new Matrices();
            M.CargarV();
            M.CO();
            Console.ReadKey();
        }
    }
}
