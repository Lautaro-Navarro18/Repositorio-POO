using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1: Sistema de control de vuelos 
    Problema:
    Una aerolínea administra los vuelos programados mediante un sistema orientado a objetos.
    Plantear una clase base Vuelo que contenga como propiedades: número de vuelo, destino y duración en horas. Luego definir una clase derivada 
    VueloInternacional que herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
    Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos desde consola y luego:
     Mostrar los vuelos registrados y el país de destino.
     Informar cuál es el vuelo con mayor duración.
     Mostrar el orden de ejecución de los constructores. 
    */
    public class Vuelo
    {
        private int numroV, duracion;
        private string destino;
        public Vuelo(int numV, string dest, int dur)
        {
            numroV = numV;
            destino = dest;
            duracion = dur;
        }
        public int RnumroV
        {
            set
            {
                numroV = value;
            }
            get
            {
                return numroV;
            }
        }
        public string Rdestino
        {
            set
            {
                destino = value;
            }
            get
            {
                return destino;
            }
        }
        public int Rduracion
        {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }
    }
    public class VueloInternacional : Vuelo
    {
        string paisD;
        public VueloInternacional(string paD, int numV, string dest, int dur) : base (numV, dest, dur)
        {
            paisD = paD;
        }
        public string RpaisD
        {
            set
            {
                paisD = value;
            }
            get
            {
                return paisD;
            }
        }
        static void Main(string[] args)
        {
            List<VueloInternacional> vuelo = new List<VueloInternacional>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el numero de vuelo: ");
                int numV = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el destino: ");
                string dest = Console.ReadLine();
                Console.Write("Ingrese la duracion en horas: ");
                int dur = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el pais del destino: ");
                string paD = Console.ReadLine();
                VueloInternacional nuevoV = new VueloInternacional(paD, numV, dest, dur);
                vuelo.Add(nuevoV);
                Console.WriteLine("Se ingreso correctamente la informacion");
            }
            foreach (VueloInternacional i in vuelo)
            {
                Console.WriteLine("El vuelo: " + i.RnumroV + " se dirige hacia " + i.Rdestino + " en el pais " + i.RpaisD + " el vuelo durara " + i.Rduracion + "h");
            }
            int auxV = vuelo[0].RnumroV, auxD = vuelo[0].Rduracion;
            foreach (VueloInternacional i in vuelo)
            {
                if (auxD < i.Rduracion)
                {
                    auxD = i.Rduracion;
                    auxV = i.RnumroV;
                }
            }
            Console.WriteLine("El vuelo de mayor duracion fue el N°" + auxV + " con una duracion de " + auxD + "h");
            Console.ReadKey();
        }
    }
}