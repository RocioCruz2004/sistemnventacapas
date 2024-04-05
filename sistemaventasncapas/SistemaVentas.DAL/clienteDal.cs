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
    public class clienteDal
    {
        public DataTable ListarClientePersonaDal()
        {
            string consulta = "SELECT IDCLIENTE AS ID, NOMBRE + ' ' + APELLIDO AS NOMBRE, CODIGOCLIENTE AS COD, C.ESTADO\r\n\tFROM PERSONA P\r\n\t\tINNER JOIN CLIENTE C ON P.IDPERSONA = C.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
        public void InsertarClienteDAL(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.idPersona + "," +
                                                          "'" + cliente.tipoCliente + "'," +
                                                          "'" + cliente.codigoCliente + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente c = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                c.idCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                c.idPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                c.tipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                c.codigoCliente = tabla.Rows[0]["codigocliente"].ToString();
                c.estado = tabla.Rows[0]["estado"].ToString();
            }
            return c;

        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set idpersona=" + c.idPersona + "," +
                                                        "tipocliente='" + c.tipoCliente + "'," +
                                                        "codigocliente='" + c.codigoCliente + "'" +
                                                "where idcliente=" + c.idCliente;
            conexion.Ejecutar(consulta);
        }
    }
}
