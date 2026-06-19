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
        public Vehiculo(string marca, int veloM)
        {
            Console.Write("El vehiculo de la marca " + marca + " tiene una velocidad maxima de " + veloM + "Kmh");
        }
    }
    public class Auto : Vehiculo
    {
        public Auto(string marca, int veloM, int cantP) : base(marca, veloM)
        {
            Console.WriteLine(" y dicho auto tiene " + cantP + " puertas");
        }
    }
    public class Moto : Vehiculo
    {
        public Moto(string marca, int veloM, int cili) : base(marca, veloM)
        {
            Console.WriteLine(" y dicha moto tiene " + cili + "cm³ de cilindrada");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto("Ford", 342, 2);
            Moto m = new Moto("Kawasaki", 400, 998);
            Console.ReadKey();
        }
    }
}