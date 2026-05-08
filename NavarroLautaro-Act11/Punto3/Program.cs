using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Empresa
    {
        /*
         3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
        Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz irregular para cargar los días que han faltado cada empleado (cargar el número de día que faltó)
        Cada fila de la matriz representa los días de cada empleado.
        a. Mostrar los empleados con la cantidad de inasistencias.
        b. Cuál empleado faltó menos días.
         */
        private string[] nombres;
        private string[][] faltas;
        private int[] canti;
        void CargarV()
        {
            canti = new int[3];
            faltas = new string[3][];
            nombres = new string[3];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de días que falto " + nombres[i] + ": ");
                canti[i] = int.Parse(Console.ReadLine());
                faltas[i] = new string[canti[i]];
                for (int j = 0; j < faltas[i].Length; j++)
                {
                    Console.Write("Ingrese los días que falto " + nombres[i] + ": ");
                    faltas[i][j] = Console.ReadLine();
                }
            }
        }
        void CadaEmp()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("El empleado " + nombres[i] + " falto " + canti[i] + " veces");
            }
        }
        void MenosFal()
        {
            int aux = 0;
            for (int i = 0; i < canti.Length - 1; i++)
            {
                if (canti[i] < canti[i + 1])
                {
                    if(aux > canti[i])
                    {
                        aux = i;
                    }
                }
                else
                {
                    if (aux > canti[i])
                    {
                        aux = i + 1;
                    }
                }
            }
            Console.Write("El empleado " + nombres[aux] + " falto " + canti[aux] + " veces");
        }
        static void Main(string[] args)
        {
            Empresa E = new Empresa();
            E.CargarV();
            E.CadaEmp();
            E.MenosFal();
            Console.ReadKey();
        }
    }
}
