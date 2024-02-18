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
    public partial class frmVerCitas : Form
    {
        public frmVerCitas()
        {
            InitializeComponent();
        }

        private void btnConsultasCitas_Click(object sender, EventArgs e)
        {
            try
            {
                clsConsultarCitas citas = new clsConsultarCitas();
                citas.MedicoID = Convert.ToInt32(txtIdConsulta.Text);

                dtgConsultaCitas.DataSource = citas.ConsultarLaCita();
            }
            catch (Exception ex)
            {

                MessageBox.Show("PARAMETROS INCORRECTOS " + ex);
            }
        }
    }
}
