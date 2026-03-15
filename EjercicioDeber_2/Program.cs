using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Desarrolla un programa en C# que permita almacenar en un array unidimensional las 
            //calificaciones de 10 estudiantes en una evaluación. 
            //  El sistema debe:
            //   • Ingresar las notas validando que estén entre 0 y 10.
            //   • Mostrar todas las calificaciones registradas.
            //   • Calcular el promedio general, la nota más alta y la nota más baja. 
            //   • Indicar cuántos estudiantes aprobaron y cuántos reprobaron.
            //   • Crear una clase llamada Curso que contenga métodos para realizar los cálculos.

            Console.WriteLine( "----------- Gestion de NOTAS --------------");
            double[] notas = new double[10];
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Ingresa la nota {i + 1} entre 0 y 10: ");
                    string notaIngresada = Console.ReadLine();
                    if (!notaIngresada.All(char.IsDigit))
                    {
                        Console.WriteLine("!!! Ingresa solo valores numéricos !!!");
                    }
                    if (!(notas[i] >= 0) || !(notas[i] <= 10))
                    {
                        Console.WriteLine("Nota no valida");
                    }
                    

                } while (!(notas[i] >= 0) || !(notas[i] <= 10))

                    
                ;
            }

            Console.WriteLine("Las notas que ingresaste son: ");
            int numerodeNota = 1;
            foreach (var nota in notas)
            {
                Console.WriteLine($"Nota {numerodeNota}: {nota}");
                numerodeNota++;
            }
            Console.WriteLine();
        }
    }
}
