using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Representa un polinomio mediante un array donde el índice es el grado y el valor es el
            //coeficiente(ej. 3x² +5 sería[5, 0, 3]).Crea una clase Polinomio con un método que reciba
            //otro objeto Polinomio y devuelva un nuevo array con la suma de ambos polinomios,
            //considerando que pueden tener diferentes grados.
            
                Console.WriteLine("----- SUMA DE POLINOMIOS -----");

                int[] coeficientes1 = { 5, 0, 3 };
                Polinomio poli1 = new Polinomio(coeficientes1);

                int[] coeficientes2 = { 2, 4, 1, 7 };
                Polinomio poli2 = new Polinomio(coeficientes2);

                Console.WriteLine("Polinomio 1:");
                poli1.Mostrar();

                Console.WriteLine("Polinomio 2:");
                poli2.Mostrar();

                int[] arrayResultado = poli1.Sumar(poli2);

                Polinomio polinomioResultado = new Polinomio(arrayResultado);

                Console.WriteLine("--- RESULTADO ---");
                polinomioResultado.Mostrar();

           
            }
        }
    }

