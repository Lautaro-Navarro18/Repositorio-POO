using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    9/3 Un instituto de enseñanza registra de forma dinámica a sus estudiantes para realizar el seguimiento académico de sus materias.
         Crear la clase Estudiante que contenga como atributos privados: nombreCompleto (string) y calificacion (double). Definir sus propiedades de solo lectura 
          y un constructor que reciba nom y cal.
         Crear la clase GestionAcademica que administre una lista de objetos List.
         Métodos en GestionAcademica:
          o CargarEstudiantes(): Solicitar por teclado nombres y calificaciones para agregar estudiantes a la lista mediante .Add(). La carga finaliza cuando el usuario 
            ingresa la palabra "FIN" como nombre.
          o ListarEstudiantes(): Mostrar en pantalla todos los alumnos junto a la cantidad total de inscriptos mediante la propiedad .Count.
          o FiltrarAprobados(): Recorrer la lista e imprimir en consola únicamente aquellos estudiantes cuya calificación sea mayor o igual a 6.0.
          o DarDeBaja(): Pedir al operador el nombre de un estudiante y, utilizando los métodos de búsqueda y remoción de listas, eliminarlo de la colección si se encuentra presente. 
    */
    public class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;
        public Estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
        public string NombreC { get { return nombreCompleto; } }
        public double Calificacion { get { return calificacion; } }
    }
    public class GestionAcademica
    {
        List<Estudiante> estu = new List<Estudiante>();
        public void CargarEstudiantes()
        {
            bool auxF = true;
            while (auxF)
            {
                Console.Write("Ingrese el nombre del estudiante (ingresar FIN/Fin/fin para finalizar): ");
                string nombreC = Console.ReadLine();
                if (nombreC == "FIN" || nombreC == "Fin" || nombreC == "fin")
                {
                    auxF = false;
                }
                else
                {
                    Console.Write("Ingrese la calificacion del mismo: ");
                    double calificacion = double.Parse(Console.ReadLine());
                    if (calificacion > 10 || calificacion < 1)
                    {
                        Console.Write("Ingrese un valor valido o se le pondra 1 al estudiante ");
                        calificacion = double.Parse(Console.ReadLine());
                        if (calificacion > 10 || calificacion < 1)
                        {
                            Console.WriteLine("El estudiante " + nombreC + " tiene 1");
                            calificacion = 1;
                        }
                    }
                    estu.Add(new Estudiante(nombreC, calificacion));
                }
            }
            Console.WriteLine();
        }
        public void ListarEstudiantes()
        {
            foreach (var i in estu)
            {
                Console.WriteLine("Estudiante: " + i.NombreC + " Calificacion: " + i.Calificacion);
            }
            Console.WriteLine("La cantidad total de estudiantes es de " + estu.Count);
            Console.WriteLine();
        }
        public void FiltrarAprobados()
        {
            foreach (var i in estu)
            {
                if (i.Calificacion >= 6)
                {
                    Console.WriteLine("El alumno " + i.NombreC + " aprobo con " + i.Calificacion);
                }
            }
            Console.WriteLine();
        }
        public void DarDeBaja()
        {
            Console.Write("Ingrese el nombre del que se desea dar de baja ");
            string nombreB = Console.ReadLine();
            estu.RemoveAll(i => i.NombreC == nombreB);
            ListarEstudiantes();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionAcademica GA = new GestionAcademica();
            GA.CargarEstudiantes();
            GA.ListarEstudiantes();
            GA.FiltrarAprobados();
            GA.DarDeBaja();
            Console.ReadKey();
        }
    }
}
