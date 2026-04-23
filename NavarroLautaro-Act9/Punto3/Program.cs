using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Atletas
    {
        /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
carrera de 100 metros. El programa debe cargar los datos en dos vectores
paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
promedio.*/
        private string[] nombres;
        private int[] tiempos;
        private float promedio = 0;
        void CargarV()
        {
            nombres = new string[5];
            tiempos = new int[5];
            Console.WriteLine("Ingrese los nombres y tiempo de los atletas (en segundos): ");
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Console.ReadLine();
                tiempos[i] = int.Parse(Console.ReadLine());
            }
        }
        void Promedio()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                promedio += tiempos[i];
            }
            promedio /= nombres.Length;
            Console.WriteLine("El promedio de los atletas es de: " + promedio);
        }
        void MejorPeor()
        {
            int mejor = 0, peor = 0;
            for (int i = 0; i < nombres.Length - 1; i++)
            {
                if (tiempos[i] > tiempos[i + 1])
                {
                    mejor = i+1;
                }
                if (tiempos[i] < tiempos[i + 1])
                {
                    peor = i+1;
                }
            }
            Console.WriteLine("El atleta mas rapido fue: " + nombres[mejor] + " y el mas lento fue: " + nombres[peor]);
        }
        void PromeSupe()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                if (tiempos[i] < promedio)
                {
                    Console.Write("El atleta: " + nombres[i] + " supero el promedio con un tiempo de " + tiempos[i] +"\n");
                }
            }
        }
        static void Main(string[] args)
        {
            Atletas A = new Atletas();
            A.CargarV();
            A.Promedio();
            A.MejorPeor();
            A.PromeSupe();
            Console.ReadKey();
        }
    }
}