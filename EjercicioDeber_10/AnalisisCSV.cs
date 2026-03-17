using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_10
{
    class AnalisisCSV
    {
        public void Ejecutar()
        {
            List<ProductoExportacion> lista = new List<ProductoExportacion>();
            string rutaArchivo = "ProductosExportacion (4).csv"; 

            try
            {
                var lineas = File.ReadAllLines(rutaArchivo).Skip(1);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');
                    lista.Add(new ProductoExportacion
                    {
                        Id = int.Parse(datos[0]),
                        Mes = datos[1],
                        Anio = int.Parse(datos[2]),
                        Pais = datos[3],
                        TipoProducto = datos[4],
                        PesoToneladas = double.Parse(datos[5], System.Globalization.CultureInfo.InvariantCulture),
                        MontoMillones = double.Parse(datos[6], System.Globalization.CultureInfo.InvariantCulture)
                    });
                }

                Console.WriteLine("--- 1. Monto Total por País ---");
                var porPais = lista.GroupBy(p => p.Pais).Select(g => new { Pais = g.Key, Total = g.Sum(x => x.MontoMillones) });
                foreach (var item in porPais) Console.WriteLine($"{item.Pais}: ${Math.Round(item.Total, 2)} M");

                Console.WriteLine("--- 2. Producto líder en 2024 ---");
                var lider2024 = lista.Where(p => p.Anio == 2024)
                                     .GroupBy(p => p.TipoProducto)
                                     .Select(g => new { Prod = g.Key, Total = g.Sum(x => x.MontoMillones) })
                                     .OrderByDescending(x => x.Total).FirstOrDefault();
                Console.WriteLine($"Producto: {lider2024.Prod} | Monto: ${Math.Round(lider2024.Total, 2)} M");

                Console.WriteLine("--- 3. Conteo Anual en Norteamérica ---");
                string[] norte = { "Estados Unidos", "Canadá", "México" };
                var conteoNorte = lista.Where(p => norte.Contains(p.Pais))
                                       .GroupBy(p => p.Anio).Select(g => new { Anio = g.Key, Cantidad = g.Count() }).OrderBy(x => x.Anio);
                foreach (var item in conteoNorte) Console.WriteLine($"Año {item.Anio}: {item.Cantidad} exportaciones");

                Console.WriteLine("--- 4. Peso promedio en Centroamérica ---");
                string[] centro = { "Costa Rica", "Guatemala", "Honduras" };
                var pesoCentro = lista.Where(p => centro.Contains(p.Pais)).Average(p => p.PesoToneladas);
                Console.WriteLine($"Promedio: {Math.Round(pesoCentro, 2)} Toneladas");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el CSV!!! " + ex.Message);
            }
        }
    }
}
