using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. El Sistema de Peaje.
    Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje. La clase Vehiculo debe tener los siguientes atributos privados:
    Patente (de tipo string).
    Tipo (puede ser "Auto", "Camion" o "Moto").
    Tarifa (un valor decimal que representa el costo de su pase).
    El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado. La clase CabinaPeaje debe tener como atributos privados:
    El número o identificador de la cabina.
    Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
    Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
    1.Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
    2.Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
    3.Un método que muestre la patente del vehículo que pagó la tarifa más cara.
    */
    class Vehiculo
    {
        private string patente;
        private string tipo;
        private float tarifa;
        public Vehiculo()
        {
            Console.Write("Ingrese la patente del vehiculo: ");
            patente = Console.ReadLine();
            Console.Write("Ingrese el tipo de vehiculo (auto, camion, moto): ");
            tipo = Console.ReadLine();
            Console.Write("Ingrese el importe de la tarifa: ");
            tarifa = float.Parse(Console.ReadLine());
        }
        public string Patente()
        {
            return patente;
        }
        public string Tipo()
        {
            return tipo;
        }
        public float Tarifa()
        {
            return tarifa;
        }
    }
    class CabinaPeaje
    {
        private int idPeaje;
        private Vehiculo[] vehi;
        public CabinaPeaje()
        {
            vehi = new Vehiculo[3];
            Console.Write("Ingrese el codigo del peaje: ");
            idPeaje = int.Parse(Console.ReadLine());
            for (int i = 0; i < vehi.Length; i++)
            {
                vehi[i] = new Vehiculo();
            }
        }
        void Imprimir()
        {
            for (int i = 0; i < vehi.Length; i++)
            {
                Console.Write(" Esta es la patente del vehiculo " + vehi[i].Tipo() + " es " + vehi[i].Patente());
            }
        }
        void CantTotal()
        {
            float cant = 0;
            for (int i = 0; i < vehi.Length; i++)
            {
                cant += vehi[i].Tarifa();
            }
            Console.WriteLine("La cantidad recaudada total es: " + cant);
        }
        void QuienPM()
        {
            int aux = 0;
            for (int i = 0; i < vehi.Length - 1; i++)
            {
                if (vehi[i].Tarifa() > vehi[i + 1].Tarifa())
                {
                    aux = i;
                }
                else
                {
                    aux = i + 1;
                }
            }
            Console.WriteLine("El vehiculo " + vehi[aux].Patente() + " fue el que mas pago con: " + vehi[aux].Tarifa());
        }
        static void Main(string[] args)
        {
            CabinaPeaje CaPe = new CabinaPeaje();
            CaPe.Imprimir();
            CaPe.CantTotal();
            CaPe.QuienPM();
            Console.ReadKey();
        }
    }
}