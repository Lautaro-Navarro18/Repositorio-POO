using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Control de Vuelos 
    Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
    Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
    Agregar los siguientes métodos en la clase Vuelo:
    1) Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
    2) Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
    3) Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
    */
    class Pasajero
    {
        private string nombre;
        private int DNI;
        private float equipaje;
        public Pasajero()
        {
            Console.Write("Ingrese el nombre del pasajero: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el DNI de " + nombre + ": ");
            DNI = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso del equipaje en KG: ");
            equipaje = float.Parse(Console.ReadLine());
        }
        public string Rnombre()
        {
            return nombre;
        }
        public int RDNI()
        {
            return DNI;
        }
        public float Requipaje()
        {
            return equipaje;
        }
    }
    class Vuelo
    {
        private Pasajero[] pasajero;
        public Vuelo()
        {
            pasajero = new Pasajero[4];
            for (int i = 0; i < pasajero.Length; i++)
            {
                pasajero[i] = new Pasajero();
            }
        }
        void MostrarP()
        {
            for (int i = 0; i < pasajero.Length; i++)
            {
                Console.WriteLine(" El pasajero " + pasajero[i].Rnombre() + " tiene el DNI " + pasajero[i].RDNI() + " y el peso de su equipaje es de " + pasajero[i].Requipaje() + "kg");
            }
        }
        void PesoT()
        {
            float aux = 0;
            for (int i = 0; i < pasajero.Length; i++)
            {
                aux += pasajero[i].Requipaje();
            }
            Console.WriteLine("El peso total del equipaje es de " + aux + "kg");
        }
        void LimiteP()
        {
            for (int i = 0; i < pasajero.Length; i++)
            {
                if (pasajero[i].Requipaje() > 23)
                {
                    Console.WriteLine("El pasajero " + pasajero[i].Rnombre() + " con DNI " + pasajero[i].RDNI() + " se paso de vivo y excedio el limite de 23kg");
                }
            }
        }
        static void Main(string[] args)
        {
            Vuelo V = new Vuelo();
            V.MostrarP();
            V.PesoT();
            V.LimiteP();
            Console.ReadKey();
        }
    }
}
