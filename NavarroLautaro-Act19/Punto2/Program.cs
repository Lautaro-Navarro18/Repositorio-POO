using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Crear una clase parcial Libro.
    En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
    cantidad de páginas sea mayor a 10. Valores cargados desde consola
    En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
    si el libro es corto (menos de 100 páginas) o largo.
    Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso. 
    */
    internal class Cargar
    {
        Libro[] libro = new Libro[2];
        public Cargar()
        {
            for (int i = 0; i < libro.Length; i++)
            {
                libro[i] = new Libro();
            }
        }
        public void MasE()
        {
            int largo = libro[0].Rpaginas;
            int pos = 0;
            for (int i = 0; i < libro.Length; i++)
            {
                if (libro[i].Rpaginas > largo)
                {
                    largo = libro[i].Rpaginas;
                    pos = i;
                }
            }
            Console.Write("El libro mas largo es: " + libro[pos].Rtitulo + " con " + largo + " paginas");
        }
        public void MostrarR()
        {
            for (int i = 0; i < libro.Length; i++)
            {
                libro[i].Resumen();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Cargar c = new Cargar();
            c.MostrarR();
            c.MasE();
        }
    }
}