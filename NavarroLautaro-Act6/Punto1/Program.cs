
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Plano
    {
        /*Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
         * encuentra dicho punto(concepto matemático, primer cuadrante si x e y son positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)*/
        private int x, y;
        public void cargarDatos()
        {
            Console.WriteLine("Ingresa un valor de x ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa un valor de y: ");
            y = int.Parse(Console.ReadLine());
        }

        public void calcularCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El cuadrante en el que esan estas coordenadas es el primero");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("El cuadrante en el que esan estas coordenadas es el segundo");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("El cuadrante en el que esan estas coordenadas es el tercero");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("El cuadrante en el que esan estas coordenadas es el cuarto");
            }
        }

        static void Main(string[] args)
        {
            Plano plano = new Plano();
            plano.cargarDatos();
            plano.calcularCuadrante();
            Console.ReadKey();
        }
    }
}