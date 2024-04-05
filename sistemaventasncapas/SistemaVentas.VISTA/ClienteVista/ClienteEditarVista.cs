using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
using SistemaVentas.VISTA.PersonaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.ClienteVista
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente p = new Cliente();
        clienteBss bss = new clienteBss();
        PersonaBss bssper = new PersonaBss();
        public static int IdPersonaSeleccionada = 0;
        public static int IdClienteSeleccionado = 0;
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerClienteIdBss(idx);
            textBox1.Text = p.tipoCliente;
            comboBox1.SelectedItem = p.tipoCliente;
            textBox2.Text = p.codigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssper.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.nombre + " " + persona.apellido;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.idPersona = IdPersonaSeleccionada;
            p.tipoCliente = comboBox1.SelectedItem.ToString();
            p.codigoCliente = textBox2.Text;

            bss.EditarClienteBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
