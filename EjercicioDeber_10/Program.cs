using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioDeber_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Implemente una solución en C# que importe el dataset ProductosExportacion(4).csv 
            //mediante listas de objetos y procese la información para responder:
            //• Monto total exportado por cada país. 
            //• Producto líder en réditos de 2024: Indique el tipo de producto con mayor valor
            //económico y su monto total.
            //• Conteo anual en Norteamérica: Cantidad de productos exportados por año,
            //considerando solo dicha región.
            //• Peso promedio en Centroamérica: Promedio de toneladas métricas de los países
            //de la región.

           
                Console.WriteLine("----- ANÁLISIS DE DATOS DE UN ARCHIVO CSV -----");
                Console.WriteLine("Procesando archivo...");

                AnalisisCSV analisis = new AnalisisCSV();

                analisis.Ejecutar();

        
        }
    }
}
