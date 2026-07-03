using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    Actividad 1: Control de horarios en un gimnasio
    Problema:
    Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar DateTime).
     Implementar un constructor que permita cargar los datos desde consola y otro que cargue valores por defecto (sobrecarga de constructores).
     Incluir un método para calcular la duración de la clase usando TimeSpan.
     Crear un vector de 3 clases de gimnasio y mostrar:
      1. La clase que tenga la mayor duración.
      2. El nombre y el horario de inicio de la clase más temprana.
    */
internal class ClaseGimnasio
{
    public string nombreC;
    public DateTime horaI, horaF;
    public TimeSpan dura;
    public ClaseGimnasio(string nombreC, DateTime horaI, DateTime horaF)
    {
        Console.Write("Ingrese el nombre de la clase: ");
        nombreC = Console.ReadLine();
        this.nombreC = nombreC;
        Console.Write("Ingrese la hora de inicio (HH:mm): ");
        horaI = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);
        this.horaI = horaI;
        Console.Write("Ingrese la hora de fin (HH:mm): ");
        horaF = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);
        this.horaF = horaF;
    }
    public ClaseGimnasio() : this("Clase Libre", DateTime.Today.AddHours(8), DateTime.Today.AddHours(9))
    {
    }
    public TimeSpan DuracionC()
    {
        dura = horaF - horaI;
        Console.WriteLine("La duracion de la clase es: " + dura.Hours + "h " + dura.Minutes + "m");
        return dura;
    }
    static void Main(string[] args)
    {
        ClaseGimnasio[] clas = new ClaseGimnasio[3];
        for (int i = 0; i < clas.Length; i++)
        {
            clas[i] = new ClaseGimnasio();
        }
        int auxi = 0, auxI = 0;
        DateTime aux = clas[0].horaI;
        TimeSpan aux2 = clas[0].DuracionC();
        for (int i = 0; i < clas.Length; i++)
        {
            if (aux2 < clas[i].dura)
            {
                aux2 = clas[i].dura;
                auxI = i;
            }
            if (aux > clas[i].horaI)
            {
                aux = clas[i].horaI;
                auxi = i;
            }
        }
        Console.WriteLine("La clase con mayor duracion es: " + clas[auxI].nombreC + " con " + clas[auxI].dura.Hours + "h y la más temprana es: " + clas[auxi].nombreC + " a las " + clas[auxi].horaI.ToString("HH:mm"));
        Console.ReadKey();
    }
}
}
