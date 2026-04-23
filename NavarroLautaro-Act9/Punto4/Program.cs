using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Docentes
    {
        /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
sus nombres y puntajes promedio obtenidos (de 1 a 10).
Cargar sus datos en vectores paralelos, mostrar docente con calificación más
alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
desaprobaron (tomando como base que se aprueba con una nota mayor o igual
a 6)*/
        private string[] nombres;
        private int[] puntajes;
        private float promedio;
        void CargarD()
        {
            nombres = new string[3];
            puntajes = new int[3];
            int punta = 0;
            Console.WriteLine("Escriba el nombre y puntaje del docente: ");
            for(int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Console.ReadLine();
                punta = int.Parse(Console.ReadLine());
                if(punta > 0 && punta < 11)
                {
                    puntajes[i] = punta;
                }
                else
                {
                    Console.WriteLine("Estas poniendo una nota imposible, ingrese la nota bien: ");
                    punta = int.Parse(Console.ReadLine());
                    if (punta > 0 && punta < 11)
                    {
                        puntajes[i] = punta;
                    }
                    else
                    {
                        Console.WriteLine("Bueno, queda con 1");
                        puntajes[i] = 1;
                    }
                }
            }
        }
        void Promedio()
        {
            for(int i = 0; i < nombres.Length; i++)
            {
                promedio += puntajes[i];  
            }
            promedio /= nombres.Length;
            Console.WriteLine("El promedio de los docentes fue de: " + promedio);
        }
        void AltoBajo()
        {
            int alto = 0, bajo = 0;
            for(int i = 0; i < nombres.Length -1; i++)
            {
                if (puntajes[alto] < puntajes[i + 1])
                {
                    alto = i + 1;
                }
                if (puntajes[bajo] > puntajes[i + 1])
                {
                    bajo = i + 1;
                }
            }
            Console.WriteLine("El docente " + nombres[alto] + " tuvo la nota mas alta con " + puntajes[alto] + " y el docente " + nombres[bajo] + " tuvo la nota mas baja con " + puntajes[bajo]);
        }
        void Ordenar()
        {
            int auxI = 0;
            string auxS;
            for (int j = 0; j < nombres.Length; j++)
            {
                for (int i = 0; i < nombres.Length - 1; i++)
                {
                    if (puntajes[i] < puntajes[i + 1])
                    {
                        auxI = puntajes[i + 1];
                        puntajes[i + 1] = puntajes[i];
                        puntajes[i] = auxI;
                        auxS = nombres[i + 1];
                        nombres[i + 1] = nombres[i];
                        nombres[i] = auxS;
                    }
                }
            }
            for(int o = 0; o < nombres.Length; o++)
            {
                Console.WriteLine(nombres[o] + " " + puntajes[o]);
            }
        }
        void AprobooNo()
        {
            int si = 0;
            for(int i = 0; i < nombres.Length; i++)
            {
                if (puntajes[i] >= 6)
                {
                    si++;
                }
            }
            Console.Write("Aprobaron " + si + " profesores");
        }
        static void Main(string[] args)
        {
            Docentes d = new Docentes();
            d.CargarD();
            d.Promedio();
            d.AltoBajo();
            d.Ordenar();
            d.AprobooNo();
            Console.ReadKey();
        }
    }
}
