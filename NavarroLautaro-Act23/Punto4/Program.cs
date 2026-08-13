using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4 Un sistema central de domótica gestiona el consumo de los artefactos inteligentes vinculados a una red hogareña.
        Crear la clase DispositivoInteligente que contenga como atributos privados: nombreDispositivo (string) y consumoWatts (double). Definir sus propiedades 
         y un constructor que reciba nom y watts.
        Crear la clase colaboradora PanelDomotico que administre un objeto List<DispositivoInteligente>.
        Métodos en PanelDomotico:
          1. Un constructor que permita al usuario cargar dinámicamente dispositivos por teclado. El sistema preguntará después de cada carga si se desea agregar otro dispositivo.
          2. MostrarDispositivos(): Listar todos los dispositivos configurados junto a sus consumos.
          3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los Watts totales que consume la casa sumando los valores de la lista.
          4. DesconectarDispositivo(): Solicitar al usuario el nombre de un dispositivo y, si existe en la lista, removerlo de forma dinámica para simular su apagado remoto. 
    */
    public class DispositivoInteligente
    {
        public string nombreDisposi;
        public double consumoWs;
        public DispositivoInteligente(string nombreDisposi, double consumoWs)
        {
            this.nombreDisposi = nombreDisposi;
            this.consumoWs = consumoWs;
        }
    }
    public class PanelDomotico
    {
        List<DispositivoInteligente> dispoInte = new List<DispositivoInteligente>();
        public PanelDomotico()
        {
            bool auxF = true;
            while (auxF)
            {
                Console.Write("Ingrese el nombre del dispositivo inteligente: ");
                string auxND = Console.ReadLine();
                Console.Write("Ingrese el consumo en Watts del mismo: ");
                double auxC = double.Parse(Console.ReadLine());
                DispositivoInteligente newDI = new DispositivoInteligente(auxND, auxC);
                dispoInte.Add(newDI);
                Console.Write("¿Desea seguir ingresando dispositivos? ");
                string auxN = Console.ReadLine();
                if (auxN == "NO" || auxN == "No" || auxN == "no")
                {
                    auxF = false;
                }
            }
        }
        public void MostrarDispositivos()
        {
            Console.Clear();
            foreach (var i in dispoInte)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Nombre: " + i.nombreDisposi);
                Console.WriteLine("Consumo en Watts " + i.consumoWs);
                Console.WriteLine("-------------------------");
            }
        }
        public void CalcularConsumoTotal()
        {
            double auxW = 0;
            for (int i = 0; i < dispoInte.Count; i++)
            {
                auxW += dispoInte[i].consumoWs;
            }
            Console.WriteLine("El consumo total de la vivienda es de: " + auxW);
        }
        public void DesconectarDispositivo()
        {
            Console.WriteLine("Ingrese el dispositivo que se quiere apagar: ");
            string auxN = Console.ReadLine();
            dispoInte.RemoveAll(i => i.nombreDisposi == auxN);
            MostrarDispositivos();
            CalcularConsumoTotal();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PanelDomotico PD = new PanelDomotico();
            PD.MostrarDispositivos();
            PD.CalcularConsumoTotal();
            PD.DesconectarDispositivo();
            Console.ReadKey();
        }
    }
}
