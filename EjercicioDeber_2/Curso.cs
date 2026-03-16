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

        public double[] EstudiantesAprobadosReprobado(double[] notas)
        {
            List<double> estudiantesAprobados = new List<double>();
            for (int i = 0; i < notas.Length; i++) {
                if (notas[i] >= 6.99 && notas[i] <= 10)
                {
                    estudiantesAprobados[i] = notas [i];
                }
            }
            return estudiantesAprobados.ToArray();
        }
        public string EstudiantesReprobados(double[] notas)
        {
            List<double> estdudiantesReprobados = new List<double> ();
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 0 && notas[i] <= 6.99)
                {
                    estdudiantesReprobados = notas [i];
                }
            }
            return estdudiantesReprobados.ToArray();

        }
    }

}
