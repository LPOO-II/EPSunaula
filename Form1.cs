using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasEpsUNAULA
{
    public partial class frmInicio : Form
    {

        private frmPaciente paciente;
        private frmMedicos medicos;
        public frmInicio()
        {
            InitializeComponent();
            paciente = new frmPaciente();
            medicos = new frmMedicos();

            btnIngresar.Click += btnIngresar_Click;
            paciente.FormClosed += paciente_FormClosed;
            medicos.FormClosed += medicos_FormClosed;
        }
        private void paciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void medicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsVerificar verify = new clsVerificar();


            try
            {
                verify.PacienteID = Convert.ToInt32(txtId.Text);
                verify.Nombre = txtNombre.Text;
                verify.MedicoID = Convert.ToInt32(txtId.Text);

                if (cboTipoUser.SelectedIndex == 1)
                {
                    if (verify.VerificarPaciente() == true)
                    {
                        this.Hide();
                        paciente.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un usuario valido");
                    }
                }
                else if (cboTipoUser.SelectedIndex == 0)
                {
                    if (verify.VerificarMedico() == true)
                    {
                        this.Hide();
                        medicos.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un usuario valido");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR EN EL SISTEMA O NO HA INGRESADO CORRECTAMENTE LOS DATOS PEDIDOS, VERIFIQUE SU TIPO DE USUARIO   " + ex);
            }

        }

        private void btnTerminos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Términos y Condiciones: " +
                "1. Solo para estudio de programación sin fines de lucro. " +
                "2. Datos personales usados solo para coordinar citas médicas. " +
                "3. Información médica es confidencial. " +
                "4. Proporcionado con fines educativos. " +
                "5. No sustituye el asesoramiento médico profesional. " +
                "Al usar esta aplicación, aceptas estos términos.");
        }
    }
}
