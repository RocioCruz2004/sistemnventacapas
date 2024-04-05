using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PersonaVista
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona p = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
            
        }
        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.nombre;
            textBox2.Text = p.apellido;
            textBox3.Text = p.telefono;
            textBox4.Text = p.ci;
            textBox5.Text = p.correo;
        }

        private void button4_Click(object sender, EventArgs e) //btn guardar cambios
        {
            p.idPersona = idx;
            p.nombre = textBox1.Text;
            p.apellido = textBox2.Text;
            p.telefono = textBox3.Text;
            p.ci = textBox4.Text;
            p.correo = textBox5.Text;

            bss.EditarPersonaBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
