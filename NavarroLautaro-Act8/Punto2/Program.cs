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
            Console.WriteLine("Escriba los paises: ");
            for(int i = 0; i < paises.Length; i++)
            {
                paises[i] = Console.ReadLine();
            }
        }
        void OrdenA()
        {

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
