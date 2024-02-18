namespace CitasEpsUNAULA
{
    partial class frmHistorialPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialPaciente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultasHisto = new System.Windows.Forms.Button();
            this.dtgConsultaHistorial = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnConsultasHisto);
            this.panel1.Controls.Add(this.txtIdConsulta);
            this.panel1.Controls.Add(this.lblIdConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblIdConsulta.Location = new System.Drawing.Point(5, 56);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(168, 16);
            this.lblIdConsulta.TabIndex = 11;
            this.lblIdConsulta.Text = "INGRESE ID DEL PACIENTE";
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdConsulta.Location = new System.Drawing.Point(3, 75);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(256, 21);
            this.txtIdConsulta.TabIndex = 12;
            // 
            // btnConsultasHisto
            // 
            this.btnConsultasHisto.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultasHisto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultasHisto.BackgroundImage")));
            this.btnConsultasHisto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultasHisto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultasHisto.FlatAppearance.BorderSize = 0;
            this.btnConsultasHisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasHisto.Location = new System.Drawing.Point(90, 310);
            this.btnConsultasHisto.Name = "btnConsultasHisto";
            this.btnConsultasHisto.Size = new System.Drawing.Size(67, 67);
            this.btnConsultasHisto.TabIndex = 13;
            this.btnConsultasHisto.UseVisualStyleBackColor = false;
            this.btnConsultasHisto.Click += new System.EventHandler(this.btnConsultasHisto_Click);
            // 
            // dtgConsultaHistorial
            // 
            this.dtgConsultaHistorial.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgConsultaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaHistorial.Location = new System.Drawing.Point(295, 56);
            this.dtgConsultaHistorial.Name = "dtgConsultaHistorial";
            this.dtgConsultaHistorial.Size = new System.Drawing.Size(493, 321);
            this.dtgConsultaHistorial.TabIndex = 14;
            // 
            // frmHistorialPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultaHistorial);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialPaciente";
            this.Text = "frmHistorialPaciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.TextBox txtIdConsulta;
        private System.Windows.Forms.Button btnConsultasHisto;
        private System.Windows.Forms.DataGridView dtgConsultaHistorial;
    }
}