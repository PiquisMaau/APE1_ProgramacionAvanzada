using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dado un rango inicial y un rango final, calcule la sumatoria de todos los números primos
            //que terminen en 7.De ser el caso incluye el número 7.
            string rangoInicial = Console.ReadLine();
            string rangoFinal = Console.ReadLine();
            int sumatoria = 0;
            VerificarSiEsPrimoSiete(rangoInicial, rangoFinal) != 0 ? sumatoria += VerificarSiEsPrimoSiete(rangoInicial, rangoFinal) : 0;



    
        }

        private static int VerificarSiEsPrimoSiete(string rangoInicial, string rangoFinal)
        {

            for (int i = int.Parse(rangoInicial); i <= int.Parse(rangoFinal); i++) {
                if (Esprimo(i))
                {
                    i.ToString().EndsWith("7");
                    return i;
                }
            }
            return 0;

        }

        private static Boolean Esprimo(int numero)
        {
            if (numero <= 1) return false; 
            if (numero == 2) return true;
            if (numero%2 == 0) return false;
            for (int i = 3; i < Math.Sqrt(numero); i++) {
                if (numero % i == 0) return false;
        }return true;
    }
    }
}
