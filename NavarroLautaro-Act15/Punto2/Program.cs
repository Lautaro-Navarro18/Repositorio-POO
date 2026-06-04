using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    2. Logística de Puerto Espacial
    Una estación de acoplamiento registra el peso de los contenedores transportados en las bodegas de carga de las naves espaciales que llegan al puerto.
     ● Crear la clase NaveEspacial que contenga únicamente el atributo privado NombreNave y su constructor para cargarlo.
     ● Crear la clase colaboradora PuertoControl que contenga:
      ○ Un vector de 3 objetos de la clase NaveEspacial.
      ○ Una matriz irregular de tipo double llamado pesoContenedores, donde cada fila representa a una nave, el tamaño de la fila es la cantidad de bodegas que posee esa nave, 
        y los valores almacenados son los pesos (en toneladas) de los contenedores que transporta cada bodega.
    En PuertoControl, definir los siguientes métodos:
     1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz irregular) 
        y cargue el peso del contenedor asignado a cada bodega. |
     2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave espacial. |
     3. Un método que identifique e informe qué nave transporta el contenedor individual más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz irregular). |
     4. Un método que indique el nombre de la nave que transporta menor peso acumulado total (la suma de todos sus contenedores).
    */
    class NaveE
    {
        private string nombreN;
        public NaveE()
        {
            Console.Write("Cargar el nombre de la nave: ");
            nombreN = Console.ReadLine();
        }
        public string Rnombre()
        {
            return nombreN;
        }
    }
    class PuertoC
    {
        private NaveE[] naveE;
        private double[][] pesoC;
        public PuertoC()
        {
            naveE = new NaveE[3];
            pesoC = new double[naveE.Length][];
            for (int i = 0; i < naveE.Length; i++)
            {
                naveE[i] = new NaveE();
                Console.Write("¿Cuantas bodegas tiene la nave " + naveE[i].Rnombre() + "? ");
                pesoC[i] = new double[int.Parse(Console.ReadLine())];
                for (int j = 0; j < pesoC[i].Length; j++)
                {
                    Console.Write("Ingrese el peso en toneladas: ");
                    pesoC[i][j] = double.Parse(Console.ReadLine());
                }
            }
        }
        void MostrarB()
        {
            for (int i = 0; i < pesoC.Length; i++)
            {
                Console.Write("La nave " + naveE[i].Rnombre() + " tiene estos pesos en las bodegas: ");
                for (int j = 0; j < pesoC[i].Length; j++)
                {
                    Console.Write(pesoC[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        void MostrarMP()
        {
            int auxI = 0, auxJ = 0;
            double auxM = pesoC[0][0];
            for (int i = 0; i < pesoC.Length; i++)
            {
                for (int j = 0; j < pesoC[i].Length; j++)
                {
                    if(auxM < pesoC[i][j])
                    {
                        auxM = pesoC[i][j];
                        auxI = i;
                        auxJ = j;
                    }
                }
            }
            Console.WriteLine("El contenedor mas pesado es el de la nave " + naveE[auxI].Rnombre() + " con " + pesoC[auxI][auxJ] + "T");
        }
        void MostrarML()
        {
            double aux = 0, aux2 = 0, aux3 = 0;
            int auxI = 0;
            for (int i = 0; i < pesoC.Length -1; i++)
            {
                for (int j = 0; j < pesoC[i].Length; j++)
                {
                    aux += pesoC[i][j];
                }
            }
            Console.WriteLine("La nave " + naveE[auxI].Rnombre() + " es la que nave que tiene menos carga");
        }
        static void Main(string[] args)
        {
            PuertoC pc = new PuertoC();
            pc.MostrarB();
            pc.MostrarMP();
            pc.MostrarML();
            Console.ReadKey();
        }
    }
}