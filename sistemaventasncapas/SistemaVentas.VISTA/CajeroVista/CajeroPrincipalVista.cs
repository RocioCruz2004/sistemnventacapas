using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
using SistemaVentas.VISTA.ClienteVista;
using SistemaVentas.VISTA.InicioVista;
using SistemaVentas.VISTA.VentaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.CajeroVista
{
    public partial class CajeroPrincipalVista : Form
    {
        UsuarioBss bss = new UsuarioBss();
        public static void PasarNombreUser(CajeroPrincipalVista cajeronombre, string nombrepasar)
        {
            cajeronombre.textBox1.Text = nombrepasar; //recibo el nombre del formulario 1 del usuario
        }

        public CajeroPrincipalVista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesionVista ventanaPrincipal = new IniciarSesionVista();
            ventanaPrincipal.Show();
        }

        private void CajeroPrincipalVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentasDetalleVentasBss();
        }

        private void button2_Click(object sender, EventArgs e) //btn agregar venta
        {
            int id = 0, cant = 0, idper=0;
            decimal price = 0;
            NuevaVentaVista nuevaVenta = new NuevaVentaVista(id, cant, price, idper);
            string nombreuser= textBox1.Text;
            NuevaVentaVista.PasarNombreUser(nuevaVenta, nombreuser);
            if (nuevaVenta.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasDetalleVentasBss();
            }
        }

        private void button1_Click(object sender, EventArgs e) //btn editar venta
        {
            /*int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarVentaVista fr = new EditarVentaVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasDetalleVentasBss();
            }*/
        }

        private void button3_Click(object sender, EventArgs e) //btn eliminar venta
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Cliente?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                /*bss.EliminarClienteBss(IdSeleccionada);*/
                dataGridView1.DataSource = bss.ListarVentasDetalleVentasBss();
            }
        }
    }
}
