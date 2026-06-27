using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    Actividad 3: Estadísticas de visitas a zonas arqueológicas
    Problema:
    Un instituto de arqueología desea registrar las visitas semanales a 3 zonas arqueológicas durante 4 semanas.
    Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los días. Luego:
    Calcular el total de visitas por zona y almacenarlo en un vector.
    Mostrar los datos en forma tabular.
    Agregar estos resultados a una lista llamada zonasVisitadas que contenga nombres de zonas y total de visitas.
    Determinar cuál fue la zona más visitada.  
    */
    internal class ZonasArqueologicas
    {
        private int[,] visitas = new int[3, 4];
        private int[] totalV = new int[3];
        private string[] nombreZ = new string[3];
        public ZonasArqueologicas()
        {
            for (int i = 0; i < nombreZ.Length; i++)
            {
                Console.Write("Inserta el nombre de la zona " + (i + 1) + ": ");
                nombreZ[i] = Console.ReadLine();
            }
            Console.WriteLine("<========================================================>");
            for (int i = 0; i < visitas.GetLength(0); i++)
            {
                for (int e = 0; e < visitas.GetLength(1); e++)
                {
                    Console.Write("Inserta las visitas en la semana " + (e + 1) + " a la zona " + nombreZ[i] + ": ");
                    visitas[i, e] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("<========================================================>");
            }
        }
        public void TotalV()
        {
            int auxT = 0;
            for (int i = 0; i < visitas.GetLength(0); i++)
            {
                for (int e = 0; e < visitas.GetLength(1); e++)
                {
                    auxT += visitas[i, e];
                }
                totalV[i] = auxT;
                auxT = 0;
            }
        }
        public void Datos()
        {
            Console.WriteLine("<===============> DATOS ZONA ARQUELOGICA <===============>");
            Console.Write("Nombre Zonas: [");
            for (int i = 0; i < nombreZ.Length; i++)
            {
                Console.Write(nombreZ[i]);
                if(i < nombreZ.Length - 1)
                {
                    Console.Write(" - ");
                }
            }
            Console.WriteLine("]");
            for (int i = 0; i < visitas.GetLength(0); i++)
            {
                for (int e = 0; e < visitas.GetLength(1); e++)
                {
                    Console.WriteLine("Cantidad de visitas en la semana " + (e + 1) + " a la zona: " + (nombreZ[i]) + ": " + visitas[i, e]);
                }
                Console.WriteLine("<========================================================>");
            }
        }
        List<(string nombre, int visitas)> zonasV = new List<(string, int)>();
        public void DatosL()
        {
            for (int i = 0; i < nombreZ.Length; i++)
            {
                zonasV.Add((nombreZ[i], totalV[i]));
            }
            foreach (var i in zonasV)
            {
                Console.WriteLine("<===============================>");
                Console.WriteLine("Zona: " + i.nombre);
                Console.WriteLine("Total Visitas: " + i.visitas);
            }
            Console.WriteLine("<===============================>");
        }
        public void ZMV()
        {
            int auxM = zonasV[0].visitas;
            foreach (var i in zonasV)
            {
                if (i.visitas > auxM)
                {
                    auxM = i.visitas;
                }
            }
            foreach (var i in zonasV)
            {
                if (i.visitas == auxM)
                {
                    Console.WriteLine("La zona mas visitada es " + i.nombre + " con " + auxM);
                }
            }
        }
        static void Main(string[] args)
        {
            ZonasArqueologicas ZA = new ZonasArqueologicas();
            ZA.TotalV();
            ZA.Datos();
            ZA.DatosL();
            ZA.ZMV();
        }
    }
}
