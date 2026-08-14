using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    7/1 Un restaurante automatizado procesa la comanda de una mesa para controlar la preparación y el cobro de los platos pedidos.
         Crear la clase Plato que contenga como atributos privados: nombrePlato (string) y precio (double). Definir sus propiedades correspondientes y un constructor que reciba nom y pre.
         Crear la clase GestionComandas que administre una lista de objetos List.
         Métodos en GestionComandas:
          o AgregarPlato():Solicitar por teclado los datos de un plato y agregarlo a la lista utilizando .Add().
          o MostrarComanda(): Listar todos los platos agregados hasta el momento junto a la cantidad total de ítems pedidos utilizando la propiedad .Count.
          o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto total a cobrar sumando los precios de la lista.
          o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si se encuentra en la lista, removerlo mediante .Remove() para actualizar la comanda. 
    */
    public class Plato
    {
        private string nombrePlato;
        private double precio;
        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }
        public string Nombre { get { return nombrePlato; } }
        public double Precio { get { return precio; } }
    }
    public class GestionComandas
    {
        List<Plato> platos = new List<Plato>();
        public void AgregarPlato()
        {
            Console.Write("¿Desea encargar algun plato? ");
            string aux = Console.ReadLine();
            if(aux == "SI" || aux == "Si" || aux == "si")
            {
                bool auxM = true;
                while (auxM)
                {
                    Console.Write("¿Que plato desea?: ");
                    string nombrePlato = Console.ReadLine();
                    Console.Write("Ingrese el costo del plato: ");
                    double precio = double.Parse(Console.ReadLine());
                    Plato newPlato = new Plato(nombrePlato, precio);
                    platos.Add(newPlato);
                    Console.Write("¿Quiere ingresar otro plato? ");
                    string auxN = Console.ReadLine();
                    if (auxN == "SI" || auxN == "Si" || auxN == "si")
                    {
                        continue;
                        
                    }else if(auxN == "NO" || auxN == "No" || auxN == "no")
                    {
                        break;
                    }
                    auxM = false;
                }
            }
            else if (aux == "NO" || aux == "No" || aux == "no")
            {
                Console.WriteLine("¡Vuelva pronto! (y con ganas de comprar)");
            }
            Console.WriteLine();
        }
        public void MostrarComanda()
        {
            foreach (var i in platos)
            {
                Console.WriteLine("El plato " + i.Nombre + " vale " + i.Precio);
            }
            Console.WriteLine("La cantidad de platos que hay es de: " + platos.Count);
        }
        public void CalcularTotalMesa()
        {
            Console.WriteLine("El monto total a pagar es de: " + platos.Sum(i => i.Precio) + "$");
        }
        public void CancelarPlato()
        {
            Console.Write("¿Que plato desea cancelar? ");
            string auxP = Console.ReadLine();
            platos.RemoveAll(i => i.Nombre == auxP);
            MostrarComanda();
            CalcularTotalMesa();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionComandas GC = new GestionComandas();
            GC.AgregarPlato();
            GC.MostrarComanda();
            GC.CalcularTotalMesa();
            GC.CancelarPlato();
        }
    }
}
