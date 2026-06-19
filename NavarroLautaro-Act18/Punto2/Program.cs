using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2.Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    La clase CriaturaMarina debe tener como atributos privados: Especie (string), ProfundidadOptima (int, en metros) y NivelSalinidad 
    (un valor de 1 a 100). Definir las propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
    ● La profundidad óptima sea estrictamente mayor a cero (0). |
    ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario, asignar un valor por defecto de 35, que representa la salinidad promedio del océano). |
    La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico 
    para cargar las 3 criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base a su profundidad óptima. Además, el programa debe 
    informar la especie que requiere el mayor nivel de salinidad para sobrevivir.
    */
    public class CriaturaMarina
    {
        private string especie;
        private int profundiO, nivelS;
        public CriaturaMarina()
        {
            Console.Write("Ingrese la especie del animal: ");
            especie = Console.ReadLine();
            Console.Write("Ingrese la profundidad optima del mismo: ");
            profundiO = int.Parse(Console.ReadLine());
            if(profundiO < 0)
            {
                Console.WriteLine("Es un pez, no una gaviota");
                profundiO = 5;
            }
            Console.Write("Ingrese el nivel de salinidad de la criatura: ");
            nivelS = int.Parse(Console.ReadLine());
            if (nivelS <0)
            {
                Console.WriteLine("Te falto un poco de sal para que quede rico 6/10");
                nivelS = 35;
            }
            else if (nivelS > 100)
            {
                Console.WriteLine("¿Querias pez seco?");
                nivelS = 35;
            }
        }
        public string Respecie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
        public int RprofundiO
        {
            set
            {
                profundiO = value;
            }
            get
            {
                return profundiO;
            }
        }
        public int RnivelS
        {
            set
            {
                nivelS = value;
            }
            get
            {
                return nivelS;
            }
        }
    }
    internal class HabitadAcuatico
    {
        private CriaturaMarina[] epez = new CriaturaMarina[3];
        public HabitadAcuatico()
        {
            for (int i = 0; i < epez.Length; i++)
            {
                epez[i] = new CriaturaMarina();
            }
        }
        public void Ordenar()
        {
            int auxPO = 0, auxNS = 0, auxI = 0;
            string auxE;
            for (int i = 0; i < epez.Length - 1; i++)
            {
                for (int j = 0; j < epez.Length - 1; j++)
                {
                    if (epez[j].RprofundiO > epez[j + 1].RprofundiO)
                    {
                        auxPO = epez[j + 1].RprofundiO;
                        epez[j + 1].RprofundiO = epez[j].RprofundiO;
                        epez[j].RprofundiO = auxPO;
                        auxNS = epez[j + 1].RnivelS;
                        epez[j + 1].RnivelS = epez[j].RnivelS;
                        epez[j].RnivelS = auxNS;
                        auxE = epez[j + 1].Respecie;
                        epez[j + 1].Respecie = epez[j].Respecie;
                        epez[j].Respecie = auxE;
                    }
                }
            }
            for (int i = 0; i < epez.Length; i++)
            {
                Console.WriteLine("El animal " + epez[i].Respecie + " tiene una profundidad optima de " + epez[i].RprofundiO + "m y un nivel de salinidad de " + epez[i].RnivelS);
            }
            for (int i = 0; i < epez.Length-1; i++)
            {
                if (epez[i].RnivelS > epez[i + 1].RnivelS)
                {
                    auxI = i;
                }
                else
                {
                    auxI = i + 1;
                }
            }
            Console.Write("El animal " + epez[auxI].Respecie + " es que necesita mayor salinidad con " + epez[auxI].RnivelS);
        }
        static void Main(string[] args)
        {
            HabitadAcuatico ha = new HabitadAcuatico();
            ha.Ordenar();
            Console.ReadKey();
        }
    }
}