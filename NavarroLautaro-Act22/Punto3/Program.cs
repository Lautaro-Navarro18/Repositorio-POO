using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    Actividad 3: Registro de entrenamientos
    Problema:
    Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
     Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
      1. Uno que reciba horas y minutos y los convierta a minutos.
      2. Otro que reciba directamente los minutos.
     Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el más corto. 
    */
    internal class Entrenamiento
    {
        public string deportista;
        public TimeSpan duracion;
        public Entrenamiento()
        {
            Console.Write("Ingrese el nombre del deportista: ");
            deportista = Console.ReadLine();
            Console.Write("Como va a ingresar el tiempo de entrenamiento? horas y minutos (HM) o solo minutos (M)? ");
            string opcion = Console.ReadLine();
            if(opcion == "HM")
            {
                Console.Write("Ingrese la cantidad de horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad de minutos: ");
                int minutos = int.Parse(Console.ReadLine());
                RegistrarDuracion(horas, minutos);
            }
            else if(opcion == "M")
            {
                Console.Write("Ingrese la cantidad de minutos: ");
                int minutos = int.Parse(Console.ReadLine());
                RegistrarDuracion(minutos);
            }
        }
        public void RegistrarDuracion(int horas, int minutos)
        {
            duracion = TimeSpan.FromMinutes((horas * 60) + minutos);
        }
        public void RegistrarDuracion(int minutos)
        {
            duracion = TimeSpan.FromMinutes(minutos);
        }
        static void Main(string[] args)
        {
            Entrenamiento[] entre = new Entrenamiento[3];
            for (int i = 0; i < entre.Length; i++)
            {
                entre[i] = new Entrenamiento();
            }
            TimeSpan auxL = entre[0].duracion, auxC = entre[0].duracion;
            for (int i = 0; i < entre.Length; i++)
            {
                if (auxL < entre[i].duracion)
                {
                    auxL = entre[i].duracion;
                }
                if (auxC > entre[i].duracion)
                {
                    auxC = entre[i].duracion;
                }
            }
            Console.WriteLine("El entrenamiento más largo dura " + auxL.TotalMinutes + " minutos.");
            Console.WriteLine("El entrenamiento más corto dura " + auxC.TotalMinutes + " minutos.");
            Console.ReadKey();
        }
    }
}
