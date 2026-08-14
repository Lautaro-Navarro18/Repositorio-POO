using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    8/2 Una farmacia controla el nivel de stock de sus medicamentos para evitar el desabastecimiento de insumos esenciales.
         Crear la clase Medicamento que contenga los atributos privados: nombre (string) y stock (int). Definir sus propiedades correspondientes. Su constructor debe recibir nom y stk. 
         Crear la clase ControlFarmacia que administre una lista de objetos List.
         Métodos en ControlFarmacia:
          o Un constructor que cargue por teclado una lista inicial de 4 medicamentos ingresando sus nombres y stock.
          o ListarStock(): Mostrar la lista de medicamentos en pantalla.
          o RemoverAgotados(): Recorrer la lista y remover por completo de la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
          o MostrarMedicamentosDisponibles(): Imprimir la lista actualizada y la cantidad de productos disponibles en el inventario utilizando la propiedad .Count. 
    */
    public class Medicamento
    {
        private string nombre;
        private int stock;
        public Medicamento(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }
        public string Nombre { get { return nombre; } }
        public int Stock { get { return stock; } }
    }
    public class ControlFarmacia
    {
        List<Medicamento> medi = new List<Medicamento>();
        public ControlFarmacia()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el nombre del medicamento: ");
                string nom = Console.ReadLine();
                Console.Write("Ingrese el stock del mismo: ");
                int stk = int.Parse(Console.ReadLine());
                medi.Add(new Medicamento(nom, stk));
            }
        }
        public void ListarStock()
        {
            foreach (var i in medi)
            {
                Console.WriteLine("El medicamento " + i.Nombre + " tiene un stock acutal de " + i.Stock);
            } 
            Console.WriteLine();
        }
        public void RemoverAgotados()
        {
            medi.RemoveAll(i => i.Stock <= 0);
        }
        public void MostrarMedicamentosDisponibles()
        {
            ListarStock();
            int aux = 0;
            for (int i = 0; i < medi.Count; i++)
            {
                aux += medi[i].Stock;
            }
            Console.WriteLine("La cantidad total de medicamentos es de: " + aux);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlFarmacia CF = new ControlFarmacia();
            CF.ListarStock();
            CF.RemoverAgotados();
            CF.MostrarMedicamentosDisponibles();
            Console.ReadKey();
        }
    }
}
