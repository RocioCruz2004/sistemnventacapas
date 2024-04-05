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
    public class clienteBss
    {
        clienteDal dal = new clienteDal();
        public DataTable ListarClientePersonaBss()
        {
            return dal.ListarClientePersonaDal();
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDAL(cliente);
        }
        public Cliente ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteIdDal(id);
        }

        public void EditarClienteBss(Cliente p)
        {
            dal.EditarClienteDal(p);
        }
    }
}
