using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_2
{
    class Curso
    {

        public double CalcularPrimedioGeneral(double[] notas)
        {
            double sumatoria = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                sumatoria += notas[i];
            }
            return sumatoria / notas.Length;
        }


        public double DevolverNotaAlta(double[] notas)
        {
            double notaAlta = notas.Max();
            return notaAlta;
        }
        public double DevolverNotaBaja(double[] notas)
        {
            double notaBaja = notas.Min();
            return notaBaja;
        }

        public double[] EstudiantesAprobados(double[] notas)
        {
            List<double> estudiantesAprobados = new List<double>();
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 6.99 && notas[i] <= 10)
                {
                    estudiantesAprobados.Add(notas[i]);
                }
            }
            return estudiantesAprobados.ToArray();
        }
        public double[] EstudiantesReprobados(double[] notas)
        {
            List<double> estdudiantesReprobados = new List<double>();
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 0 && notas[i] <= 6.99)
                {
                    estdudiantesReprobados.Add(notas[i]);
                }
            }
            return estdudiantesReprobados.ToArray();

        }

        public static void ImprimirListados(double[] notas)
        {
            Console.WriteLine("Imprimiendo notas");
            int CONTADOR = 0;
            foreach (var nota in notas)
            {
                CONTADOR++;
                Console.WriteLine($"{CONTADOR}. {nota}");
            }
        }

    }
}
