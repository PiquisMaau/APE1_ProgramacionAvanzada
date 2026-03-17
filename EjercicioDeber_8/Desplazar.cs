using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_8
{
   
        public class Desplazador
        {
            public void RotarDerecha(int[] arr, int k)
            {
                if (arr == null || arr.Length == 0) return;

                k = k % arr.Length;
                if (k == 0) return;

                Invertir(arr, 0, arr.Length - 1);
                Invertir(arr, 0, k - 1);
                Invertir(arr, k, arr.Length - 1);
            }

            private void Invertir(int[] arr, int inicio, int fin)
            {
                while (inicio < fin)
                {
                    int temp = arr[inicio];
                    arr[inicio] = arr[fin];
                    arr[fin] = temp;
                    inicio++;
                    fin--;
                }
            }
        }
}
