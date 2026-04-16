using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Orden
    {
        /*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el algoritmo de ordenamiento alfabético.*/
        private string[] paises;
        void CargarP()
        {
            paises = new string[5];
            Console.WriteLine("Escriba los paises: ");
            for (int i = 0; i < paises.Length; i++)
            {
                paises[i] = Console.ReadLine();
            }
        }
        void OrdenA()
        {
            for(int i=0; i<paises.Length; i++)
            {
                for(int j=0; j<paises.Length-1; j++)
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
        static void Main(string[] args)
        {
            Orden o = new Orden();
            o.CargarP();
            o.OrdenA();
            Console.ReadKey();
        }
    }
}