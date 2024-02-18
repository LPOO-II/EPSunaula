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
    public partial class frmCitaPrioritaria : Form
    {
        public frmCitaPrioritaria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRealizarPriori_Click(object sender, EventArgs e)
        {
            clsPedirCita pedirCita = new clsPedirCita();

            try
            {
                pedirCita.PacienteID = Convert.ToInt32(txtIdCita.Text);
                pedirCita.Fecha = dtpFechaCita.Value;
                string tiempo = cmbHoraCita.SelectedItem.ToString();
                pedirCita.Hora = TimeSpan.Parse(tiempo);
                pedirCita.MedicoID = 2214;

                pedirCita.IngresarCita();
                MessageBox.Show("Cita con prioridad ingresada, si los sintomas son insoportables acuda a urgencias");


            }
            catch (Exception ex)
            {

                MessageBox.Show("datos incorrectos" + ex);
            }
        }

        private void btnConsultaHora_Click(object sender, EventArgs e)
        {
            clsPedirCita pedirCita = new clsPedirCita();

            try
            {
                pedirCita.MedicoID = 2214;
                pedirCita.Fecha = dtpFechaCita.Value;

                dtgConsultaHora.DataSource = pedirCita.ConsultarDispo();
            }
            catch (Exception ex)
            {

                MessageBox.Show("DATOS INGRESADOS INCORRECTAMENTE" + ex);
            }
        }
    }
}
