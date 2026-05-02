using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Matrices
    {
        /*
         3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
            cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
            etc.) 
        */
        private int[,] M;
        private int f = 0;
        private int c = 0;
        void CargarV()
        {
            Console.Write("Dale un valor a n: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Dale un valor a m: ");
            c = int.Parse(Console.ReadLine());
            M = new int[f, c];
            for (int fi = 0; fi < f; fi++)
            {
                for (int co = 0; co < c; co++)
                {
                    Console.Write("Ingresa los componentes de la matriz: ");
                    M[fi, co] = int.Parse(Console.ReadLine());
                }
            }
        }
        void Imprimir()
        {
            Console.WriteLine(M[0, 0] + " - " + M[0, c - 1]);
            Console.WriteLine(M[f - 1, 0] + " - " + M[f - 1, c - 1]);
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