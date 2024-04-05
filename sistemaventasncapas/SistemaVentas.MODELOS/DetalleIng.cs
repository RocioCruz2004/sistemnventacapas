using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class DetalleIng
    {
        public int idDetalleIng { get; set; }
        public int idIngreso { get; set; }
        public int idProducto { get; set; }
        public DateTime fechaVenc {  get; set; }
        public int cantidad { get; set; }
        public decimal precioCosto { get; set; }
        public decimal precioVenta { get; set; }
        public decimal subtotal { get; set; }
        public string estado { get; set; }
    }
}
