using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Puntos
    {
        //3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de un videojuego.El programa debe: 
        //Mostrar la puntuación más alta y la más baja.
        //Calcular el promedio de puntuación.
        //Contar cuántas veces superó los 500 puntos.
        private int[] puntuacion;
        void CargarValores()
        {
            puntuacion = new int[6];
            Console.Write("Agregue los puntajes: \n");
            for(int i = 0; i < puntuacion.Length; i++)
            {
                puntuacion[i] = int.Parse(Console.ReadLine());
            }
        }
        void AltoBajo()
        {
            int max=0, min=puntuacion[0];
            for(int i=0; i<puntuacion.Length; i++)
            {
                if (puntuacion[i] > max)
                {
                    max = puntuacion[i];
                }
                if (puntuacion[i] < min)
                {
                    min = puntuacion[i];
                }
            }
            Console.Write("El valor mas alto es: " + max + " y el mas bajo es: " + min);
        }
        void Promedio()
        {
            int suma = 0;
            float promedio = 0;
            for(int i = 0; i<puntuacion.Length; i++)
            {
                suma = suma + puntuacion[i];
            }
            promedio = suma / puntuacion.Length;
            Console.Write("\nEl promedio del puntaje es de: " + promedio);
        }
        void Mayor500()
        {
            int cont=0;
            for(int i=0; i<puntuacion.Length; i++)
            {
                if (puntuacion[i] > 500)
                {
                    cont++;
                }
            }
            Console.Write("\n"+ cont + " veces tuviste una puntuacion mayor a 500");
        }
        static void Main(string[] args)
        {
            Puntos p = new Puntos();
            p.CargarValores();
            p.AltoBajo();
            p.Promedio();
            p.Mayor500();
            Console.ReadKey();
        }
    }
}
