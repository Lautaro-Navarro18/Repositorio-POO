using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Valores
    {
        private int[] numeros;
        void CargarValores()
        {
            numeros = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("coloque los valores: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }
        void ValorAcumulado()
        {
            int suma = 0;
            for (int i = 0; i < 8; i++)
            {
                suma = suma + numeros[i];
            }
            Console.Write("El valor acumulado de los valores es: " + suma + "\n");
        }
        void Acumulado36()
        {
            int suma = 0;
            for (int i = 0; i < 8; i++)
            {
                if (numeros[i] > 36)
                {
                    suma = suma + numeros[i];
                }
            }
            Console.Write("El valor acumulado de valores mayores a 36 es de: " + suma + "\n");
        }
        void MayorQ50()
        {
            int mas = 0;
            for (int i = 0; i < 8; i++)
            {
                if (numeros[i] > 50)
                {
                    mas++;
                }
            }
            Console.Write("Hay " + mas + " numeros mas grandes que 50 \n");
        }
        static void Main(string[] args)
        {
            Valores v = new Valores();
            v.CargarValores();
            v.ValorAcumulado();
            v.Acumulado36();
            v.MayorQ50();
            Console.ReadKey();
        }
    }
}
