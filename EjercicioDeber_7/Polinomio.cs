using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_7
{
    public class Polinomio
    {
        public int[] Coeficientes { get; set; }

        public Polinomio(int[] coeficientes)
        {
            Coeficientes = coeficientes;
        }

        public int[] Sumar(Polinomio otro)
        {
            int maxGrado = Math.Max(this.Coeficientes.Length, otro.Coeficientes.Length);
            int[] resultado = new int[maxGrado];

            for (int i = 0; i < maxGrado; i++)
            {
                int valor1 = i < this.Coeficientes.Length ? this.Coeficientes[i] : 0;
                int valor2 = i < otro.Coeficientes.Length ? otro.Coeficientes[i] : 0;
                resultado[i] = valor1 + valor2;
            }
            return resultado;
        }

        public void Mostrar()
        {
            for (int i = Coeficientes.Length - 1; i >= 0; i--)
            {
                if (Coeficientes[i] != 0)
                    Console.Write($"{Coeficientes[i]}x^{i} ");
            }
            Console.WriteLine();
        }
    }
}
