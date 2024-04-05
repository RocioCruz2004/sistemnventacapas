using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemaVentas.DAL;
using SistemaVentas.MODELOS;

namespace SistemaVentas.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable FiltrarProductoBss (string producto)
        {
            return dal.FiltrarProductoDal (producto);
        }
        public DataTable ListarProductosBss (int id)
        {
            return dal.ListarPoductoDal(id);
        }
        public Producto ObtenerIdBss(int id)
        {
            return dal.ObtenerIdDal(id);
        }
    }
}
