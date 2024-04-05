using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
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
    public partial class PersonaAgregarVista : Form
    {
        public PersonaAgregarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesionVista inicio = new IniciarSesionVista();
            inicio.Show();
        }

        private void button4_Click(object sender, EventArgs e) //btn agregar
        {
            Persona p = new Persona();
            p.nombre = textBox1.Text;
            p.apellido = textBox2.Text;
            p.telefono = textBox3.Text;
            p.ci = textBox4.Text;
            p.correo = textBox5.Text;

            bss.AgregarPersonaBss(p);
            MessageBox.Show("Se guardo correctamente El cliente");
        }
    }
}
