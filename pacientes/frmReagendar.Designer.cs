namespace CitasEpsUNAULA
{
    partial class frmReagendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReagendar));
            this.lblIdReagenda = new System.Windows.Forms.Label();
            this.txtIdReagenda = new System.Windows.Forms.TextBox();
            this.lblIdCitaRe = new System.Windows.Forms.Label();
            this.txtIdCitaRe = new System.Windows.Forms.TextBox();
            this.cmbHoraReagenda = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpFechaReagenda = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReagenda = new System.Windows.Forms.Label();
            this.btnRealizarReagenda = new System.Windows.Forms.Button();
            this.dtgConsultaHora = new System.Windows.Forms.DataGridView();
            this.btnConsultaHora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cmbSintomas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdReagenda
            // 
            this.lblIdReagenda.AutoSize = true;
            this.lblIdReagenda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdReagenda.ForeColor = System.Drawing.Color.Black;
            this.lblIdReagenda.Location = new System.Drawing.Point(62, 77);
            this.lblIdReagenda.Name = "lblIdReagenda";
            this.lblIdReagenda.Size = new System.Drawing.Size(259, 16);
            this.lblIdReagenda.TabIndex = 4;
            this.lblIdReagenda.Text = "INGRESE SU NUMERO DE IDENTIFICACIÓN";
            // 
            // txtIdReagenda
            // 
            this.txtIdReagenda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdReagenda.Location = new System.Drawing.Point(65, 96);
            this.txtIdReagenda.Name = "txtIdReagenda";
            this.txtIdReagenda.Size = new System.Drawing.Size(256, 21);
            this.txtIdReagenda.TabIndex = 5;
            // 
            // lblIdCitaRe
            // 
            this.lblIdCitaRe.AutoSize = true;
            this.lblIdCitaRe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCitaRe.ForeColor = System.Drawing.Color.Black;
            this.lblIdCitaRe.Location = new System.Drawing.Point(62, 120);
            this.lblIdCitaRe.Name = "lblIdCitaRe";
            this.lblIdCitaRe.Size = new System.Drawing.Size(226, 16);
            this.lblIdCitaRe.TabIndex = 6;
            this.lblIdCitaRe.Text = "INGRESE EL NUMERO ID DE LA CITA";
            // 
            // txtIdCitaRe
            // 
            this.txtIdCitaRe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCitaRe.Location = new System.Drawing.Point(65, 139);
            this.txtIdCitaRe.Name = "txtIdCitaRe";
            this.txtIdCitaRe.Size = new System.Drawing.Size(119, 21);
            this.txtIdCitaRe.TabIndex = 7;
            // 
            // cmbHoraReagenda
            // 
            this.cmbHoraReagenda.FormattingEnabled = true;
            this.cmbHoraReagenda.Items.AddRange(new object[] {
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "14:00:00"});
            this.cmbHoraReagenda.Location = new System.Drawing.Point(137, 448);
            this.cmbHoraReagenda.Name = "cmbHoraReagenda";
            this.cmbHoraReagenda.Size = new System.Drawing.Size(121, 21);
            this.cmbHoraReagenda.TabIndex = 12;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(62, 429);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(293, 16);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "INGRESE LA HORA EN LA QUE QUIERE LA CITA";
            // 
            // dtpFechaReagenda
            // 
            this.dtpFechaReagenda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReagenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReagenda.Location = new System.Drawing.Point(122, 192);
            this.dtpFechaReagenda.Name = "dtpFechaReagenda";
            this.dtpFechaReagenda.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaReagenda.TabIndex = 10;
            this.dtpFechaReagenda.Value = new System.DateTime(2024, 2, 15, 0, 0, 0, 0);
            // 
            // lblFechaReagenda
            // 
            this.lblFechaReagenda.AutoSize = true;
            this.lblFechaReagenda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReagenda.ForeColor = System.Drawing.Color.Black;
            this.lblFechaReagenda.Location = new System.Drawing.Point(59, 173);
            this.lblFechaReagenda.Name = "lblFechaReagenda";
            this.lblFechaReagenda.Size = new System.Drawing.Size(296, 16);
            this.lblFechaReagenda.TabIndex = 9;
            this.lblFechaReagenda.Text = "INGRESE LA FECHA EN LA QUE QUIERE LA CITA";
            // 
            // btnRealizarReagenda
            // 
            this.btnRealizarReagenda.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRealizarReagenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarReagenda.FlatAppearance.BorderSize = 0;
            this.btnRealizarReagenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarReagenda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarReagenda.Location = new System.Drawing.Point(109, 488);
            this.btnRealizarReagenda.Name = "btnRealizarReagenda";
            this.btnRealizarReagenda.Size = new System.Drawing.Size(195, 55);
            this.btnRealizarReagenda.TabIndex = 14;
            this.btnRealizarReagenda.Text = "REAGENDAR";
            this.btnRealizarReagenda.UseVisualStyleBackColor = false;
            this.btnRealizarReagenda.Click += new System.EventHandler(this.btnRealizarReagenda_Click);
            // 
            // dtgConsultaHora
            // 
            this.dtgConsultaHora.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dtgConsultaHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaHora.Location = new System.Drawing.Point(65, 321);
            this.dtgConsultaHora.Name = "dtgConsultaHora";
            this.dtgConsultaHora.Size = new System.Drawing.Size(299, 90);
            this.dtgConsultaHora.TabIndex = 16;
            // 
            // btnConsultaHora
            // 
            this.btnConsultaHora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaHora.BackgroundImage")));
            this.btnConsultaHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultaHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaHora.FlatAppearance.BorderSize = 0;
            this.btnConsultaHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaHora.Location = new System.Drawing.Point(275, 283);
            this.btnConsultaHora.Name = "btnConsultaHora";
            this.btnConsultaHora.Size = new System.Drawing.Size(46, 32);
            this.btnConsultaHora.TabIndex = 15;
            this.btnConsultaHora.UseVisualStyleBackColor = true;
            this.btnConsultaHora.Click += new System.EventHandler(this.btnConsultaHora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "CONSULTE DISPONIBILIDAD";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.Color.Black;
            this.lblOpcion.Location = new System.Drawing.Point(91, 226);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(293, 16);
            this.lblOpcion.TabIndex = 18;
            this.lblOpcion.Text = "SELECCIONE EL ESPECIALISTA PARA SU CASO";
            // 
            // cmbSintomas
            // 
            this.cmbSintomas.FormattingEnabled = true;
            this.cmbSintomas.Items.AddRange(new object[] {
            "GENERAL",
            "RESPIRATORIO",
            "OBSTETRA",
            "GASTRO",
            "PRACTICANTE CUALIFICADO"});
            this.cmbSintomas.Location = new System.Drawing.Point(62, 245);
            this.cmbSintomas.Name = "cmbSintomas";
            this.cmbSintomas.Size = new System.Drawing.Size(348, 21);
            this.cmbSintomas.TabIndex = 19;
            // 
            // frmReagendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 751);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.cmbSintomas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgConsultaHora);
            this.Controls.Add(this.btnConsultaHora);
            this.Controls.Add(this.btnRealizarReagenda);
            this.Controls.Add(this.cmbHoraReagenda);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dtpFechaReagenda);
            this.Controls.Add(this.lblFechaReagenda);
            this.Controls.Add(this.txtIdCitaRe);
            this.Controls.Add(this.lblIdCitaRe);
            this.Controls.Add(this.txtIdReagenda);
            this.Controls.Add(this.lblIdReagenda);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReagendar";
            this.Text = "Reagendar Cita";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdReagenda;
        private System.Windows.Forms.TextBox txtIdReagenda;
        private System.Windows.Forms.Label lblIdCitaRe;
        private System.Windows.Forms.TextBox txtIdCitaRe;
        private System.Windows.Forms.ComboBox cmbHoraReagenda;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFechaReagenda;
        private System.Windows.Forms.Label lblFechaReagenda;
        private System.Windows.Forms.Button btnRealizarReagenda;
        private System.Windows.Forms.DataGridView dtgConsultaHora;
        private System.Windows.Forms.Button btnConsultaHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cmbSintomas;
    }
}