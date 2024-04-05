using SistemasVentas.DAL;
using SistemaVentas.VISTA.CajeroVista;
using SistemaVentas.VISTA.GerenteVista;
using SistemaVentas.VISTA.SupervisorVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.InicioVista
{
    public partial class IniciarSesionVista : Form
    {
        public IniciarSesionVista()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string rol = comboBox1.Text; //GERENTE, CAJERO, SUPERVISOR

            if (conexion.VerificadorCredencialesGerente(usuario, contraseña, rol))
            {
                MessageBox.Show("Iniciando sesión como GERENTE");
                GerentePrincipalVista formulario = new GerentePrincipalVista();

                formulario.Show();
            }
            else if (conexion.VerificadorCredencialesVendedor(usuario, contraseña, rol))
            {
                string nombreUsuario = textBox1.Text; // Obtener el nombre de usuario 
                CajeroPrincipalVista formulario = new CajeroPrincipalVista();  //instancia de CajeroPrincipalVista

                CajeroPrincipalVista.PasarNombreUser(formulario, nombreUsuario);

                MessageBox.Show("Iniciando sesion como CAJERO");

                formulario.Show();
            }
            else if (conexion.VerificadorCredencialesProveedor(usuario, contraseña, rol))
            {
                MessageBox.Show("Iniciando sesión como PROVEEDOR");
                SupervisorPrincipalVista formulario = new SupervisorPrincipalVista();

                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
