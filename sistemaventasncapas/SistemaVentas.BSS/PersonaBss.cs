using SistemaVentas.DAL;
using SistemaVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonasBss()
        {
            return dal.ListarPersonaDal();
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
        public void AgregarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDAL(persona);
        }
        public Persona ObtenerIdBss (int id)
        {
            return dal.ObtenerIdDal(id);
        }
        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }
    }
}
