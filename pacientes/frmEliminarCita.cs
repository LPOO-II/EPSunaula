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
    public partial class frmEliminarCita : Form
    {
        public frmEliminarCita()
        {
            InitializeComponent();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            try
            {
                clsCancelarCita cancel = new clsCancelarCita();

                cancel.EliminarCita(Convert.ToInt16(txtIdCita.Text), Convert.ToInt32(txtIdCancel.Text));
                MessageBox.Show("Cancelada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN SUS DATOS O EL SISTEMA" + ex);
            }
            finally
            {
               txtIdCancel.Text = string.Empty;
                txtIdCita.Text = string.Empty;
            }
        }
    }
}
