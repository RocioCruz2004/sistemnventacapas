using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
using SistemaVentas.VISTA.CajeroVista;
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
    public partial class NuevaVentaVista : Form
    {
        public static int IdClienteSeleccionada = 0;

        int id = 0, cant = 0, idper=0;
        decimal price = 0;

        Cliente c = new Cliente();
        ProductoBss bss = new ProductoBss();
        clienteBss bssc = new clienteBss();
        public NuevaVentaVista(int idProd, int cantidad, decimal precio, int id)
        {
            InitializeComponent();
            id= idProd;
            cant= cantidad;
            price = precio;
            idper = id;

        }
        ProductoBss bssp = new ProductoBss();
        public static void PasarNombreUser(NuevaVentaVista nuevaVenta, string nombrepasar)
        {
            nuevaVenta.textBox2.Text = nombrepasar; //recibo el nombre del formulario 1 del usuario
        }
        private void NuevaVentaVista_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn Cantidad = new DataGridViewTextBoxColumn();
            Cantidad.HeaderText = "Cantidad";
            dataGridView1.Columns.Add(Cantidad);

            DataGridViewTextBoxColumn Precio = new DataGridViewTextBoxColumn();
            Precio.HeaderText = "Precio";
            dataGridView1.Columns.Add(Precio);

            DataGridViewTextBoxColumn SubTotal = new DataGridViewTextBoxColumn();
            SubTotal.HeaderText = "Subtotal";
            dataGridView1.Columns.Add(SubTotal);
           
            //dataGridView1.DataSource = bss.ListarProductosBss(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteListarVista cliente = new ClienteListarVista();
            if (cliente.ShowDialog() == DialogResult.OK)
            {
                Cliente c = bssc.ObtenerClienteIdBss(idper);
                textBox1.Text = c.idCliente.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EscogerProductoVista producto = new EscogerProductoVista();
            if (producto.ShowDialog() == DialogResult.OK)
            {
                //dataGridView1.DataSource = bssp.ObtenerIdBss(id);
                dataGridView1.DataSource = bss.ListarProductosBss(id);

            }
        }
    }
}
