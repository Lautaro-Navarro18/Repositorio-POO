using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3 Un centro de conservación marina registra de forma dinámica las especies de mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
        Crear la clase MonitoreoCostero que contenga como atributo privado una lista de cadenas de texto List<string> especiesDetectadas.
        Métodos en MonitoreoCostero:
        1. CargarAvistamientos(): Solicitar por teclado nombres de especies marinas avistadas (ej: "Ballena Franca", "Lobo Marino", "Delfín") y agregarlos a la lista utilizando .Add(). 
           La carga finaliza cuando el usuario ingresa la palabra "FIN".
        2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos organizada alfabéticamente de la A a la Z utilizando el método .Sort().
        3. MostrarReporteInvertido(): Imprimir la lista organizada de la Z a la A combinando .Sort() con el método .Reverse().
        4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un animal y, utilizando los métodos de búsqueda de listas, informar si la especie fue divisada en la 
           costa durante el día. 
    */
    public class MonitoreoCostero
    {
        List<string> especiesDetectadas = new List<string>();
        public void CargarAvistamientos()
        {
            bool auxF = true;
            while (auxF)
            {
                Console.Write("Ingrese el nombre del animal avistado: ");
                string auxN = Console.ReadLine();
                if(auxN == "FIN" || auxN == "Fin" || auxN == "fin")
                {
                    auxF = false;
                }
                else
                {
                    especiesDetectadas.Add(auxN);
                }
            }
        }
        public void MostrarReporteOrdenado()
        {
            especiesDetectadas.Sort();
            foreach (var i in especiesDetectadas)
            {
                Console.WriteLine("------------");
                Console.WriteLine(i);
                Console.WriteLine("------------");
            }
        }
        public void MostrarReporteInvertido()
        {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();
            foreach (var i in especiesDetectadas)
            {
                Console.WriteLine("------------");
                Console.WriteLine(i);
                Console.WriteLine("------------");
            }
        }
        public void BuscarEspecie()
        {
            Console.WriteLine("Ingrese la especie buscada: ");
            string auxN = Console.ReadLine();
            foreach (var i in especiesDetectadas)
            {
                if (auxN == i)
                {
                    Console.Write("El animal " + auxN + " fue avistado durnate el dia");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MonitoreoCostero MC = new MonitoreoCostero();
            MC.CargarAvistamientos();
            MC.MostrarReporteOrdenado();
            MC.MostrarReporteInvertido();
            MC.BuscarEspecie();
            Console.ReadKey();
        }
    }
} //ta redy pa entregaar