using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class Usuario
    {
        public int idUsuario {  get; set; }
        public int idPersona { get; set; }
        public string nombreUser { get; set; }
        public string contraseña { get; set; }
        public DateTime fechaReg {  get; set; }
    }
}
