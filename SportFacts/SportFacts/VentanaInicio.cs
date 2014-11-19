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
        PlanDietareo p = new PlanDietareo();
        bool paraTodasEdades = false;
        bool paraTodasIMC = false;
        bool listaConItems = false;
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
            if (rBtnDeportista.Checked) u.tipo = Usuario.Tipo.Deportista;
            else if (rBtnMedico.Checked) u.tipo = Usuario.Tipo.Medico;
            else u.tipo = Usuario.Tipo.Tecnico;
            u.Apellido = txtApellido.Text;
            u.Nombre = txtNombre.Text;
            u.Mail = txtMail.Text;
            u.Password = txtPass.Text;
            u.FechaNac = dtpFechaNac.Value;
            u.Username = txtUsername.Text;

            if (Sistema.GetSistema().AgregarUsuario(u))
            {
                MessageBox.Show("Se agregó el usuario " + txtUsername.Text);
            }
            else
            {
                MessageBox.Show("No se agregó el usuario " + txtUsername.Text);
            }


            panelAgregarUsuario.Visible = false;
            panelInicio.Visible = true;

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelAgregarUsuario.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearIngesta_Click(object sender, EventArgs e)
        {
            Ingesta i = new Ingesta();
            Alimento a = new Alimento() { Nombre = txtAlimento.Text, ValorCalorico = double.Parse(txtValorCalorico.Text) };
            i.Alimentos.Add(new Tuple<Alimento,int>(a, int.Parse(txtCantidad.Text)));
            Sistema.GetSistema().AgregarIngesta(i);
            lbxIngestas.Items.Add(i);
        }

        private void btnAgregarAIngesta_Click(object sender, EventArgs e)
        {
            if (lbxIngestas.SelectedItem != null)
            {
                Ingesta i = (Ingesta)lbxIngestas.SelectedItem;
                Alimento a = new Alimento() { Nombre = txtAlimento.Text, ValorCalorico = double.Parse(txtValorCalorico.Text) };
                i.Alimentos.Add(new Tuple<Alimento, int>(a, int.Parse(txtCantidad.Text)));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            etqFechaFin.Enabled = cbxDuracion.Checked;
            etqFechaInicio.Enabled = cbxDuracion.Checked;
            etqMeses.Enabled = cbxDuracion.Checked;
            txtMeses.Enabled = cbxDuracion.Checked;
            txtDias.Enabled = cbxDuracion.Checked;
            txtSemanas.Enabled = cbxDuracion.Checked;
        }

        private void btnConfirmarIngesta_Click(object sender, EventArgs e)
        {
            if (lbxIngestas.SelectedItem != null)
            {
                Ingesta i = (Ingesta)lbxIngestas.SelectedItem;
                p.Ingestas.Add(new Tuple<Ingesta, PlanDietareo.DiaDeSemana, PlanDietareo.MomentoDelDia>(i, (PlanDietareo.DiaDeSemana)cbxDia.SelectedValue, (PlanDietareo.MomentoDelDia)cbxMomento.SelectedValue));
                lbxIngestas.Items.Remove(i);
                cbxDia.SelectedValue = null;
                cbxMomento.SelectedValue = null;
            }
        }

        private void btnCrearPlan_Click(object sender, EventArgs e)
        {
            InicializarPlan();
        }

        private void panelAgregarPlan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {

            if (txtNombrePlan.Text.Equals(String.Empty) || Sistema.GetSistema().ExistePlanConNombre(txtNombrePlan.Text))
            {
                MessageBox.Show("Nombre Incorrecto. Por favor ingrese nuevamente");
            }
            else if (txtObjetivo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Objetivo Incorrecto. Por favor ingrese nuevamente");
            }//Falta que chequee si selecciono generico o no. CA 1.4
            else if (!paraTodasEdades && (txtEdadMax.Text.Equals(String.Empty) || txtEdadMin.Text.Equals(String.Empty)))
            {
                paraTodasEdades = true;
                MessageBox.Show("Rango etareo no especificado. Se tomara en cuenta que es valido para todas las edades.");
            }
            else if (!paraTodasIMC && (txtIMCMax.Text.Equals(String.Empty) || txtIMCMin.Text.Equals(String.Empty)))
            {
                paraTodasEdades = true;
                MessageBox.Show("Rango IMC no especificado. Se tomara en cuenta que es valido para todos los valores.");
            }
            else if (cbxFrecuencia.SelectedItem == null)
            {
                MessageBox.Show("No se selecciona frecuencia. Se toma en cuenta que es diaria.");
                cbxFrecuencia.SelectedIndex = 0;
            }
            else if (p.Ingestas.Count == 0)
            {
                MessageBox.Show("No se han ingresado Ingestas. Presione cancelar para salir o ingrese ingestas para guardar los cambios.");
            }
            else if (!listaConItems && lbxIngestas.Items.Count > 0)
            {
                listaConItems = true;
                MessageBox.Show("Han quedado ingestas sin ingresar. No se agregaran al plan.");
            }
            else
            {

                p.NombrePlan = txtNombrePlan.Text;
                p.Objetivo = txtObjetivo.Text;
                p.EdadMin = int.Parse(txtEdadMin.Text);
                p.EdadMax = int.Parse(txtEdadMax.Text);
                p.IMCMin = double.Parse(txtIMCMin.Text);
                p.IMCMax = double.Parse(txtIMCMax.Text);

                if (cbxDuracion.Checked)
                    p.Duracion = new TimeSpan(int.Parse(txtDias.Text) + int.Parse(txtSemanas.Text) * 7 + int.Parse(txtMeses.Text) * 30, 0, 0, 0);
                else
                    p.Duracion = TimeSpan.Zero;
                p.Categoria = (PlanDietareo.CategoriaPlan)cbxCategoria.SelectedValue;
                p.Frecuencia = (PlanDietareo.FrecuenciaPlan)cbxFrecuencia.SelectedValue;
                p.Generico = ckbGenerico.Checked;
                InicializarPlan();
            }
        }

        private void InicializarPlan()
        {
            p = new PlanDietareo() { identificador = Sistema.GetSistema().ObtenerNombrePlan() };
            idTxt.Text = p.identificador;
            label10.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            label14.Enabled = true;
            label15.Enabled = true;
            label16.Enabled = true;
            label17.Enabled = true;
            label18.Enabled = true;
            label19.Enabled = true;
            label20.Enabled = true;
            label21.Enabled = true;
            etqFechaFin.Enabled = true;
            etqFechaInicio.Enabled = true;
            etqMeses.Enabled = true;
            ckbGenerico.Enabled = true;
            etqMomento.Enabled = true;
            cbxMomento.Enabled = true;

            txtNombrePlan.Enabled = true;
            txtObjetivo.Enabled = true;
            txtEdadMax.Enabled = true;
            txtEdadMin.Enabled = true;
            txtIMCMax.Enabled = true;
            txtIMCMin.Enabled = true;
            txtAlimento.Enabled = true;
            txtCantidad.Enabled = true;
            txtValorCalorico.Enabled = true;
            txtDias.Enabled = true;
            txtSemanas.Enabled = true;
            txtMeses.Enabled = true;
            cbxCategoria.Enabled = true;
            cbxDuracion.Enabled = true;
            cbxDia.Enabled = true;
            lbxIngestas.Enabled = true;
            btnAgregarAIngesta.Enabled = true;
            btnAgregarPlan.Enabled = true;
            btnCrearIngesta.Enabled = true;
            btnConfirmarIngesta.Enabled = true;
            btnCancelar.Enabled = true;

            btnCrearPlan.Enabled = false;

            p = new PlanDietareo();
            Sistema.GetSistema().AgregarPlan(p);
        }

        public void FinalizarPlan()
        {
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            label13.Enabled = false;
            label14.Enabled = false;
            label15.Enabled = false;
            label16.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label20.Enabled = false;
            label21.Enabled = false;

            etqFechaFin.Enabled = false;
            etqFechaInicio.Enabled = false;
            etqMeses.Enabled = false;
            ckbGenerico.Enabled = false;
            etqMomento.Enabled = false;
            cbxMomento.Enabled = false;

            txtNombrePlan.Enabled = false;
            txtObjetivo.Enabled = false;
            txtEdadMax.Enabled = false;
            txtEdadMin.Enabled = false;
            txtIMCMax.Enabled = false;
            txtIMCMin.Enabled = false;
            txtAlimento.Enabled = false;
            txtCantidad.Enabled = false;
            txtValorCalorico.Enabled = false;
            txtDias.Enabled = false;
            txtSemanas.Enabled = false;
            txtMeses.Enabled = false;
            cbxCategoria.Enabled = false;
            cbxDuracion.Enabled = false;
            cbxDia.Enabled = false;
            lbxIngestas.Enabled = false;
            btnAgregarAIngesta.Enabled = false;
            btnAgregarPlan.Enabled = false;
            btnCrearIngesta.Enabled = false;
            btnConfirmarIngesta.Enabled = false;
            btnCancelar.Enabled = false;

            btnCrearPlan.Enabled = true;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(!Sistema.GetSistema().ExisteUsuario(textBox1.Text)){
                MessageBox.Show("No existe un usuario " + textBox1.Text);
            }
            else if (!Sistema.GetSistema().ContrasenaDeUsuarioCorrecta(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("La contraseña del usuario " + textBox1.Text + " es incorrecta");
            }
            else
            {
                Sistema.GetSistema().Logear(textBox1.Text);
                panelInicio.Visible = false;
                panelPlan.Visible = true;
            }
        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
           listaPlanes.Items.AddRange(Sistema.GetSistema().ObtenerPlanes(IdentificadorBuscarTXT.Text).ToArray());
           if (listaPlanes.Items.Count == 0) MessageBox.Show("No se encontraron planes con esos datos");
        }

        private void listaPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanDietareo p = (PlanDietareo)listaPlanes.SelectedItem;
            nombrePlanBuscarTxt.Text = p.NombrePlan;
            objetivoPlanBuscarTxt.Text = p.Objetivo;
            edadMinimaBuscarTxt.Text = p.EdadMin.ToString();
            edadMaximaBuscarTxt.Text = p.EdadMax.ToString();
            ImcMinBuscarTxt.Text = p.IMCMin.ToString();
            imcMaxBuscarTXT.Text = p.IMCMax.ToString();
            if (p.Duracion != null)
            {
                int dias = p.Duracion.Days;
                int meses = (dias - (dias % 30)) / 30;
                dias = dias % 30;
                int semanas = (dias - (dias % 7)) / 7;
                dias = dias % 7;
                diasBuscarTxt.Text = dias.ToString();
                mesesBuscarTxt.Text = meses.ToString();
                semanasBuscarTxt.Text = semanas.ToString();
                duracionBuscarTxt.Checked = true;
            }
            else
            {
                duracionBuscarTxt.Checked = true;
            }
            categoriasBuscarCbbx.Items.Add(p.Categoria);
            genericoBuscarCbx.Checked = p.Generico;
        }

        private void btnConfirmarBorrarPlan_Click(object sender, EventArgs e)
        {
            if (listaPlanes.SelectedItem != null)
            {
                if (MessageBox.Show("Esta seguro que desea borrar?", "Borrar Plan", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    panelBorrarPlan.Visible = false;
                    listaPlanes.Items.Clear();
                    PlanDietareo p = (PlanDietareo)listaPlanes.SelectedItem;
                    Sistema.GetSistema().PlanesDietareaos.Remove(p);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un plan a borrar");
            }
        }

        private void btnCancelarBorrarPlan_Click(object sender, EventArgs e)
        {
            panelBorrarPlan.Visible = false;
            listaPlanes.Items.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelAgregarPlanDietareo.Visible = false;
            lbxIngestas.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelAsignarPlan.Visible = false;
            deportistasLbx.Items.Clear();
            PlanesAsignadosLbx.Items.Clear();
            PlanesLbx.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            deportistasLbx.Items.AddRange(Sistema.GetSistema().ObtenerDeportistas(nombreDeportistaTxt.Text, apellidoDeportistaTxt.Text));
            if (deportistasLbx.Items.Count == 0) MessageBox.Show("No hay deportistas que cumplan con esos datos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (deportistasLbx.SelectedItem == null)
            {

            }
            else if (PlanesLbx.SelectedItem == null)
            {

            }
            else if (Sistema.GetSistema().PlanNoSirveParaDeportista((Usuario)deportistasLbx.SelectedItem, (PlanDietareo)PlanesLbx.SelectedItem))
            {

            }
            else
            {
                Usuario.PrioridadPlan prio = Usuario.PrioridadPlan.Principal;
                if (rbtnSecundario.Checked) prio = Usuario.PrioridadPlan.Secundario;
                Tuple<PlanDietareo, Usuario.PrioridadPlan> tupla = new Tuple<PlanDietareo, Usuario.PrioridadPlan>((PlanDietareo)PlanesLbx.SelectedItem, prio);
                ((Usuario)deportistasLbx.SelectedItem).ListaPlan.Add(tupla);
            }
        }

        private void deportistasLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario u = (Usuario)deportistasLbx.SelectedItem;
            nombreDeportistaTxt.Text = u.Nombre;
            apellidoDeportistaTxt.Text = u.Apellido;
            usuarioDeportistaTxt.Text = u.Username;
            mailDeportistaTxt.Text = u.Mail;
            fechaNacDeportistaDtp.Value = u.FechaNac;
            //PlanesAsignadosLbx.Items.AddRange(u.ListaPlan);
        }

        private void btnAsignarPlan_Click(object sender, EventArgs e)
        {
            panelAsignarPlan.Visible = true;
        }
    }
}
