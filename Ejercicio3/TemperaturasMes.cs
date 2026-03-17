using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class TemperaturasMes
    {
        public static void ObtenerTemperaturasSolicitadas(double[] arrayTemperaturas)
        {
            //Método para buscar una temperatura pedida por el usuario 
            Console.WriteLine("---------------------------------------------");
            Console.Write("Ingresa una temperatura para buscar: ");
            double temperaturaIngresada = double.Parse(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < arrayTemperaturas.Length; i++)
            {
                if (arrayTemperaturas[i] == temperaturaIngresada)
                {
                    Console.WriteLine($"La temperatura ingresada sí existe en la posición: {(i + 1)}. {arrayTemperaturas[i]}");
                    encontrado = true;
                }
            }
            if (!encontrado) { Console.WriteLine("La temperatura ingresada no existe en el array."); }
        }

        public static void ObtenerPromedioyComparar(double[] arrayTemperaturas)
        {
            //Método para calcular el mayor al promedio y mostrar la cantidad que supera esta cifra
            double sumatoria = 0, promedio;
            for (int i = 0; i < arrayTemperaturas.Length; i++)
            {
                sumatoria += arrayTemperaturas[i];
            }
            promedio = sumatoria / arrayTemperaturas.Length;
            Console.WriteLine($"Las temperaturas mayores al promedio({Math.Round(promedio, 2)}) son: ");
            int contador = 0;
            for (int i = 0; i < arrayTemperaturas.Length; i++)
            {
                if (promedio < arrayTemperaturas[i])
                {
                    Console.Write(Math.Round(arrayTemperaturas[i], 2) + " - ");
                    contador++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Hay {contador} temperaturas superiores al promedio.");
        }

        public static void ImprimirTemperaturas(double[] arrayTemperaturas)
        {
            //Método para imprimir
            for (int i = 0; i < arrayTemperaturas.Length; i++)
            {
                Console.WriteLine(Math.Round(arrayTemperaturas[i], 2) + " ");
            }
        }
    }
}
