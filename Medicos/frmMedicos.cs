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
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void lblModificar_Click(object sender, EventArgs e)
        {

        }

        private void lblEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmVerCitas verCitas = new frmVerCitas();
            verCitas.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmCancelarMedico cancelarMedico = new frmCancelarMedico();
            cancelarMedico.Show();
        }

        private void btnHistorialPaciente_Click(object sender, EventArgs e)
        {
            frmHistorialPaciente historial = new frmHistorialPaciente();
            historial.Show();   
        }
    }
}
