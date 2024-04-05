using SistemaVentas.BSS;
using SistemaVentas.DAL;
using SistemaVentas.VISTA.ClienteVista;
using SistemaVentas.VISTA.InicioVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PersonaVista
{
    public partial class PersonaListarVista : Form
    {
        public PersonaListarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void btnCerrarSesion_Click(object sender, EventArgs e) //cerrar sesion
        {
            IniciarSesionVista inicio = new IniciarSesionVista();
            inicio.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonasBss();
        }

        private void button1_Click(object sender, EventArgs e) //btn eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Cliente?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(IdSeleccionada);
                MessageBox.Show("Eliminado correctamente");
                dataGridView1.DataSource = bss.ListarPersonasBss();
            }
        }

        private void button3_Click(object sender, EventArgs e) //btn agregar
        {
            PersonaAgregarVista agregar = new PersonaAgregarVista();
            if (agregar.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonasBss();
            }
        }

        private void button4_Click(object sender, EventArgs e) //btn seleccionar
        {
            ClienteAgregarVista.IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteAgregarVista.IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void button2_Click(object sender, EventArgs e) //btn editar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonasBss();
            }

        }
    }
}
