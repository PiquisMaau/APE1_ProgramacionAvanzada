using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementa una clase Desplazador con un método que reciba un array de enteros y un
            //número k.El método debe rotar el array k posiciones a la derecha. Por ejemplo[1, 2, 3, 4, 5]
            //con k = 2 resulta en[4, 5, 1, 2, 3]. Realiza la operación "in-place"(sin crear un array auxiliar de
            //gran tamaño), optimizando el uso de memoria.
           
                Console.WriteLine("----- Desplazador de valores en ARRAYS -----");

                int[] miArray = { 1, 2, 3, 4, 5 };

                int k = 2;

                Console.WriteLine("Array Original:");
                ImprimirArray(miArray);

                Desplazador desplazador = new Desplazador();

                Console.WriteLine($"Rotando el array {k} posiciones a la derecha de forma inplace...");

                desplazador.RotarDerecha(miArray, k);

                Console.WriteLine("Array Resultante:");
                ImprimirArray(miArray);

                
            }

            static void ImprimirArray(int[] arr)
            {
                Console.Write("[ ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                    if (i < arr.Length - 1) Console.Write("| ");
                }
                Console.WriteLine(" ]");
            }
        }
    }

