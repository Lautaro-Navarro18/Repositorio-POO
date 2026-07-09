using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*
    Actividad 5: Gestión de Carreras Deportivas
    Consigna:
    Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código, una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
    Se pide:
    1. Crear una clase Carrera con:
      o Atributos: código, hora de inicio, hora de fin y lista de corredores ya definidos.
      o Dos constructores (uno por defecto y otro con parámetros).
      o Método para calcular la duración de la carrera usando TimeSpan.
    2. Crear una clase Corredor con:
      o Atributos: nombre, número de dorsal y tiempo total.
      o Sobrecarga de métodos para registrar el tiempo total (en minutos o en horas y minutos).
    3. Mostrar en consola (usando Console.SetCursorPosition()):
      o La carrera con mayor duración.
      o El corredor más rápido.
    4. Utilizar this en los constructores o métodos donde corresponda. 
    */
    internal class Carrera
    {
        private int codigo;
        private DateTime horaI;
        private DateTime horaF;
        List<Corredor> listaCorredores = new List<Corredor>();
        public Carrera()
        {
            Console.Write("Ingrese el codigo de la carrera: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la hora de inicio: ");
            horaI = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese la hora de fin: ");
            horaF = DateTime.Parse(Console.ReadLine());
        }
        public Carrera(int codigo, DateTime horaI, DateTime horaF)
        {
            this.codigo = codigo;
            this.horaI = horaI;
            this.horaF = horaF;
        }
        public int Codigo()
        {
            return codigo;
        }
        public TimeSpan Duracion()
        {
            return horaF - horaI;
        }
        public void AgregarCorredor(Corredor corredor)
        {
            listaCorredores.Add(corredor);
        }
    }
    internal class Corredor
    {
        private string nombre;
        private int numeroD;
        private TimeSpan tiempoT;
        public Corredor(string nombre, int numeroD)
        {
            this.nombre = nombre;
            this.numeroD = numeroD;
        }
        public string Nombre()
        {
            return nombre;
        }
        public void RegistrarTiempo(int minutos)
        {
            tiempoT = TimeSpan.FromMinutes(minutos);
        }
        public TimeSpan Tiempo()
        {
            return tiempoT;
        }
        public void RegistrarTiempo(int horas, int minutos)
        {
            tiempoT = new TimeSpan(horas, minutos, 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carrera carrera1 = new Carrera(1, new DateTime(2026, 7, 3, 7, 45, 00), new DateTime(2026, 7, 3, 12, 05, 00));
            Corredor c1 = new Corredor("Alfajore", 1);
            c1.RegistrarTiempo(15);
            carrera1.AgregarCorredor(c1);
            Corredor c2 = new Corredor("Empanadas", 15);
            c2.RegistrarTiempo(16);
            carrera1.AgregarCorredor(c2);
            Corredor c3 = new Corredor("Motorola", 1972);
            c3.RegistrarTiempo(23);
            carrera1.AgregarCorredor(c3);
            Corredor c4 = new Corredor("Ford_Falcon_Rural_79", 18);
            c4.RegistrarTiempo(4);
            carrera1.AgregarCorredor(c4);
            Carrera carrera2 = new Carrera(2, new DateTime(2026, 7, 3, 10, 00, 00), new DateTime(2026, 7, 3, 15, 00, 00));
            Corredor c5 = new Corredor("Antonito", 3);
            c5.RegistrarTiempo(64);
            carrera2.AgregarCorredor(c5);
            Corredor c6 = new Corredor("Mondongo", 7);
            c6.RegistrarTiempo(34);
            carrera2.AgregarCorredor(c6);
            Corredor c7 = new Corredor("Takamura", 198);
            c7.RegistrarTiempo(9);
            carrera2.AgregarCorredor(c7);
            Corredor c8 = new Corredor("Guiso_Lentejas", 19);
            c8.RegistrarTiempo(71);
            carrera2.AgregarCorredor(c8);
            Carrera[] carreras = new Carrera[2];
            carreras[0] = carrera1;
            carreras[1] = carrera2;
            Corredor[] corredores = new Corredor[8];
            corredores[0] = c1;
            corredores[1] = c2;
            corredores[2] = c3;
            corredores[3] = c4;
            corredores[4] = c5;
            corredores[5] = c6;
            corredores[6] = c7;
            corredores[7] = c8;
            Carrera auxMa = carreras[0];
            int auxI = 0;
            for (int i = 0; i < carreras.Length; i++)
            {
                if (carreras[i].Duracion() > auxMa.Duracion())
                {
                    auxMa = carreras[i];
                    auxI = i;
                }
            }
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("La carrera con mayor duracion es la " + auxMa.Codigo() + " con " + auxMa.Duracion());
            Corredor auxMe = corredores[0];
            for (int i = 0; i < corredores.Length; i++)
            {
                if (auxMe.Tiempo() > corredores[i].Tiempo())
                {
                    auxMe = corredores[i];
                }
            }
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("El corredor mas rapido es " + auxMe.Nombre() + " que tiene un tiempo de " + auxMe.Tiempo());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
