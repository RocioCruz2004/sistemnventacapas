using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class UsuarioRol
    {
        public int idUsuarioRol {  get; set; }
        public int idUsuario {  get; set; }
        public int idRol { get; set; }
        public DateTime fechaAsigna { get; set; }
        public string estado { get; set; }

    }
}
