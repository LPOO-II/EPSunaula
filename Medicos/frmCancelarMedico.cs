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
    public partial class frmCancelarMedico : Form
    {
        public frmCancelarMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                clsCancelarCita cancel = new clsCancelarCita();

                cancel.EliminarCitaMedico(Convert.ToInt16(txtIdCitaCancel.Text), Convert.ToInt32(txtIdCancel.Text));
                MessageBox.Show("Cancelada, recuerde informar al paciente sobre su cancelacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN SUS DATOS O EL SISTEMA" + ex);
            }
            finally
            {
                txtIdCancel.Text = string.Empty;
                txtIdCitaCancel.Text = string.Empty;
            }
        }
    }
}
