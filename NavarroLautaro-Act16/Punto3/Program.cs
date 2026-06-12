using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Crear una clase base Vehículo que contenga atributos marca y velocidadMaxima.
    Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada una debe tener un constructor que reciba los valores de los atributos base mediante la palabra clave base, 
    y un atributo propio (cantidadPuertas en Auto, cilindrada en Moto). 
    Crear un objeto de cada clase y mostrar todos sus datos por consola.
    */
    public class Vehiculo
    {
        protected string marca;
        protected int veloM;
        public string Rmarca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        public int RveloM
        {
            set
            {
                veloM = value;
            }
            get
            {
                return veloM;
            }
        }
    }
    public class Auto : Vehiculo
    {
        int cantPu;
        public int RcantPu
        {
            set
            {
                cantPu = value;
            }
            get
            {
                return cantPu;
            }
        }
        public Auto()
        {
            Console.WriteLine("Ingrese los datos del vehiculo: ");
            Console.Write("Ingrese la marca: ");
            Rmarca = Console.ReadLine();
            Console.Write("Ingrese la velocidad maxima: ");
            RveloM = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantida de puertas del auto: ");
            RcantPu = int.Parse(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.WriteLine("El auto de marca " + Rmarca + " tiene una velocidad maxima de " + RveloM + " y con esta cantida de puertas " + RcantPu);
        }
    }
    public class Moto : Vehiculo
    {
        int cilin;
        public int Rcilin
        {
            set
            {
                cilin = value;
            }
            get
            {
                return cilin;
            }
        }
        public Moto()
        {
            Console.WriteLine("Ingrese los datos del vehiculo: ");
            Console.Write("Ingrese la marca: ");
            Rmarca = Console.ReadLine();
            Console.Write("Ingrese la velocidad maxima: ");
            RveloM = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cilindrada: ");
            Rcilin = int.Parse(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.WriteLine("La moto de marca " + Rmarca + " tiene una velocidad maxima de " + RveloM + " y con esta cilindrada " + Rcilin);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto A = new Auto();
            Moto M = new Moto();
            Console.ReadKey();
        }
    }
}