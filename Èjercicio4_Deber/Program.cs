using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Deber
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Elabora un programa que almacene 20 números enteros en un array unidimensional. 
            //Luego debe: 
            //• Mostrar los números ingresados. 
            //• Separar e imprimir los números pares e impares. 
            //• Ordenar el array de menor a mayor sin usar funciones predefinidas de
            //ordenamiento.
            //• Mostrar cuántos números son positivos, negativos y cero.
            //• Implementar métodos independientes para cada proceso. 
            //• La carga de números debe ser randómica

        
            int[] numeros = new int[20]; 
            CargarAleatorios(numeros); 

            Console.WriteLine("--- Array Original ---");
            MostrarNumeros(numeros); 

            Console.WriteLine("--- Pares e Impares ---");
            MostrarParesImpares(numeros); 

            Console.WriteLine("--- Conteo de Tipos ---");
            ContarPositivosNegativosCeros(numeros); 

            Console.WriteLine("--- Array Ordenado ---");
            OrdenarNumeros(numeros); 
            MostrarNumeros(numeros);
        }
        public static void CargarAleatorios(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(-50, 51); 
        }

        public static void MostrarNumeros(int[] arreglo)
        {
            foreach (var numero in arreglo)
            {
                Console.Write(numero + " | ");
            }
            Console.WriteLine();
        }

        public static void MostrarParesImpares(int[] array)
        {
            Console.Write("Pares: ");
            foreach (var numero in array) 
            { 
                if (numero % 2 == 0) Console.Write(numero + " | "); 
            }
            Console.Write("\nImpares: ");
            foreach (var numero in array) {
                if (numero % 2 != 0) Console.Write(numero + " | "); 
            }
            Console.WriteLine();
        }

        public static void ContarPositivosNegativosCeros(int[] arr)
        {
            int positivos = 0, negativos = 0, ceros = 0;
            foreach (var n in arr)
            {
                if (n > 0) positivos++;
                else if (n < 0) negativos++;
                else ceros++;
            }
            Console.WriteLine($"Positivos: {positivos}, Negativos: {negativos}, Ceros: {ceros}");
        }

        public static void OrdenarNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }
        }
       
        
        }
}
