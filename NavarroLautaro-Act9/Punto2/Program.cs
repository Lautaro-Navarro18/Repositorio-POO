using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Empresa
    {
        /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
vectores paralelos, ordenar los datos de mayor a menor según las ventas,
imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
el que menos vendió de los 5 empleados.*/
        private string[] nombres;
        private int[] ventas;
        void CargarV()
        {
            nombres = new string[5];
            ventas = new int[5];
            Console.WriteLine("Ingrese los nombres de los trabajadores y sus ventas ");
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Console.ReadLine();
                ventas[i] = int.Parse(Console.ReadLine());
            }
        }
        void OrdenV()
        {
            int auxi = 0;
            string auxs;
            for (int i = 0; i < ventas.Length; i++)
            {
                for (int j = 0; j < ventas.Length - 1; j++)
                {
                    if (ventas[j] < ventas[j + 1])
                    {
                        auxs = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = auxs;
                        auxi = ventas[j];
                        ventas[j] = ventas[j + 1];
                        ventas[j + 1] = auxi;
                    }
                }
            }
            for (int o = 0; o < ventas.Length; o++)
            {
                Console.WriteLine(nombres[o] + "  " + ventas[o]);
            }
            Console.WriteLine("El que menos vendio fue " + nombres[nombres.Length - 1] + " con un monto de " + ventas[ventas.Length - 1]);
        }
        static void Main(string[] args)
        {
            Empresa e = new Empresa();
            e.CargarV();
            e.OrdenV();
            Console.ReadKey();
        }
    }
}