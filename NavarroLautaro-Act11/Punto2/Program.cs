using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class MatrizI
    {
        /*
         2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
        (crearla sin la intervención del operador) Realizar la carga por teclado e imprimir posteriormente.
        */
        private int[][] M;
        void CargarV()
        {
            M = new int[6][];
            Console.WriteLine("Ingrese los valores: ");
            for (int i = 0; i < 6; i++)
            {
                M[i] = new int[i + 1];
                for (int j = 0; j < i; j++)
                {
                    M[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        void MostrarM()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < M[i].Length - 1; j++)
                {
                    Console.Write(M[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            MatrizI mai = new MatrizI();
            mai.CargarV();
            mai.MostrarM();
            Console.ReadKey();
        }
    }
}