using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_5
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Crea una clase AnalizadorEstadistico que reciba un array de números reales(double[]) en
            //su constructor.Implementa métodos para calcular la media, la mediana, la moda y la
            //desviación estándar.El método de la mediana debe ordenar el array internamente sin
            ////modificar el array original(usar Array.Copy).
            Console.Write("Ingresa el tamaño de tu array: ");
            int tamanio = int.Parse(Console.ReadLine());
            double[] datosAnalizador = new double[tamanio];
            Random random = new Random();
            for (int i = 0; i < datosAnalizador.Length; i++)
            {
                datosAnalizador[i] = Math.Round(random.NextDouble()*(1000-(-1000))+(-1000), 2);
            }
            Console.WriteLine("----- Tu array es: ");
            foreach (var item in datosAnalizador)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();
            AnalizadorEstadistico an1 = new AnalizadorEstadistico(datosAnalizador);
            Console.WriteLine($"La mediana de tu array es: {an1.CalcularMediana()}");
            Console.WriteLine($"La Desviación Estándar de tu array es: {an1.CalcularDesviacionEstandar()}");
            Console.WriteLine($"La Media de tu array es: {an1.CalcularMedia()}");
            Console.WriteLine($"La Moda de tu array es: {an1.CalcularModa()}");

        }
    }
}
