using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Inventario de Sucursales 
    Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.  |
    Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.  |
    Implementar en la clase Sucursal los siguientes métodos:
    1) Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).  |
    2) Un método que busque y muestre el nombre del artículo más caro del local.  |
    3) Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).  |
    */
    class Articulo
    {
        private string nomArti;
        private float precio;
        private int stock;
        public Articulo()
        {
            Console.Write("Ingrese el nombre del articulo: ");
            nomArti = Console.ReadLine();
            Console.Write("Ingrese el precio: ");
            precio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el stock: ");
            stock = int.Parse(Console.ReadLine());
        }
        public string Rnombre()
        {
            return nomArti;
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
    class Sucursal
    {
        private Articulo[] art;
        private int idS;
        public Sucursal()
        {
            art = new Articulo[3];
            Console.WriteLine("Ingrese el numero de la sucursal");
            idS = int.Parse(Console.ReadLine());
            for (int i = 0; i < art.Length; i++)
            {
                art[i] = new Articulo();
            }
        }
        void MostrarA()
        {
            for (int i = 0; i < art.Length; i++)
            {
                Console.Write(art[i].Rnombre() + " ");
                Console.WriteLine(art[i].Rprecio() * art[i].Rstock() + " ");
            }
        }
        void MasCaro()
        {
            float max = art[0].Rprecio();
            int aux = 0;
            for (int i = 0; i < art.Length; i++)
            {
                if (art[i].Rprecio() > max)
                {
                    max = art[i].Rprecio();
                    aux = i;
                }
            }
            Console.WriteLine("El producto " + art[aux].Rnombre() + " es el mas caro, costando " + art[aux].Rprecio());
        }
        void Reponer()
        {
            for (int i = 0; i < art.Length; i++)
            {
                if (art[i].Rstock() <= 5)
                {
                    Console.Write("Se tiene que reponer el articulo " + art[i].Rnombre() + " porque tiene un stock de " + art[i].Rstock() + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Sucursal S = new Sucursal();
            S.MostrarA();
            S.MasCaro();
            S.Reponer();
            Console.ReadKey();
        }
    }
}
