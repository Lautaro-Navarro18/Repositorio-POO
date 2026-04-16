using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Orden
    {
        //3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector (el orden lo pueden elegir ustedes).
        private int[] V;
        void CargarV()
        {
            int num;
            Console.Write("Ingrese la longitud del vector: ");
            num = int.Parse(Console.ReadLine());
            V = new int[num];
            Console.WriteLine("Ingrese los valores: ");
            for(int i = 0; i < num; i++)
            {
                V[i] = int.Parse(Console.ReadLine());
            }
        }
        void OrdenV()
        {
            for (int i = 0; i < V.Length; i++)
            {
                for (int j = 0; j < V.Length - 1; j++)
                {
                    if (V[j] > V[j + 1])
                    {
                        int aux = V[j];
                        V[j] = V[j + 1];
                        V[j + 1] = aux;
                    }
                }
            }
            for (int x = 0; x < V.Length; x++)
            {
                Console.WriteLine(V[x]);
            }
        }
        static void Main(string[] args)
        {
            Orden o = new Orden();
            o.CargarV();
            o.OrdenV();
            Console.ReadKey();
        }
    }
}
