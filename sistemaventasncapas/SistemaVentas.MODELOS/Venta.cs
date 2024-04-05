using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class Venta
    {
        public int idVenta {  get; set; }
        public int idCliente { get; set; }
        public int idVendedor { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }
    }
}
