using SistemasVentas.DAL;
using SistemaVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class UsuarioDal
    {
        Usuario u = new Usuario();

        public DataTable ListarVentasDetalleVentaDal ()
        {
            string consulta = "SELECT V.IDVENTA AS ID, P.NOMBRE + ' ' + P.APELLIDO AS CLIENTE, U.NOMBREUSER, PRO.NOMBRE AS PRODUCTO, DV.CANTIDAD, DV.SUBTOTAL, V.FECHA, V.TOTAL, V.ESTADO\r\nFROM VENTA V\r\n\tINNER JOIN USUARIO U ON U.IDUSUARIO = V.IDVENDEDOR\r\n\tINNER JOIN USUARIOROL UR ON UR.IDUSUARIO = U.IDUSUARIO\r\n\tINNER JOIN ROL R ON R.IDROL = UR.IDROL\r\n\tINNER JOIN CLIENTE C ON V.IDCLIENTE = C.IDCLIENTE\r\n\tINNER JOIN PERSONA P ON P.IDPERSONA = C.IDPERSONA\r\n\tINNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\n\tINNER JOIN PRODUCTO PRO ON DV.IDPRODUCTO = PRO.IDPRODUCTO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
