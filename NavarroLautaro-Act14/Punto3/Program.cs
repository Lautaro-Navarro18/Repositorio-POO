using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Competencia de Atletismo
    Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
    Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
    Definir los siguientes métodos en la clase Carrera:
    1) Un constructor que cargue los datos de los 3 atletas de la carrera. |
    2) Un método que imprima los nombres de los atletas junto con sus marcas de tiempo. |
    3) Un método que calcule e imprima el tiempo promedio de la carrera. |
    4) Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo). |
    5) Un método que muestre a los atletas que superaron el promedio. |
    */
    class Atleta
    {
        private string nombre;
        private float tiempo;
        public Atleta()
        {
            Console.Write("Ingrese el nombre del atleta: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el tiempo: ");
            tiempo = float.Parse(Console.ReadLine());
        }
        public string Rnombre()
        {
            return nombre;
        }
        public float Rtiempo()
        {
            return tiempo;
        }
    }
    class Carrera
    {
        private Atleta[] atleta;
        private float promedio;
        public Carrera()
        {
            atleta = new Atleta[3];
            for (int i = 0; i < atleta.Length; i++)
            {
                atleta[i] = new Atleta();
            }
        }
        void Imprimir()
        {
            for (int i = 0; i < atleta.Length; i++)
            {
                Console.WriteLine("El atleta " + atleta[i].Rnombre() + " tubo un tiempo de " + atleta[i].Rtiempo());
            }
        }
        void PromedioC()
        {
            /*float promedio = 0;*/
            for (int i = 0; i < atleta.Length; i++)
            {
                promedio += atleta[i].Rtiempo();
            }
            promedio /= atleta.Length;
            Console.WriteLine("El tiempo promedio de la carrerra fue de " + promedio);
        }
        void Ganador()
        {
            int aux = 0;
            float menor = atleta[0].Rtiempo();
            for (int i = 0; i < atleta.Length; i++)
            {
                if(menor > atleta[i].Rtiempo())
                {
                    menor = atleta[i].Rtiempo();
                    aux = i;
                }
            }
            Console.WriteLine("El atleta mas rapido fue " + atleta[aux].Rnombre() + " con un tiempo de " + atleta[aux].Rtiempo());
        }
        void SuperoP()
        {
            /*float promedio = 0;
            for (int i = 0; i < atleta.Length; i++)
            {
                promedio += atleta[i].Rtiempo();         esto profe fue una prueba ante un error
            }
            promedio /= atleta.Length;*/
            for (int i = 0; i < atleta.Length; i++)
            {
                if (atleta[i].Rtiempo() < promedio)
                {
                    Console.WriteLine("El atleta " + atleta[i].Rnombre() + " supero el promedio de " + promedio + "con un tiempo de " + atleta[i].Rtiempo());
                }
            }
        }
        static void Main(string[] args)
        {
            Carrera C = new Carrera();
            C.Imprimir();
            C.PromedioC();
            C.Ganador();
            C.SuperoP();
            Console.ReadKey();
        }
    }
}
