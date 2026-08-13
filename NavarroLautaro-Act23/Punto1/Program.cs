using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1- En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de llegada.
    . Crear la clase Documento que contenga como atributos privados:
        nombreArchivo (string) y cantidadPaginas (int). Definir sus propiedades de solo lectura y un constructor que reciba los parámetros nom y pag.
    . Crear la clase ServidorImpresion que administre una lista dinámica de documentos (List&lt;Documento&gt;).
    . Métodos en ServidorImpresion:
        1. AgregarDocumento(): Solicitar por teclado los datos de un documento y agregarlo al final de la lista utilizando .Add().
        2. ImprimirSiguiente(): Si la lista no está vacía, simular la impresión del primer documento de la lista (mostrar sus datos en consola) y removerlo de la colección mediante
    .RemoveAt(0). Si está vacía, advertir que no hay trabajos pendientes.
        3. MostrarColaPendiente(): Listar todos los documentos que están esperando ser impresos y la cantidad total de páginas acumuladas en la cola de espera utilizando .Count. 
    */
    public class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;
        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
        public string NombreArchivo { get { return nombreArchivo; } }
        public int CantidadPaginas { get { return cantidadPaginas; } }
    }
    public class ServidorImpresion
    {
        List<Documento> docu = new List<Documento>();
        public void AgregarDocumento()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el nombre del archivo ");
                string nombreA = Console.ReadLine();
                Console.Write("Ingrese la cantidad de paginas ");
                int cantPag = int.Parse(Console.ReadLine());
                Documento newD = new Documento(nombreA, cantPag);
                docu.Add(newD);
            }

        }
        public void ImprimirSiguiente()
        {
            if (docu.Count > 0)
            {
                Console.WriteLine("====================");
                Console.WriteLine(docu[0].NombreArchivo);
                Console.WriteLine(docu[0].CantidadPaginas);
                Console.WriteLine("====================");
                docu.RemoveAt(0);
            }
            else { Console.WriteLine("Bien ahí, no hay laburo pendiente"); }
        }
        public void MostrarColaPendiente()
        {
            int auxCD = 0;
            foreach (var i in docu)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(i.NombreArchivo);
                Console.WriteLine(i.CantidadPaginas);
                Console.WriteLine("--------------------");
            }
            for (int i = 0; i < docu.Count; i++)
            {
                auxCD += docu[i].CantidadPaginas;
            }
            Console.WriteLine("Quedan " + auxCD + " paginas por completar");
        }
        static void Main(string[] args)
        {
            ServidorImpresion SI = new ServidorImpresion();
            SI.AgregarDocumento();
            SI.ImprimirSiguiente();
            SI.MostrarColaPendiente();
            Console.ReadKey();
        }
    }
} // piola para entregar
