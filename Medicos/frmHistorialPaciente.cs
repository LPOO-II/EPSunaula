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
    public partial class frmHistorialPaciente : Form
    {
        public frmHistorialPaciente()
        {
            InitializeComponent();
        }

        private void btnConsultasHisto_Click(object sender, EventArgs e)
        {
            try
            {
                clsConsultarCitas citas = new clsConsultarCitas();
                citas.PacienteID = Convert.ToInt32(txtIdConsulta.Text);

                dtgConsultaHistorial.DataSource = citas.ConsultarHistorial();
            }
            catch (Exception ex)
            {

                MessageBox.Show("PARAMETROS INCORRECTOS " + ex);
            }
        }
    }
}
