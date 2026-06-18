using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
    generados). Definir sus respectivas propiedades de lectura y escritura, validando que la generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
    imprimir estos datos básicos. |
    Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
    en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero). |
    Implementar un método para imprimir todos los datos del panel, incluyendo los heredados. |
    En el programa principal (Main): 
    ●Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
    ●Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que puede acceder tanto a sus propiedades heredadas como a las propias para realizar la muestra de info.
    */
    public class DispositivoEnergia
    {
        private string codigoId;
        private double genKwh;
        public string RcodigoId
        {
            set
            {
                codigoId = value;
            }
            get
            {
                return codigoId;
            }
        }
        public double RgenKwh
        {
            set
            {
                genKwh = value;
            }
            get
            {
                return genKwh;
            }
        }
        public DispositivoEnergia()
        {
            Console.Write("Ingrese el codigo de identificacion del dispositivo: ");
            codigoId = Console.ReadLine();
            Console.Write("Ingrese la generacion por hora en Kwh: ");
            genKwh = double.Parse(Console.ReadLine());
            if(genKwh < 0)
            {
                genKwh = 0;
            }
        }
        public void MostrarD()
        {
            Console.WriteLine("El dispositivo " + codigoId + " tiene una generacion por hora de " + genKwh + "Kwh");
        }
    }
    public class PanelSolar : DispositivoEnergia
    {
        private double areaM;
        public PanelSolar()
        {
            Console.Write("Ingrese el area en metros cuadrados del panel solar: ");
            areaM = double.Parse(Console.ReadLine());
            while (areaM < 0)
            {
                Console.WriteLine("Ingrese un valor valido: ");
                areaM = double.Parse(Console.ReadLine());
            }
        }
        public void MostrarDP()
        {
            Console.WriteLine("El dispositivo " + RcodigoId + " que produce " + RgenKwh + "Kwh tiene un area de " + areaM + "m²");
        }
        static void Main(string[] args)
        {
            DispositivoEnergia de = new DispositivoEnergia();
            de.MostrarD();
            PanelSolar ps = new PanelSolar();
            ps.MostrarDP();
            Console.ReadKey();
        }
    }
}
