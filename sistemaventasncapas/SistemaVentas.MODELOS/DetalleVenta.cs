using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad {  get; set; }
        public decimal precioVenta { get; set; }
        public decimal subtotal { get; set; }
        public string estado { get; set; }
    }
}
