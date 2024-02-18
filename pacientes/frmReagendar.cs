using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasEpsUNAULA
{
    public partial class frmReagendar : Form
    {
        public frmReagendar()
        {
            InitializeComponent();
        }

        private void btnConsultaHora_Click(object sender, EventArgs e)
        {
            clsPedirCita pedirCita = new clsPedirCita();

            try
            {
                pedirCita.Fecha = dtpFechaReagenda.Value;

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

        private void btnRealizarReagenda_Click(object sender, EventArgs e)
        {
            try
            {
                clsCancelarCita cancel = new clsCancelarCita();
                clsPedirCita pedir = new clsPedirCita();

                pedir.PacienteID = Convert.ToInt32(txtIdReagenda.Text);
                pedir.Fecha = dtpFechaReagenda.Value;
                string tiempo = cmbHoraReagenda.SelectedItem.ToString();
                pedir.Hora = TimeSpan.Parse(tiempo);

                cancel.EliminarCita(Convert.ToInt16(txtIdCitaRe.Text), Convert.ToInt32(txtIdReagenda.Text));
                if (cmbSintomas.SelectedIndex == 0)
                {
                    pedir.MedicoID = 1234;
                    pedir.IngresarCita();
                    MessageBox.Show("reagendada, recuerde que como se reagendo no deberá pagar nada");

                }
                else if (cmbSintomas.SelectedIndex == 1)
                {
                    pedir.MedicoID = 4545;
                    pedir.IngresarCita();
                    MessageBox.Show("reagendada, recuerde que como se reagendo no deberá pagar nada");

                }
                else if (cmbSintomas.SelectedIndex == 2)
                {
                    pedir.MedicoID = 4848;
                    pedir.IngresarCita();
                    MessageBox.Show("reagendada, recuerde que como se reagendo no deberá pagar nada");

                }
                else if (cmbSintomas.SelectedIndex == 3)
                {
                    pedir.MedicoID = 5050;
                    pedir.IngresarCita();
                    MessageBox.Show("reagendada, recuerde que como se reagendo no deberá pagar nada");

                }
                else if (cmbSintomas.SelectedIndex == 4)
                {
                    pedir.MedicoID = 6060;
                    pedir.IngresarCita();
                    MessageBox.Show("reagendada, recuerde que como se reagendo no deberá pagar nada");

                }
                else
                {
                    MessageBox.Show("Cita no disponible");
                }

           
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN SUS DATOS O EL SISTEMA" + ex);
            }
            finally
            {
                txtIdCitaRe.Text = string.Empty;
                txtIdReagenda.Text = string.Empty;
                dtpFechaReagenda.Text = string.Empty;
                cmbHoraReagenda.Text = string.Empty;
                cmbSintomas.Text = string.Empty;

            }
        }
    }
}
