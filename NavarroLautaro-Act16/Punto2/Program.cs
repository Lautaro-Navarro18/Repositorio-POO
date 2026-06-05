using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Plantear una clase Producto y otra clase Inventario.
     La clase Producto debe tener como atributos privados el nombre, precio y stock. Definir propiedades para acceder a estos atributos, asegurando que el stock no pueda ser negativo
     y el precio sea mayor a cero. La clase Inventario debe contener 3 objetos de la clase Producto. Definir un método para mostrar todos los productos ordenados de menor a mayor en
     base al precio, además, mostrar el producto más caro y más barato del inventario.
    */
    public class Producto
    {
        private string nombre;
        private float precio;
        private int stock;
        public Producto()
        {
            Console.Write("Ingrese el nombre del producto ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del producto ");
            precio = float.Parse(Console.ReadLine());
            while(precio < 0)
            {
                Console.Write("El precio debe ser mayor a cero, ingrese nuevamente el precio del producto ");
                precio = float.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese el stock del producto ");
            stock = int.Parse(Console.ReadLine());
            while(stock < 0)
            {
                Console.Write("El stock no puede ser negativo, ingrese nuevamente el stock del producto ");
                stock = int.Parse(Console.ReadLine());
            }
        }
        public string Rnombre()
        {
            return nombre;
        }
        public float Rprecio()
        {
            return precio;
        }
        public int Rstock()
        {
            return stock;
        }
    }
    public class Inventario
    {
        private Producto[] produ = new Producto[3];
        public Inventario()
        {
            for (int i = 0; i < produ.Length; i++)
            {
                Console.WriteLine("Producto " + (i + 1));
                produ[i] = new Producto();
            }
        }
        public void MostrarT()
        {
            
        }
    }
    internal class Prueba
    {
        static void Main(string[] args)
        {
            Inventario i = new Inventario();
            i.MostrarT();
            Console.ReadKey();
        }
    }
}
