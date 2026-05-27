using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Plantear una clase Alumno que tenga los atributos privados: nombre y un vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del alumno y sus 4 calificaciones. 
    Luego, confeccionar una clase Curso que contenga un vector de 3 objetos Alumno. Agregar los siguientes métodos:
    a) Un método que imprima el nombre de cada alumno y su promedio.
    b) Un método que muestre el nombre del alumno con el promedio más alto.
    c) Un método que indique qué alumnos tienen al menos una nota desaprobada (nota menor a 6) 
    */
    class Alumno
    {
        private string nombre;
        private float[] notas;
        public Alumno()
        {
            Console.Write("Ingresa el nombre del alumno: ");
            nombre = Console.ReadLine();
            notas = new float[4];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingresa la nota N°" + (i+1) + " de " + nombre + ": ");
                notas[i] = float.Parse(Console.ReadLine());
                if (notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("Nota invalida, ingresela denuevo");
                    i--;
                }
            }
        }
        public string RetornarNom()
        {
            return nombre;
        }
        public float RetornarP()
        {
            float promedio = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                promedio = promedio + notas[i];
            }
            promedio = (promedio / 4);
            return promedio;
        }
        public float[] RetornarNot()
        {
            return notas;
        }
    }
    class Curso
    {
        private Alumno[] alumno;
        public Curso()
        {
            alumno = new Alumno[3];
            for (int i = 0; i < alumno.Length; i++)
            {
                alumno[i] = new Alumno();
            }
        }
        public void Imprimir()
        {
            for (int i = 0; i < alumno.Length; i++)
            {
                Console.WriteLine("Nombre: " + alumno[i].RetornarNom() + " Promedio: " + alumno[i].RetornarP());
            }
        }
        public void PromedioA()
        {
            float mayor = alumno[0].RetornarP();
            string nombre = alumno[0].RetornarNom();
            for (int i = 0; i < alumno.Length; i++)
            {
                if (mayor < alumno[i].RetornarP())
                {
                    mayor = alumno[i].RetornarP();
                    nombre = alumno[i].RetornarNom();
                }
            }
            Console.WriteLine("El alumno con el promedio mas alto es: " + nombre + " con " + mayor);
        }
        public void NotaDes()
        {
            for (int i = 0; i < alumno.Length; i++)
            {
                float[] notas = alumno[i].RetornarNot();
                for (int j = 0; j < notas.Length; j++)
                {
                    if (notas[j] < 6)
                    {
                        Console.WriteLine("El alumno " + alumno[i].RetornarNom() + " tiene una nota desaprobada");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Curso c = new Curso();
            c.Imprimir();
            c.PromedioA();
            c.NotaDes();
            Console.ReadKey();
        }
    }
}