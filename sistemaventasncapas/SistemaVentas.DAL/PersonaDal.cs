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
    public class PersonaDal
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "SELECT * FROM PERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);
        }
        public void InsertarPersonaDAL(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.nombre + "'," +
                                                          "'" + persona.apellido + "'," +
                                                          "'" + persona.telefono + "'," +
                                                          "'" + persona.ci + "'," +
                                                          "'" + persona.correo + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Persona ObtenerIdDal(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (tabla.Rows.Count > 0)
            {
                p.nombre = tabla.Rows[0]["nombre"].ToString();
                p.apellido = tabla.Rows[0]["apellido"].ToString();
                p.telefono = tabla.Rows[0]["telefono"].ToString();
                p.ci = tabla.Rows[0]["ci"].ToString();
                p.correo = tabla.Rows[0]["correo"].ToString();
            }
            return p;

        }
        public void EditarPersonaDal(Persona persona)
        {
            string consulta = "update persona set nombre='" + persona.nombre + "'," +
                                                        "apellido='" + persona.apellido + "'," +
                                                        "telefono='" + persona.telefono + "'," +
                                                        "ci='" + persona.ci + "'," +
                                                        "correo='" + persona.correo + "' " +
                                                        "where idpersona=" + persona.idPersona;
            conexion.Ejecutar(consulta);
        }
    }
}
