using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class SumaV
    {
        /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
tercer vector del mismo tamaño. Sumar componente a componente.*/
        private int[] V1;
        private int[] V2;
        private int[] VS;
        void CargarV()
        {
            V1 = new int[4];
            V2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("cargue los valores del primer vector: ");
                V1[i] = int.Parse(Console.ReadLine());
            }
            for (int f = 0; f < 4; f++)
            {
                Console.Write("cargue los valores del segundo vector: ");
                V2[f] = int.Parse(Console.ReadLine());
            }
        }
        void Suma()
        {
            VS = new int[4];
            for(int i = 0; i < 4; i++)
            {
                VS[i] = V1[i];
                VS[i] = VS[i] + V2[i];            //el problema profe, de porque sumaba 20 sin motivo era porque esto: '\n' + VS[i] + '\n' lo lee como 10 + VS[i] + 10 
                Console.Write("\n" + VS[i]);      //la solucion es poner le comillas dobles " en lugar de '
            }
        }
        static void Main(string[] args)
        {
            SumaV sv = new SumaV();
            sv.CargarV();
            sv.Suma();
            Console.ReadKey();
        }
    }
}
