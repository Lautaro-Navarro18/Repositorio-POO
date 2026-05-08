using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Paises
    {
        /*
         1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato las temperaturas medias mensuales de dichos paises.
        Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
        Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
        a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales. TA
        b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas. TA
        c. Calcular la temperatura media trimestral de cada país. TA
        d. Imprimir los nombres de los paises y las temperaturas medias trimestrales. TA
        e. Imprimir el nombre del país con la temperatura media trimestral mayor. TA
        */
        private float[] tempT;
        private string[] pais;
        private int[,] temperatura;
        void CargarV()
        {
            tempT = new float[4];
            pais = new string[4];
            temperatura = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el pais: ");
                pais[i] = Console.ReadLine();
                Console.WriteLine("Ingrese las temperaturas de los ultimos 3 meses: ");
                for (int j = 0; j < 3; j++)
                {
                    temperatura[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        void MostrarP()
        {
            for (int i = 0; i < pais.Length; i++)
            {
                Console.Write("El pais " + pais[i] + " tuvo estas 3 temperaturas: ");
                Console.WriteLine("La temperatura de los meses fueron de: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(temperatura[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        void TempMT()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tempT[i] += temperatura[i, j];
                }
                tempT[i] = tempT[i] / 3;
                Console.WriteLine("El pais: " + pais[i] + " tuvo: " + tempT[i] + " temperatura");
            }
        }
        void TMM()
        {
            int aux = 0;
            for (int i = 0; i < tempT.Length - 1; i++)
            {
                if (tempT[i] > tempT[i + 1])
                {
                    aux = i;
                }
                else
                {
                    aux = i + 1;
                }
            }
            Console.WriteLine("El pais: " + pais[aux] + " tuvo la mayor temperatura media trimestral con: " + tempT[aux]);
        }
        static void Main(string[] args)
        {
            Paises P = new Paises();
            P.CargarV();
            P.MostrarP();
            P.TempMT();
            P.TMM();
            Console.ReadKey();
        }
    }
}