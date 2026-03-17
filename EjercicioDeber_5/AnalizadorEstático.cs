using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_5
{
    internal class AnalizadorEstadistico
    {
        private double[] datos;

        public AnalizadorEstadistico(double[] datos)
        {
            this.datos = datos; 
        }

        public double CalcularMedia()
        {
            double sumatoria = 0;
            foreach (var dato in datos) sumatoria += dato;
            return sumatoria / datos.Length;
        }

        public double CalcularMediana()
        {
            double[] copia = new double[datos.Length];
            Array.Copy(datos, copia, datos.Length);
            Array.Sort(copia);

            int mitad = copia.Length / 2;
            if (copia.Length % 2 == 0)
                return (copia[mitad - 1] + copia[mitad]) / 2.0;
            else
                return copia[mitad];
        }

        public double CalcularModa()
        {
            var grupos = datos.GroupBy(x => x).OrderByDescending(g => g.Count());
            return grupos.First().Key;
        }

        public double CalcularDesviacionEstandar()
        {
            double media = CalcularMedia();
            double sumaCuadrados = 0;
            foreach (var d in datos)
            {
                sumaCuadrados += Math.Pow(d - media, 2);
            }
            return Math.Sqrt(sumaCuadrados / datos.Length);
        }
    }
}
