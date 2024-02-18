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
    public partial class frmPreDiagnostico : Form
    {
        public frmPreDiagnostico()
        {
            InitializeComponent();
        }

        private void btnVerificarPre_Click(object sender, EventArgs e)
        {
            frmCitaPrioritaria prioritaria = new frmCitaPrioritaria();
            
            if (cmbDolor.SelectedIndex >= 6 )
            {
                this.Hide();
                prioritaria.Show();
            }
            else if(cmbDesmayo.SelectedIndex == 0)
            {
                this.Hide();
                prioritaria.Show();
            }
            else if (cmbTiempo.SelectedIndex >= 2)
            {
                this.Hide();
                prioritaria.Show();
            }
            else
            {
                MessageBox.Show("Usted esta en condiciones de pedir una cita normal, por favor regrese a la interfaz de citas y pida una NO prioritaria");
            }
        }
    }
}
