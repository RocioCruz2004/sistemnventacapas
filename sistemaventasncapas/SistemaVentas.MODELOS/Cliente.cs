using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class Cliente
    {
        public int idCliente {  get; set; }
        public int idPersona { get; set; }
        public string tipoCliente { get; set; }
        public string codigoCliente { get; set; }
        public string estado {  get; set; }
    }
}
