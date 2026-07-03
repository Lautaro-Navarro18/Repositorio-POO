using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    Actividad 2: Posicionamiento de elementos en consola
    Problema:
    Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
     Implementar propiedades y un constructor que cargue valores.
     Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el nombre en pantalla y Console.CursorVisible para ocultar el cursor.
     Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la consola. 
    */
    internal class ElementosPantalla
    {
        public string nombre;
        public int posX, posY;
        public ElementosPantalla()
        {
            Console.Write("Ingrese el nombre del elemento: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la posicion X del elemento: ");
            posX = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la posicion Y del elemento: ");
            posY = int.Parse(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.SetCursorPosition(posX, posY);
            Console.CursorVisible = false;
            Console.WriteLine(nombre);
        }
        static void Main(string[] args)
        {
            ElementosPantalla[] ele = new ElementosPantalla[4];
            int f = 0;
            for (int i = 0; i < ele.Length; i++)
            {
                Console.SetCursorPosition(0, f);
                ele[i] = new ElementosPantalla();
                ele[i].Mostrar();
                f += 3;
            }
            Console.ReadLine();
        }
    }
}
