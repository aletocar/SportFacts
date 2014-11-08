using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFacts
{
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAgregarUsuario_Click(object sender, EventArgs e)
        {
            panelAgregarUsuario.Visible = false;
            panelInicio.Visible = true;
        }

        private void btnConfirmarAgregarUsuario_Click(object sender, EventArgs e)
        {
            //Chequea que existe el usuario y log in
            Usuario u = new Usuario();
            if (rBtnDeportista.Checked) u = new Deportista();
            u.Apellido = txtApellido.Text;
            u.Nombre = txtNombre.Text;
            u.Mail = txtMail.Text;
            u.Password = txtPass.Text;
            u.FechaNac = dtpFechaNac.Value;
            u.Username = txtUsername.Text;

            if (ManejadorUsuarios.AgregarUsuario(u))
            {
                MessageBox.Show("Se agregó el usuario " + txtUsername.Text);
            }
            else
            {
                MessageBox.Show("No se agregó el usuario " + txtUsername.Text);
            }


            panelAgregarUsuario.Visible = false;

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelAgregarUsuario.Visible = true;
        }
    }
}
