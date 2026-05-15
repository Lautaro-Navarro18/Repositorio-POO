using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Sucursales
    {
        /*
        1. Sistema de Logística: Envíos por Sucursal Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna represente el peso (en kg) de cada paquete enviado.
        Métodos:
        1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos paquetes se enviaron hoy para definir el tamaño de su fila.  TA
        2. Cargar el peso de cada paquete.  TA
        3. Imprimir el peso de todos los paquetes organizados por sucursal.  TA
        4. Calcular e informar el peso total despachado por cada sucursal.  TA
        5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal pertenece.  TA
         */
        private string[] nombres;
        private float[][] pesos;
        void CargarP()
        {
            nombres = new string[3];
            pesos = new float[3][];
            int cantidad;
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese el nombre de la sucursal: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ahora ingrese la cantidad de paquetes que se enviaron hoy: ");
                cantidad = int.Parse(Console.ReadLine());
                pesos[i] = new float[cantidad];
                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write("Ingrese el peso de este paquete (con coma, no punto): ");
                    pesos[i][j] = float.Parse(Console.ReadLine());
                }
            }
        }
        void MostrarP()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("La sucursal " + nombres[i] + " tiene " + pesos[i].Length + " paquetes que pesan: ");
                for (int j = 0; j < pesos[i].Length; j++)
                {
                    Console.Write(pesos[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        void PesoTotal()
        {
            float pesoTotal;
            for (int i = 0; i < nombres.Length; i++)
            {
                pesoTotal = 0;
                for (int j = 0; j < pesos[i].Length; j++)
                {
                    pesoTotal += pesos[i][j];
                }
                Console.WriteLine("El peso Total de la sucursal " + nombres[i] + " es de " + pesoTotal);
            }
        }
        void PaqueteP()
        {
            int auxf = 0, auxc = 0;
            float pesoMP = 0;
            for (int i = 0; i < pesos.Length; i++)
            {
                for (int j = 0; j < pesos[i].Length; j++)
                {
                    if (pesos[i][j] > pesoMP)
                    {
                        pesoMP = pesos[i][j];
                        auxf = i;
                        auxc = j;
                    }
                }
            }
            Console.WriteLine("El paquete más pesado de toda la empresa es de la sucursal: " + nombres[auxf] + " y tiene un peso de: " + pesos[auxf][auxc]);
        }
        static void Main(string[] args)
        {
            Sucursales S = new Sucursales();
            S.CargarP();
            S.MostrarP();
            S.PesoTotal();
            S.PaqueteP();
            Console.ReadKey();
        }
    }
}
