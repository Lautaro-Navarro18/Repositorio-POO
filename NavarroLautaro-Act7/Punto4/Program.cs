using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class VectorD
    {
        //4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor y de mayor a menor.
        private int[] pejelagarto;
        void CargarV()
        {
            pejelagarto = new int[10];
            Console.WriteLine("Ingrese los valores");
            for(int i=0; i<pejelagarto.Length; i++)
            {
                pejelagarto[i] = int.Parse(Console.ReadLine());
            }
        }
        void VerificacionV()
        {
            int Ma = 0, Me = 0;

            for (int i = 0; i < pejelagarto.Length - 1; i++)
            {
                if (pejelagarto[i] <= pejelagarto[i + 1])
                {
                    Ma++;
                }

                if (pejelagarto[i] >= pejelagarto[i + 1])
                {
                    Me++;
                }
            }

            if (Ma == pejelagarto.Length - 1)
            {
                Console.WriteLine("El vector está ordenado de manera ascendente");
            }
            else
            {
                if (Me == pejelagarto.Length - 1) { 
                    Console.WriteLine("El vector está ordenado de manera descendente");
                }else{
                Console.WriteLine("No está ordenado");
                }
            }
            
        }
        static void Main(string[] args)
        {
            VectorD vd = new VectorD();
            vd.CargarV();
            vd.VerificacionV();
            Console.ReadKey();
        }
    }
}