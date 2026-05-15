using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Gastronomia
    {
        /*
         3. Academia de Gastronomía: Recetario Dinámico Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
        ● Definir un vector para los nombres de los alumnos.
        ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato presentado.
        ● Métodos:
        1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos de cada alumno.
        2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
        3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
        4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado" (promedio >= 70) o "Reprobado".
        5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el valor máximo de la matriz).
         */
        private string[] nombres;
        private int[][] puntajes;
        void CargarV()
        {
            nombres = new string[3];
            puntajes = new int[3][];
            puntajes[0] = new int[2];
            puntajes[1] = new int[4];
            puntajes[2] = new int[3];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese el nombre del alumno: ");
                nombres[i] = Console.ReadLine();
            }
        }
        void CargarP()
        {
            for (int i = 0; i < puntajes.Length; i++)
            {
                Console.WriteLine("Alumno: " + nombres[i]);
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    Console.Write("  Puntaje del plato " + (j + 1) + ": ");
                    puntajes[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        void MostrarL()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("El alumno " + nombres[i] + " tiene los puntajes: ");
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    Console.Write(puntajes[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        void PromedioA()
        {
            int auxA = 0;
            float promedio, auxP = 0;
            for (int i = 0; i < nombres.Length; i++)
            {
                promedio = 0;
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    promedio += puntajes[i][j];
                }
                promedio /= puntajes[i].Length;
                if(promedio > auxP)
                {
                    auxP = promedio;
                    auxA = i;
                }
                if (promedio >= 70)
                {
                    Console.WriteLine("El alumno " + nombres[i] + " tiene un promedio de " + promedio + " - Aprobado");
                }
                else
                {
                    Console.WriteLine("El alumno " + nombres[i] + " tiene un promedio de " + promedio + " - Reprobado");
                }
            }
            Console.WriteLine("El alumno " + nombres[auxA] + " tuvo el promedio mas alto con: " + auxP);
        }
        static void Main(string[] args)
        {
            Gastronomia G = new Gastronomia();
            G.CargarV();
            G.CargarP();
            G.MostrarL();
            G.PromedioA();
            Console.ReadKey();
        }
    }
}
