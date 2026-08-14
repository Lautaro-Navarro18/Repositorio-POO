using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    10/4 Un estacionamiento medido administra el ingreso y la salida de los vehículos que utilizan su playa por orden de llegada.
          Crear la clase Ticket que contenga como atributos privados: patente (string) y horasEstadia (int). Definir sus propiedades de solo lectura y un constructor que reciba pat y hs.
          Crear la clase GestionEstacionamiento que administre una lista dinámica de tickets (List).
          Métodos en GestionEstacionamiento:
           o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y agregarlo al final de la lista utilizando .Add().
           o ProcesarSalida(): Si la lista no está vacía, simular la salida del primer vehículo de la lista (mostrar sus datos en consola) y removerlo de la colección mediante 
             .RemoveAt(0). Si está vacía, advertir que no hay vehículos esperando salida.
           o MostrarVehiculosEstacionados(): Listar todos los vehículos alojados en la playa y la cantidad total de unidades presentes utilizando la propiedad .Count. 
    */
    public class Ticket
    {
        private string patente;
        private int horasEstadia;
        public Ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
        public string Patente { get { return patente; } }
        public int HorasE { get { return horasEstadia; } }
    }
    public class GestionEstacionamento
    {
        List<Ticket> estacio = new List<Ticket>();
        public void RegistrarIngreso()
        {
            Console.Write("¿Ingreso algun auto? ");
            string aux = Console.ReadLine();
            if (aux == "SI" || aux == "Si" || aux == "si")
            {
                bool auxM = true;
                while (auxM)
                {
                    Console.Write("Ingrese la patente del auto: ");
                    string patente = Console.ReadLine();
                    Console.Write("Ingrese las horas de estancia: ");
                    int hs = int.Parse(Console.ReadLine());
                    estacio.Add(new Ticket(patente, hs));
                    Console.Write("¿Ingreso otro auto? ");
                    string auxA = Console.ReadLine();
                    if (auxA == "SI" || auxA == "Si" || auxA == "si")
                    {
                        continue;

                    }
                    else if (auxA == "NO" || auxA == "No" || auxA == "no")
                    {
                        break;
                    }
                    auxM = false;
                }
            }
            else if (aux == "NO" || aux == "No" || aux == "no")
            {
                Console.WriteLine("Que inicio de sesion innecesario");
            }
            Console.WriteLine();
        }
        public void ProcesarSalida()
        {
            if (estacio.Count > 0)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("El auto con patente " + estacio[0].Patente + " se retiro");
                Console.WriteLine("Estubo " + estacio[0].HorasE + "h");
                Console.WriteLine("=====================================");
                estacio.RemoveAt(0);
            }
            else { Console.WriteLine("No se pudo borrar la nada por raro que suene"); }
        }
        public void MostrarVehiculosEstacionados() 
        {
            foreach (var i in estacio)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("El autocon patente: " +i.Patente);
                Console.WriteLine("Estubo " + i.HorasE + "h dentro");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("La cantidad total de autos estacionados actualmente es de " + estacio.Count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionEstacionamento GE = new GestionEstacionamento();
            GE.RegistrarIngreso();
            GE.ProcesarSalida();
            GE.MostrarVehiculosEstacionados();
            Console.ReadKey();
        }
    }
}
