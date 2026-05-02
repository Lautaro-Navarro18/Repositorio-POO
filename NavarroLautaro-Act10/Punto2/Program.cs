using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Matrices
    {
        /*
         2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
            primer fila con la segunda. Imprimir luego la matriz.
        */
        private int[,] M;
        private int f = 0;
        private int c = 0;
        void CargarV()
        {
            Console.Write("Dale valor a n: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Dale valor a m: ");
            c = int.Parse(Console.ReadLine());
            
            M = new int[f, c];

            for (int fi = 0; fi < f; fi++)
            {
                for (int co = 0; co < c; co++)
                {
                    Console.Write("Ingresa los valores de la matriz: ");
                    M[fi, co] = int.Parse(Console.ReadLine());
                }
            }
        }
        void IntercambiarF()
        {
            for (int co = 0; co < c; co++)
            {
                int aux = M[0, co];
                M[0, co] = M[1, co];
                M[1, co] = aux;
            }
        }

        void Imprimir()
        {
            for (int fi = 0; fi < f; fi++)
            {
                for (int co = 0; co < c; co++)
                {
                    Console.Write(M[fi, co] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Matrices m = new Matrices();
            m.CargarV();
            m.IntercambiarF();
            m.Imprimir();
            Console.ReadKey();

        }
    }
}