using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Catálogo de Películas (Encapsulación, Validación y Composición)
    Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
    La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion (un puntaje del 1 al 5). 
    Definir las propiedades necesarias para acceder a estos atributos, asegurando mediante validaciones lógicas que:
  . La duración en minutos sea estrictamente mayor a cero (0). |
  . La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar un valor por defecto de 1). |
    La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las películas ordenadas 
    de mayor a menor en base a su duración. Además, el método debe informar el título de la película con mejor calificación y cuál es la película más corta del catálogo.
    */
    public class Pelicula
    {
        private string titulo;
        private float duracionM, cali;
        public Pelicula()
        {
            Console.Write("Ingrese el nombre de la pelicula: ");
            titulo = Console.ReadLine();
            Console.Write("Ingrese la duración de la pelicula en minutos: ");
            duracionM = float.Parse(Console.ReadLine());
            while (duracionM <= 0)
            {
                Console.Write("La duración debe ser mayor a cero, ingrese nuevamente la duración de la pelicula en minutos: ");
                duracionM = float.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese la calificación de la pelicula (1-5): ");
            cali = float.Parse(Console.ReadLine());
            if (cali < 1 || cali > 5)
            {
                cali = 1;
            }
        }
        public string Rtitulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }
        public float RduracionM
        {   
            set
            {
                duracionM = value;
            }
            get
            {
                return duracionM;
            }
        }
        public float Rcali
        {
            set
            {
                cali = value;
            }
            get
            {
                return cali;
            }

        }
    }
    public class Catalogo
    {
        private Pelicula[] peli = new Pelicula[3];
        public Catalogo()
        {
            for (int i = 0; i < peli.Length; i++)
            {
                Console.WriteLine("Película " + (i + 1));
                peli[i] = new Pelicula();
            }
        }
        public void MostrarT()
        {
            float auxD = 0, auxC;
            string auxT;
            int auxI = 0;
            for (int i = 0; i < peli.Length; i++)
            {
                for (int j = 0; j < peli.Length - 1; j++)
                {
                    if (peli[j].RduracionM < peli[j + 1].RduracionM)
                    {
                        auxD = peli[j].RduracionM;
                        peli[j].RduracionM = peli[j + 1].RduracionM;
                        peli[j + 1].RduracionM = auxD;
                        auxC = peli[j].Rcali;
                        peli[j].Rcali = peli[j + 1].Rcali;
                        peli[j + 1].Rcali = auxC;
                        auxT = peli[j].Rtitulo;
                        peli[j].Rtitulo = peli[j + 1].Rtitulo;
                        peli[j + 1].Rtitulo = auxT;
                    }
                }
            }
            for (int i = 0; i < peli.Length; i++)
            {
                Console.WriteLine("La película " + peli[i].Rtitulo + " tiene una duración de " + peli[i].RduracionM + " minutos y una calificación de " + peli[i].Rcali);
            }
            float mayor = peli[0].Rcali;
            for (int i = 0; i < peli.Length; i++)
            {
                if (mayor < peli[i].Rcali)
                {
                    mayor = peli[i].Rcali;
                    auxI = i;
                }
            }
            Console.WriteLine("La película con mejor calificación es " + peli[auxI].Rtitulo + " con una calificación de " + peli[auxI].Rcali);
            Console.Write("La pelicula mas corta es " + peli[peli.Length -1].Rtitulo + " con " + peli[peli.Length -1].RduracionM + "m");
        }
    }
    internal class Prueba
    {
        static void Main(string[] args)
        {
            Catalogo c = new Catalogo();
            c.MostrarT();
            Console.ReadKey();
        }
    }
}
