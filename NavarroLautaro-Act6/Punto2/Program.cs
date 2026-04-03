using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
    class Cuadrado
    {
        private int lado;
        public void cargarValor()
        {
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());
        }
        public void perimetro()
        {
            Console.Write("El perimetro del cuadrado es de: " + (lado * 4) + "\n");
        }
        public void superficie()
        {
            Console.Write("La superficie es de: " + (lado * lado) + "\n");
        }
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.cargarValor();
            cuadrado.perimetro();
            cuadrado.superficie();
        }
    }
}