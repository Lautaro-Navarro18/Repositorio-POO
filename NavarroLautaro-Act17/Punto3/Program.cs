using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Fábrica de Computadoras (Herencia y Constructores con base)
    Crear una clase base llamada Computadora que contenga los atributos Marca y MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente. 
    Luego, definir dos clases derivadas de la clase base:
    .Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
    .Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
    Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la clase 
    Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
    */
    public class Computadora
    {
        public Computadora(string marca, int memoRAM)
        {
            Console.WriteLine("Marca: " + marca + " memoria RAM: " + memoRAM + "GB");
        }
    }
    public class Notebook : Computadora
    {
        public Notebook(string marca, int memoRAM, double tamaP) : base(marca, memoRAM)
        {
            Console.WriteLine("Tamaño Pantalla: " + tamaP);
        }
    }
    public class Escritorio : Computadora
    {
        public Escritorio(string marca, int memoRAM, float potenF) : base(marca, memoRAM)
        {
            Console.WriteLine("Potencia Fuente: " + potenF + "W");
        }
        static void Main(string[] args)
        {
            Notebook notebook2 = new Notebook("ASUS", 32, 22.5);
            Escritorio escritorio2 = new Escritorio("ASUS", 64, 1200);
            Console.ReadKey();
        }
    }
}