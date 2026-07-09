using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private string deportista;
        private TimeSpan duracion;
        public void RegistrarDuracion(int horas, int minutos)
        {
            duracion = new TimeSpan(horas, minutos, 0);
            Console.WriteLine(duracion + " en horas");
        }
        public void RegistrarDuracion(int minutos)
        {
            duracion = TimeSpan.FromMinutes(minutos);
            Console.WriteLine(duracion + " minutos");
        }
        public Entrenamiento()
        {
            Console.Write("Ingresa el nombre del deportista: ");
            deportista = Console.ReadLine();
            Console.Write("Ingresa cuantos minutos duro su entrenamiento: ");
            int minutos = int.Parse(Console.ReadLine());
            RegistrarDuracion(minutos);
        }
        static void Main(string[] args)
        {
            Entrenamiento[] train = new Entrenamiento[5];
            for (int i = 0; i < train.Length; i++)
            {
                train[i] = new Entrenamiento();
            }
            TimeSpan auxMa = train[0].duracion;
            int auxI = 0;
            TimeSpan auxMe = train[0].duracion;
            for (int i = 0; i < train.Length; i++)
            {
                if (auxMe > train[i].duracion)
                {
                    auxMe = train[i].duracion;
                    auxI = i;
                }
            }
            Console.WriteLine("El entrenamiento con menor duracion es de " + auxMe + " minutos ");
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].duracion > auxMa)
                {
                    auxMa = train[i].duracion;
                    auxI = i;
                }
            }
            Console.WriteLine("El entrenamiento con mayor duracion es de " + auxMa + " minutos ");
            Console.ReadKey();
        }
    }
}
