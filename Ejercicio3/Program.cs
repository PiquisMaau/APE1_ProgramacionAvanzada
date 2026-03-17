using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program : TemperaturasMes
    {
        static void Main(string[] args)
        {
            //            Diseña una aplicación que registre en un array unidimensional las temperaturas diarias de
            //un mes de 31 días.
            //El programa debe:
            //• Permitir el ingreso de temperaturas(utilice una carga de datos randómica).
            //• Mostrar cuántos días tuvieron temperatura superior al promedio. 
            //• Buscar si una temperatura específica ingresada por el usuario existe en el array.
            //• Mostrar en qué posiciones se encuentra. 
            //• Organizar la lógica en una clase TemperaturaMes con métodos de búsqueda y
            //análisis.

            Console.WriteLine("------- Temperaturas diarias ---------");
            double[] arrayTemperaturas = new double[31];
            double temGenerada = 0;
            Random temperaturasRandom = new Random();
            for (int i = 0; i < arrayTemperaturas.Length; i++)
            {
                temGenerada = (temperaturasRandom.NextDouble() * (40.0 - 10.0) + 10.0);
                arrayTemperaturas[i] = Math.Round(temGenerada, 2);
            }

            ImprimirTemperaturas(arrayTemperaturas);
            ObtenerPromedioyComparar(arrayTemperaturas);
            ObtenerTemperaturasSolicitadas(arrayTemperaturas);

        }

       
    }
}
