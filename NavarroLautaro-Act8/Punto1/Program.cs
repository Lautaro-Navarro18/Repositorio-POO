using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class VectorM
    {
        /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector.*/
        private int[] V;
        void CargarV()
        {
            int num, menor=0;
            Console.WriteLine("Ingrese la longitud del vector: ");
            num = int.Parse(Console.ReadLine());
            V = new int[num];
            Console.WriteLine("Ingrese los valores: ");
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = int.Parse(Console.ReadLine());
                if (menor == V[i])
                {
                    Console.WriteLine("El numero que ingresaste es igual al valor mas chico ya puesto");
                }
                if (i == 0)
                {
                    menor = V[0];
                }
                if (V[i] < menor)
                {
                    menor = V[i];
                }
            }
            Console.Write("El valor mas chico del vector es: " + menor);
        }
        static void Main(string[] args)
        {
            VectorM vm = new VectorM();
            vm.CargarV();
            Console.ReadKey();
        }
    }
}