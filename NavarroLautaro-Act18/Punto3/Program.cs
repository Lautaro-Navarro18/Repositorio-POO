using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y AutonomiaMinutos (int). 
    Definir un constructor que reciba estos dos valores como parámetros y realice su asignación.
    Luego, definir dos clases derivadas de la clase base:
    ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima soportada en atmósferas).
    ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
    Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir tanto el atributo específico como los heredados de la clase base, 
    transfiriendo estos últimos a la clase SondaExploradora mediante el uso explícito de la palabra clave base.
    En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus parámetros unificados por consola.
    */
    public class SondaExploradora
    {
        string modelo;
        int autoM;
        public SondaExploradora(string modelo, int autoM)
        {
            Console.WriteLine("La sonda modelo " + modelo + " tiene una autonomia de " + autoM + "min");
        }
    }
    public class SondaSubmarina : SondaExploradora
    {
        public SondaSubmarina(string modelo, int autoM, int preM) : base(modelo, autoM)
        {
            Console.WriteLine(" y soporta " + preM + " atmosferas de presion");
        }
    }
    public class RoverTerrestre : SondaExploradora
    {
        public RoverTerrestre(string modelo, int autoM, int cantR) : base(modelo, autoM)
        {
            Console.WriteLine(" y tiene " + cantR + " ruedas");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SondaExploradora SE = new SondaExploradora("T1000", 10000);
            SondaSubmarina SS = new SondaSubmarina("T1200A", 8000, 500);
            RoverTerrestre RT = new RoverTerrestre("T1200T", 15000, 8);
            Console.ReadKey();
        }
    }
}
