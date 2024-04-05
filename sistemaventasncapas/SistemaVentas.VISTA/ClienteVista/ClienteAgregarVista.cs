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
    public partial class ClienteAgregarVista : Form
    {
        public static int IdSeleccionado = 0;
        PersonaBss bssuser = new PersonaBss();
        clienteBss bss = new clienteBss();
        public ClienteAgregarVista()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) //btn escoger persona
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = bssuser.ObtenerIdBss(IdSeleccionado);
                textBox1.Text = p.nombre + " " + p.apellido;
            }
        }

        private void button4_Click(object sender, EventArgs e) //btn agregar
        {
            Cliente cliente = new Cliente();
            cliente.idPersona = IdSeleccionado;
            cliente.tipoCliente = comboBox1.SelectedIndex.ToString();
            cliente.codigoCliente = textBox2.Text;

            bss.InsertarClienteBss(cliente);
            MessageBox.Show("Se guardo correctamente El cliente");
        }

        private void ClienteAgregarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
