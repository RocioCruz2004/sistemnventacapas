using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class Ingreso
    {
        public int idIngreso {  get; set; }
        public int idProveedor { get; set; }
        public DateTime fechaIngreso { get; set; }
        public decimal total {  get; set; }
        public string estado { get; set; }
    }
}
