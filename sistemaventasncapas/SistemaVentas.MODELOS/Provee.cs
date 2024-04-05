using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class Provee
    {
        public int idProvee { get; set; }
        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public DateTime fecha { get; set; }
        public decimal precio { get; set; }
    }
}
