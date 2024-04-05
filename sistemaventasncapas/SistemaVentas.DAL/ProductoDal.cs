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
    public class ProductoDal
    {
        public DataTable FiltrarProductoDal(string producto)
        {
            string consulta = "SELECT IDPRODUCTO id,p.NOMBRE, CODIGOBARRA cod, DESCRIPCION, p.ESTADO FROM Producto p\r\nWHERE p.nombre LIKE '%" + producto+ "%';";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarPoductoDal (int id)
        {
            string consulta = "SELECT IDPRODUCTO, NOMBRE, CODIGOBARRA FROM PRODUCTO WHERE IDPRODUCTO = " +id+";";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public Producto ObtenerIdDal(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto p = new Producto();
            if (tabla.Rows.Count > 0)
            {
                p.nombre = tabla.Rows[0]["nombre"].ToString();
                p.codigoBarra = tabla.Rows[0]["codigobarra"].ToString();
            }
            return p;

        }
    }
}
