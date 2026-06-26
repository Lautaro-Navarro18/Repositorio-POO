using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    Actividad 2: Administración de entregas logísticas
    Problema:
    Una empresa de envíos desea registrar sus entregas mediante colaboración de clases.
    Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase Despachador que contenga una lista de paquetes y un método para registrar nuevos paquetes.
    Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
     Todos los paquetes registrados.
     Cuántos superan los 10 kg de peso.
     Cuántos tienen destino nacional (por ejemplo, “Argentina”).
    */
    public class Paquete
    {
        int codigo, peso;
        string destino;
        public Paquete(int codi, int pe, string dest)
        {
            codigo = codi;
            peso = pe;
            destino = dest;
        }
        public int Rcodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public int Rpeso
        {
            set { peso = value; }
            get { return peso;}
        }
        public string Rdest
        {
            set { destino = value; }
            get { return destino; }
        }
    }
    internal class Despachador : Paquete
    {
        List<Despachador> despa = new List<Despachador>();
        
        public Despachador(int codi, int pe, string dest) : base(codi, pe, dest)
        {
            for (int i = 0; i < 2; i++) //CAMBIAR A 5  ===================================================================================================================================
            {
                Console.Write("Ingrese el codigo: ");
                codi = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el peso: ");
                pe = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el destino: ");
                dest = Console.ReadLine();
                Despachador newDespa = new Despachador(codi, pe, dest);
                despa.Add(newDespa);
            }
        }
        public void Mostrar()
        {

        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
