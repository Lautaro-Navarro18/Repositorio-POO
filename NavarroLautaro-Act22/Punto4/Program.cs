using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    Actividad 4: Gestión de vuelos
    Problema:
    Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
     Usar la palabra clave this en el constructor para diferenciar los parámetros de los atributos.
     Crear un método para calcular la duración del vuelo (TimeSpan).
     Cargar un vector con 4 vuelos y mostrar:
      1. El código y duración del vuelo más largo.
      2. El código del vuelo que salga más temprano. 
    */
    internal class Vuelo
    {
        private int codigo;
        private DateTime horaS;
        private DateTime horaLL;
        public Vuelo(int codigo, DateTime horaS, DateTime horaLL)
        {
            this.codigo = codigo;
            this.horaS = horaS;
            this.horaLL = horaLL;
        }
        public TimeSpan Duracion()
        {
            TimeSpan duracion = horaLL - horaS;
            return duracion;
        }
        static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[4];
            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.Write("Ingresa el codigo del vuelo: ");
                int vuelo = int.Parse(Console.ReadLine());
                Console.Write("Ingresa la hora de salida: ");
                DateTime horaS = DateTime.Parse(Console.ReadLine());
                Console.Write("Ingresa la hora de llegada: ");
                DateTime horaLL = DateTime.Parse(Console.ReadLine());

                vuelos[i] = new Vuelo(vuelo, horaS, horaLL);
            }
            TimeSpan auxMa = vuelos[0].Duracion();
            int auxI = 0;
            for (int i = 0; i < vuelos.Length; i++)
            {
                if (vuelos[i].Duracion() > auxMa)
                {
                    auxMa = vuelos[i].Duracion();
                    auxI = i;
                }
            }
            Console.WriteLine("El vuelo " + vuelos[auxI].codigo + " es el vuelo mas largo, ya que dura " + auxMa);
            DateTime auxMe = vuelos[0].horaS;
            auxI = 0;
            for (int k = 0; k < vuelos.Length; k++)
            {
                if (auxMe > vuelos[k].horaS)
                {
                    auxMe = vuelos[k].horaS;
                    auxI = k;
                }
            }
            Console.WriteLine("El vuelo " + vuelos[auxI].codigo + " es el vuelo que mas temprano sale, ya que sale a las " + auxMe);
            Console.ReadKey();
        }
    }
}
