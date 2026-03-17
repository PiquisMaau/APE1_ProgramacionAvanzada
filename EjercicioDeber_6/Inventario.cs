using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_6
{
    public class Inventario
    {
        
            private Producto[] productos;
            private int contador;


        
        public Inventario(int capacidadMaxima)
        {
            productos = new Producto[capacidadMaxima];  
            contador = 0;
        }

        public void AgregarProducto(Producto nuevo)
        {
            if (contador >= productos.Length) return;

            int i = contador - 1;
            while (i >= 0 && productos[i].ID > nuevo.ID)
            {
                productos[i + 1] = productos[i];
                i--;
            }
            productos[i + 1] = nuevo;
            contador++;
        }

        public Producto BuscarPorID(int idBuscado)
        {
            int inicio = 0;
            int fin = contador - 1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;
                if (productos[medio].ID == idBuscado)
                    return productos[medio];
                if (productos[medio].ID < idBuscado)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }
            return null; 
        }
    }
}
