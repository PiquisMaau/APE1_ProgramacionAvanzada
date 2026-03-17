using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_10
{
    public class ProductoExportacion
    {
        public int Id { get; set; }
        public string Mes { get; set; }
        public int Anio { get; set; }
        public string Pais { get; set; }
        public string TipoProducto { get; set; }
        public double PesoToneladas { get; set; }
        public double MontoMillones { get; set; }
    }
}
