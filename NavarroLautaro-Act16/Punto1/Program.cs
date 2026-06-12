using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
     1. Confeccionar una clase Persona que tenga como atributos el nombre y la edad (definir las propiedades para poder acceder a dichos atributos). Definir un método para imprimirlos. 
        Plantear una segunda clase Empleado que herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo. 
        Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.
    */
    public class Persona
    {
        protected string nombre;
        protected int edad;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public Persona()
        {
            Console.Write("Ingrese nombre y edad ");
            nombre = Console.ReadLine();
            edad = int.Parse(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.WriteLine(nombre + " tiene una edad de " + edad + " años");
        }
    }
    public class Empleado : Persona
    {
        private float sueldo;
        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        public Empleado()
        {
            Console.Write("Ingrese el sueldo de " + nombre + " ");
            sueldo = float.Parse(Console.ReadLine());
        }
        public void MostrarS()
        {
            Console.WriteLine("El sueldo es de " + sueldo);
        }
    }
    internal class Prueba
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            /*p.Nombre = "Antonio";
            p.Edad = 25;*/
            p.Mostrar();
            Empleado e = new Empleado();
            /*e.Sueldo = 152;
            e.MostrarS();*/
            Console.ReadKey();
        }
    }
}