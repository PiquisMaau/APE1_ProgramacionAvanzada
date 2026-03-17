using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Considerando que el sol realiza un recorrido aparente de 180° en un periodo de 12 horas
            //(desde las 06:00 hasta las 18:00), desarrolle un programa que permita calcular la longitud
            //de la sombra proyectada por un objeto.
            //• El usuario debe ingresar la hora y los minutos.
            //• El sistema debe determinar el ángulo de elevación solar correspondiente. 
            //• Calcule y muestre el tamaño de la sombra de un árbol de 20 metros de altura.
            //• Nota: Considere el manejo de excepciones para horarios fuera del rango
            //establecido(antes de las 06:00 o después de las 18:00).
            
                Console.WriteLine("----- CÁLCULO DE SOMBRA SOLAR -----");
                Console.WriteLine("Recorrido solar de 12 horas");
                Console.WriteLine("------------------------------------------------");

                SombradelSol calculadoraSombra = new SombradelSol();

                calculadoraSombra.CalcularSombra();

            }
        }
    }

