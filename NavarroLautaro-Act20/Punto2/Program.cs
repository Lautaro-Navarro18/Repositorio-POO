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
     Todos los paquetes registrados.   |
     Cuántos superan los 10 kg de peso.   |
     Cuántos tienen destino nacional (por ejemplo, “Argentina”).
    */
    public class Paquete
    {
        protected int codigo;
        protected float peso;
        protected string destino;
        public Paquete(int codi, float pe, string dest)
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
        public float Rpeso
        {
            set { peso = value; }
            get { return peso; }
        }
        public string Rdest
        {
            set { destino = value; }
            get { return destino; }
        }
    }
    internal class Despachador : Paquete
    {
        public Despachador(int codi, float pe, string dest) : base(codi, pe, dest)
        {
            codigo = codi;
            peso = pe;
            destino = dest;
        }
        List<Paquete> paquete = new List<Paquete>();
        public void NuevoP()
        {
            Console.Write("Ingrese el codigo: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el destino: ");
            destino = Console.ReadLine();
            Paquete newPaque = new Paquete(codigo, peso, destino);
            paquete.Add(newPaque);
        
        }
        public void Mostrar()
        {
            foreach (Paquete i in paquete)
            {
                Console.WriteLine("El codigo del paquete es: " + i.Rcodigo);
                Console.WriteLine("El peso del paquete es: " + i.Rpeso);
                Console.WriteLine("El destino del paquete es: " + i.Rdest);
            }
        }
        public void Supera10kg()
        {
            foreach (Paquete i in paquete)
            {
                if (i.Rpeso > 10)
                {
                    Console.WriteLine("El paquete " + i.Rcodigo + " supera los 10 kg");
                }
            }
        }
        public void DNacional()
        {
            foreach (Paquete i in paquete)
            {
                if(i.Rdest == "Argentina")
                {
                    Console.WriteLine("El paquete " + i.Rcodigo + " tiene destino nacional (Argentina)");
                }
            }
        }
        static void Main(string[] args)
        {
            Despachador despa = new Despachador(2, 2, "2");
            for (int i = 0; i < 5; i++)
            {
                despa.NuevoP();
            }
            despa.Mostrar();
            despa.Supera10kg();
            despa.DNacional();
            Console.ReadKey();
        }
    }
}
