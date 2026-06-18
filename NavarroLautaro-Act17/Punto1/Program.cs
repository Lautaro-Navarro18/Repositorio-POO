using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Personal de un Gimnasio (Herencia Simple y Propiedades) 
    Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un método para imprimir estos datos básicos.
    Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método para imprimir todos los datos del profesor 
    (incluyendo los heredados).
    En el programa principal (Main):
    . Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y llamar a su método de impresión.
    . Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar que puede acceder tanto a sus métodos propios como a los de la clase base.
     */
    public class PersonaGimnasio
    {
        private string nombre;
        private int DNI;
        public string Rnombre
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
        public int RDNI
        {
            set
            {
                DNI = value;
            }
            get
            {
                return DNI;
            }
        }
        public void Mostrar()
        {
            Console.WriteLine("El nombre de la persona es " + nombre + " y su DNI es " + DNI);
        }
    }
    public class Profesor : PersonaGimnasio
    {
        private string especialidad;
        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }
        public Profesor()
        {
            Console.Write("Ingrese la especialidad de " + Rnombre + " ");
            especialidad = Console.ReadLine();
        }
        public void MostrarS()
        {
            Console.Write("El profesor " + Rnombre + " tiene el DNI " + RDNI + " y su especialidad es " + especialidad);
        }
    }
    internal class Prueba
    {
        static void Main(string[] args)
        {
            PersonaGimnasio pg = new PersonaGimnasio();
            pg.Rnombre = "Antonito";
            pg.RDNI = 4713249;
            pg.Mostrar();
            Profesor p = new Profesor();
            p.Rnombre = "Enel";
            p.RDNI = 2903456;
            p.Especialidad = "Musculacion";
            p.MostrarS();
            Console.ReadKey();
        }
    }
}
