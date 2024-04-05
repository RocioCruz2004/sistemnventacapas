using SistemaVentas.BSS;
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

namespace SistemaVentas.VISTA.ClienteVista
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        clienteBss bss = new clienteBss();
        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClientePersonaBss();
        }

        private void button4_Click(object sender, EventArgs e) //btn seleccionar
        {
            NuevaVentaVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesionVista inicio = new IniciarSesionVista();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e) //btn eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Cliente?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdSeleccionada);
                MessageBox.Show("Eliminado correctamente");
                dataGridView1.DataSource = bss.ListarClientePersonaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e) //btn agregar
        {
            ClienteAgregarVista fr = new ClienteAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientePersonaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e) //btn editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientePersonaBss();
            }
        }
    }
}
