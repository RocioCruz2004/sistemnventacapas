using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class Producto
    {
        public int idProducto { get; set; }
        public int idTipoProd { get; set; }
        public int idMarca { get; set; }
        public string nombre { get; set; }
        public string codigoBarra { get; set; }
        public int unidad { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
