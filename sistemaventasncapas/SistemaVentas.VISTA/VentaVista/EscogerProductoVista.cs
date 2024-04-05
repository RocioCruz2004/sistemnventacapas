using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
using SistemaVentas.VISTA.ClienteVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.VentaVista
{
    public partial class EscogerProductoVista : Form
    {
        public EscogerProductoVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            string producto = textBox1.Text;
            dataGridView1.DataSource = bss.FiltrarProductoBss(producto);
        }


        private void EscogerProductoVista_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //seleccionar
        {
            int idper = 0;
            int idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int cantidad = Convert.ToInt32(textBox2.Text);
            decimal precio = Convert.ToDecimal(textBox3.Text);
            NuevaVentaVista fr = new NuevaVentaVista(idProducto, cantidad, precio, idper);
        }
    }
}
