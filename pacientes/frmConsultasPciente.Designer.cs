namespace CitasEpsUNAULA
{
    partial class frmConsultasPciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasPciente));
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.btnConsultasCitas = new System.Windows.Forms.Button();
            this.dtgConsultaCitas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdConsulta.Location = new System.Drawing.Point(114, 138);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(256, 21);
            this.txtIdConsulta.TabIndex = 7;
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblIdConsulta.Location = new System.Drawing.Point(111, 119);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(259, 16);
            this.lblIdConsulta.TabIndex = 6;
            this.lblIdConsulta.Text = "INGRESE SU NUMERO DE IDENTIFICACIÓN";
            // 
            // btnConsultasCitas
            // 
            this.btnConsultasCitas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultasCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultasCitas.BackgroundImage")));
            this.btnConsultasCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultasCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultasCitas.FlatAppearance.BorderSize = 0;
            this.btnConsultasCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasCitas.Location = new System.Drawing.Point(204, 296);
            this.btnConsultasCitas.Name = "btnConsultasCitas";
            this.btnConsultasCitas.Size = new System.Drawing.Size(67, 67);
            this.btnConsultasCitas.TabIndex = 8;
            this.btnConsultasCitas.UseVisualStyleBackColor = false;
            this.btnConsultasCitas.Click += new System.EventHandler(this.btnConsultasCitas_Click);
            // 
            // dtgConsultaCitas
            // 
            this.dtgConsultaCitas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgConsultaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaCitas.Location = new System.Drawing.Point(447, 138);
            this.dtgConsultaCitas.Name = "dtgConsultaCitas";
            this.dtgConsultaCitas.Size = new System.Drawing.Size(244, 227);
            this.dtgConsultaCitas.TabIndex = 9;
            // 
            // frmConsultasPciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 514);
            this.Controls.Add(this.dtgConsultaCitas);
            this.Controls.Add(this.btnConsultasCitas);
            this.Controls.Add(this.txtIdConsulta);
            this.Controls.Add(this.lblIdConsulta);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultasPciente";
            this.Text = "CONSULTAS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdConsulta;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.Button btnConsultasCitas;
        private System.Windows.Forms.DataGridView dtgConsultaCitas;
    }
}