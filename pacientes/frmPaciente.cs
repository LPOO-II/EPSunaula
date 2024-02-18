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
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPedirCita_Click(object sender, EventArgs e)
        {
            frmPedirCita pedirCita = new frmPedirCita();
            frmPaciente paciente = new frmPaciente();

            pedirCita.Show();
            paciente.Hide();
        }

        private void btnPrioritaria_Click(object sender, EventArgs e)
        {
            frmPreDiagnostico preDiagnosticos = new frmPreDiagnostico();
            preDiagnosticos.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmReagendar reagendar = new frmReagendar();
            reagendar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarCita eliminar = new frmEliminarCita();
            eliminar.Show();
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            frmConsultasPciente consultasPciente = new frmConsultasPciente();
            consultasPciente.Show();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
