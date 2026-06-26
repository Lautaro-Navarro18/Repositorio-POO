using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        private string titulo;
        public string Rtitulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }
        private string autor;

        public string Rautor
        {
            set
            {
                autor = value;
            }
            get
            {
                return autor;
            }
        }
        private int paginas;
        public int Rpaginas
        {
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Minimo 10 paginas");
                }
                else
                {
                    paginas = value;
                }
            }
            get
            {
                return paginas;
            }
        }
        public Libro()
        {
            Console.Write("Ingresa el titulo: ");
            Rtitulo = Console.ReadLine();
            Console.Write("Ingresa el autor: ");
            Rautor = Console.ReadLine();
            Console.Write("Ingresa la cantidad de paginas: ");
            Rpaginas = int.Parse(Console.ReadLine());
        }
    }
}