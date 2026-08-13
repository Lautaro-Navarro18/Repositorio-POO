using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*
    5 Un taller mecánico automatizado administra la recepción y egreso de automóviles que se encuentran en el sector de reparaciones.
        Crear la clase Vehiculo que contenga como atributos privados: patente (string) y costoReparacion (double). Definir sus propiedades correspondientes y un constructor que reciba pat y costo. 
        Crear la clase GestionTaller que administre una lista de objetos List.
        Métodos en GestionTaller:
        o IngresarVehiculo(): Solicitar por teclado la patente y el costo de reparación de un vehículo para agregarlo a la lista mediante .Add().
        o BuscarVehiculo(): Pedir al operador que ingrese una patente y, recorriendo la lista, informar si el vehículo está en el taller y mostrar su costo asociado.
        o EntregarVehiculo(): Solicitar una patente por teclado, buscar el vehículo en la lista y, si existe, removerlo de la colección mediante .Remove() confirmando la entrega del automóvil.
        o CalcularRecaudacionPendiente(): Listar los vehículos actualmente en reparación, la cantidad total de unidades alojadas en el taller mediante la propiedad .Count y la suma total acumulada por cobrar. 
    */
    public class Vehiculo
    {
        public string patente;
        public double costoReparacion;
        public Vehiculo(string patente, double costoReparacion)
        {
            this.patente = patente;
            this.costoReparacion = costoReparacion;
        }
    }
    public class GestionTaller
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public void IngresarVehiculo()
        {
            bool auxM = true;
            while (auxM)
            {
                Console.Write("Ingrese la patente del auto: ");
                string patente = Console.ReadLine();
                Console.Write("Ingrese el costo de reparacion: ");
                double costoReparacion = double.Parse(Console.ReadLine());
                Vehiculo vehiculo = new Vehiculo(patente, costoReparacion);
                vehiculos.Add(vehiculo);
                Console.Write("¿Quiere ingresar otro vehiculo? ");
                string auxN = Console.ReadLine();
                if (auxN == "NO" || auxN == "No" || auxN == "no")
                {
                    auxM = false;
                }
            }
            Console.WriteLine();
        }
        public void BuscarVehiculo()
        {
            Console.WriteLine("Ingrese el vehiculo buscado: ");
            string auxN = Console.ReadLine();
            foreach (var vehiculo in vehiculos)
            {
                if(vehiculo.patente == auxN)
                {
                    Console.WriteLine("El vehiculo se encuentra en el taller y su costo de reparacion es: " + vehiculo.costoReparacion);
                }
            }
            Console.WriteLine();
        }
        public void EntregarVehiculo()
        {
            Console.WriteLine("Ingrese la patente del vehiculo que se quiere entregar: ");
            string auxN = Console.ReadLine();
            vehiculos.RemoveAll(i => i.patente == auxN);
            Console.WriteLine();
        }
        public void CalcularRecaudacionPendiente()
        {
            Console.WriteLine("La cantidad de vehiculos en el taller es: " + vehiculos.Count);
            Console.Write("La recaudacion pendiente es: " + vehiculos.Sum(i => i.costoReparacion));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionTaller GT = new GestionTaller();
            GT.IngresarVehiculo();
            GT.BuscarVehiculo();
            GT.EntregarVehiculo();
            GT.CalcularRecaudacionPendiente();
        }
    }
}
