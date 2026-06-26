using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        private string nombreJ;
        public string RnombreJ
        {
            set
            {
                nombreJ = value;
            }
            get
            {
                return nombreJ;
            }
        }
        private int puntajeM;
        public int RpuntajeM
        {
            set
            {
                puntajeM = value;
            }
            get
            {
                return puntajeM;
            }
        }
        private int nivelDifi;
        public int RnivelDifi
        {
            set
            {
                if (value > 0 && value < 6)
                {
                    nivelDifi = value;
                }
                else
                {
                    Console.WriteLine("Ingresar una dificultad entre 1 y 5");
                }
            }
            get
            {
                return nivelDifi;
            }
        }
        public JuegoArcade()
        {
            Console.Write("Ingresar nombre del juego: ");
            RnombreJ = Console.ReadLine();
            Console.Write("Ingresar puntaje maximo de " + RnombreJ + ": ");
            RpuntajeM = int.Parse(Console.ReadLine());
            Console.Write("Ingresar dificultad(1-5): ");
            RnivelDifi = int.Parse(Console.ReadLine());
        }
    }
}