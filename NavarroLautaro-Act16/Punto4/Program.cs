using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Armar tres clases: Animal, Mamífero y Perro.
    La clase Animal debe tener un atributo especie.
    La clase Mamífero, que hereda de Animal, debe tener un atributo tipoAlimentacion.
    La clase Perro, que hereda de Mamífero, debe tener un atributo nombre. 
    Cada clase debe tener un constructor que reciba los datos correspondientes y los imprima indicando a qué clase pertenecen. Los datos deben ser asignados previamente
    Crear un objeto de la clase Perro y verificar la ejecución en cadena de los constructores.
    */
    public class Animal
    {
        public string especie;
        public string Respecie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
        public Animal()
        {
            Console.Write("Ingrese la especie del animal: ");
            Respecie = Console.ReadLine();
            Console.WriteLine("La especie es: " + Respecie + " (Animal)");
        }
    }
    public class Mamifero : Animal
    {
        string tipoAli;
        public string RtipoAli
        {
            set
            {
                tipoAli = value;           /*  soluconar esto que esta mal hecho  */
            }
            get
            {
                return tipoAli;
            }
        }
        public Mamifero()
        {
            Console.Write("Ingrese el tipo de alimentacion ");
            RtipoAli = Console.ReadLine();
            Console.WriteLine("El tipo de alimento es: " + RtipoAli + " (Mamifero)");
        }
    }
    public class Perro : Mamifero
    {
        string nombre;
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
        public Perro()
        {
            Console.Write("Ingrese el nombre del perro: ");
            Rnombre = Console.ReadLine();
            Console.Write("El nombre es: " + Rnombre + " (Perro)");
        }
    }
    internal class Prueva
    {
        static void Main(string[] args)
        {
            Perro P = new Perro();
            Console.ReadKey();
        }
    }
}