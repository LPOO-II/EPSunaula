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
    public partial class frmPedirCita : Form
    {
        public frmPedirCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPedirCita_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            cmbSintomas.Text = string.Empty;
            cmbHoraCita.Text = string.Empty;
            txtIdCita.Text = string.Empty;
            dtpFechaCita.Text = string.Empty;
            dtgConsultaHora.Text = string.Empty;
        }

        private void btnRealizarCita_Click(object sender, EventArgs e)
        {
            clsPedirCita pedirCita = new clsPedirCita();

            try
            {
                pedirCita.PacienteID = Convert.ToInt32(txtIdCita.Text);
                pedirCita.Fecha = dtpFechaCita.Value;
                string tiempo = cmbHoraCita.SelectedItem.ToString();
                pedirCita.Hora = TimeSpan.Parse(tiempo);

                if (cmbSintomas.SelectedIndex == 0)
                {
                    pedirCita.MedicoID = 1234;
                    pedirCita.IngresarCita();
                    MessageBox.Show("Cita ingresada correctamente con medico general, salga del apartado de citas y vuelva a ingresar si quiere ver la disponibilidad de otras citas");

                }
                else if (cmbSintomas.SelectedIndex == 1)
                {
                    pedirCita.MedicoID = 4545;
                    pedirCita.IngresarCita();
                    MessageBox.Show("Cita ingresada correctamente con respiratoria, salga del apartado de citas y vuelva a ingresar si quiere ver la disponibilidad de otras citas");

                }
                else if (cmbSintomas.SelectedIndex == 2)
                {
                    pedirCita.MedicoID = 4848;
                    pedirCita.IngresarCita();
                    MessageBox.Show("Cita ingresada correctamente con un obstetra, salga del apartado de citas y vuelva a ingresar si quiere ver la disponibilidad de otras citas");

                }
                else if (cmbSintomas.SelectedIndex == 3)
                {
                    pedirCita.MedicoID = 5050;
                    pedirCita.IngresarCita();
                    MessageBox.Show("Cita ingresada correctamente con un gastro, salga del apartado de citas y vuelva a ingresar si quiere ver la disponibilidad de otras citas");

                }
                else if (cmbSintomas.SelectedIndex == 4)
                {
                    pedirCita.MedicoID = 6060;
                    pedirCita.IngresarCita();
                    MessageBox.Show("Cita ingresada correctamente con un practicante cualificado, salga del apartado de citas y vuelva a ingresar si quiere ver la disponibilidad de otras citas");

                }
                else
                {
                    MessageBox.Show("Cita no disponible");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("INGRESE BIEN LOS PARAMETROS" + ex);
            }
            finally
            {
                Limpiar();
            }
        }

        private void btnConsultaHora_Click(object sender, EventArgs e)
        {
            clsPedirCita pedirCita = new clsPedirCita();

            try
            {
                pedirCita.Fecha = dtpFechaCita.Value;

                if (cmbSintomas.SelectedIndex == 0)
                {
                    pedirCita.MedicoID = 1234;
                    dtgConsultaHora.DataSource = pedirCita.ConsultarDispo();

                }
                else if (cmbSintomas.SelectedIndex == 1)
                {
                    pedirCita.MedicoID = 4545;
                    dtgConsultaHora.DataSource = pedirCita.ConsultarDispo();

                }
                else if (cmbSintomas.SelectedIndex == 2)
                {
                    pedirCita.MedicoID = 4848;
                    dtgConsultaHora.DataSource = pedirCita.ConsultarDispo();

                }
                else if (cmbSintomas.SelectedIndex == 3)
                {
                    pedirCita.MedicoID = 5050;
                    dtgConsultaHora.DataSource = pedirCita.ConsultarDispo();

                }
                else if (cmbSintomas.SelectedIndex == 4)
                {
                    pedirCita.MedicoID = 6060;
                    dtgConsultaHora.DataSource = pedirCita.ConsultarDispo();

                }
                else
                {
                    MessageBox.Show("Cita no disponible");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR EN EL SISTEMA" + ex);
            }
        }

        private void cmbHoraCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }
    }
}
