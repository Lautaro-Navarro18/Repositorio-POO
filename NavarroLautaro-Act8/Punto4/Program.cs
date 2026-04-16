using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class PVZ
    {
        //4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de habitantes de este.Ordenar alfabéticamente e imprimir los resultados.Por último
        //ordenar con respecto a la cantidad de habitantes(de mayor a menor) e imprimir nuevamente.
        private string[] paises;
        private int[] habitantes;
        void CargarV()
        {
            paises = new string[5];
            habitantes = new int[5];
            Console.WriteLine("Escriba los paises y su cantidad de abitantes: ");
            for (int i = 0; i < paises.Length; i++)
            {
                paises[i] = Console.ReadLine();
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }
        void OrdenP()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = 0; j < paises.Length - 1; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        string aux = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = aux;
                    }
                }
            }
            for (int x = 0; x < paises.Length; x++)
            {
                Console.WriteLine(paises[x]);
            }
        }
        void OrdenH()
        {
            for (int i = 0; i < habitantes.Length; i++)
            {
                for (int j = 0; j < habitantes.Length - 1; j++)
                {
                    if (habitantes[j] > habitantes[j + 1])
                    {
                        int aux = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = aux;
                    }
                }
            }
            for (int x = 0; x < habitantes.Length; x++)
            {
                Console.WriteLine(habitantes[x]);
            }
        }
        static void Main(string[] args)
        {
            PVZ pvz = new PVZ();
            pvz.CargarV();
            pvz.OrdenP();
            pvz.OrdenH();
            Console.ReadKey();
        }
    }
}
