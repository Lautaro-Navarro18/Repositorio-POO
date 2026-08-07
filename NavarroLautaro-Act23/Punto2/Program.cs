using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2 Una empresa de logística autónoma monitorea el estado y nivel de batería de sus drones de entrega en vuelo de regreso a la base.
         Crear la clase Dron que contenga los atributos privados: codigo (string) y nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes. 
          Su constructor debe recibir cod y bat.
         Crear la clase CentroControl que administre una lista de objetos List<Dron>.
         Métodos en CentroControl:
          1. Un constructor que cargue por teclado una lista inicial de 4 drones ingresando sus códigos y baterías.
          2. ListarFlota(): Mostrar la lista de drones en pantalla.
          3. RemoverDronesBajos(): Recorrer la lista y remover por completo de la flota a todos aquellos drones cuyo nivel de batería sea menor o igual al 15% 
             (ya que requieren mantenimiento automático urgente).
          4. MostrarDronesRestantes(): Imprimir la flota actualizada y la cantidad de drones operativos utilizando la propiedad .Count. 
    */
    public class Dron
    {
        public string codigo;
        public int nivelBate;
        public Dron(string codigo, int nivelBate)
        {
            this.codigo = codigo;
            this.nivelBate = nivelBate;
        }
    }
    public class CentroControl
    {
        List<Dron> dron = new List<Dron>();
        public CentroControl()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.Write("Ingrese el codigo del dron ");
                string codigo = Console.ReadLine();
                Console.Write("Ingrese el porcenteje de bateria del dron ");
                int nivelBate = int.Parse(Console.ReadLine());
                if (nivelBate >= 0 && nivelBate <= 100)
                {
                    Dron newDron = new Dron(codigo, nivelBate);
                    dron.Add(newDron);
                }
                else
                {
                    Console.WriteLine("Se ingreso un porcentaje que no es posible fisicamente, volve a hacerlo");
                    i--;
                }
            }
        }
        public void ListarFlota()
        {
            Console.Clear();
            foreach (var i in dron)
            {
                Console.WriteLine("<===========================>");
                Console.WriteLine("DRON: " + i.codigo);
                Console.WriteLine("PORCENTAJE DE BATERIA: " + i.nivelBate);
                Console.WriteLine("<===========================>");
            }
        }
        public void RemoverDronesBajos()
        {
            dron.RemoveAll(i => i.nivelBate <= 15);
            Console.WriteLine("Se mandaron a mantenimiento aquellos drones que tenian 15 o menos bateria");
        }
        public void MostrarDronesRestantes()
        {
            Console.Clear();
            int active = 0;
            foreach (var i in dron)
            {
                Console.WriteLine("<===========================>");
                Console.WriteLine("DRON: " + i.codigo);
                Console.WriteLine("PORCENTAJE DE BATERIA: " + i.nivelBate);
                Console.WriteLine("<===========================>");
            }
            active = dron.Count;
            Console.Write("La cantidad activa de drones actualmente es de " + active);            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CentroControl CC = new CentroControl();
            CC.ListarFlota();
            CC.RemoverDronesBajos();
            CC.MostrarDronesRestantes();
            Console.ReadKey();
        }
    }
}  //ta piola para entregar
