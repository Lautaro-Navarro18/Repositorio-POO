using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    /*
    6 Una biblioteca pública gestiona de forma digital su catálogo de obras literarias para organizar la consulta de ejemplares por parte de los lectores.
        Crear la clase Libro que contenga como atributos privados: titulo (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y un constructor que reciba tit y anio.
        Crear la clase BibliotecaCentral que administre una lista de objetos List.
        Métodos en BibliotecaCentral:
        1. CargarCatalogo(): Solicitar por teclado títulos y años de publicación para agregar libros a la lista mediante .Add(). La carga finaliza cuando el usuario ingresa la palabra "FIN" como título.
        2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo junto a la cantidad total de obras registradas mediante la propiedad .Count.
        3. FiltrarPorAnio(): Solicitar al usuario un año determinado e imprimir en consola únicamente aquellos libros cuyo año de publicación sea menor a dicho valor.
        4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando los métodos de búsqueda y remoción de listas, eliminarlo de la colección si se encuentra presente.
    */
    public class Libro 
    {
        private string titulo;
        private int aniopublicacion;
        public Libro(string tit, int anio)
        {
            titulo = tit;
            aniopublicacion = anio;
        }
        public string Titulo { get { return titulo; } }
        public int AnioPublicacion { get { return aniopublicacion; } }
    }
    public class BibliotecaCentral
    {
        List<Libro> libros = new List<Libro>();
        public void CargarCatalogo()
        {
            bool auxF = true;
            while (auxF)
            {
                Console.Write("Ingrese el nombre del libro (ingresar FIN/Fin/fin para finalizar): ");
                string titulo = Console.ReadLine();
                if (titulo == "FIN" || titulo == "Fin" || titulo == "fin")
                {
                    auxF = false;
                }
                else
                {
                    Console.Write("Ingrese el año de publicación: ");
                    int aniopublicacion = int.Parse(Console.ReadLine());
                    libros.Add(new Libro(titulo, aniopublicacion));
                }
            }
        }
        public void ListarCatalogo()
        {
            Console.WriteLine("Libros en el catalogo:");
            foreach (var libro in libros)
            {
                Console.WriteLine("Título: " + libro.Titulo + ", Año de publicación: " + libro.AnioPublicacion);
            }
            Console.WriteLine("Cantidad total de obras registradas: " + libros.Count);
        }
        public void FiltrarPorAnio()
        {
            Console.Write("Ingrese el año limite de la busqueda: ");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Libros publicados antes del año " + anio + ":");
            foreach (var libro in libros)
            {
                if (libro.AnioPublicacion < anio)
                {
                    Console.WriteLine("Título: " + libro.Titulo + ", Año de publicación: " + libro.AnioPublicacion);
                }
            }
        }
        public void RemoverLibro()
        {
            Console.Write("Ingrese el título del libro a eliminar: ");
            string titulo = Console.ReadLine();
            if(titulo == "NO" || titulo == "No" || titulo == "no")
            {
                Console.WriteLine("No se eliminara ningun libro");
                return;
            }
            Console.Clear();
            libros.RemoveAll(i => i.Titulo == titulo);
            ListarCatalogo();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BibliotecaCentral BC = new BibliotecaCentral();
            BC.CargarCatalogo();
            BC.ListarCatalogo();
            BC.FiltrarPorAnio();
            BC.RemoverLibro();
        }
    }
}
