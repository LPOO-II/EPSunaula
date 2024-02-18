namespace CitasEpsUNAULA
{
    partial class frmPedirCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedirCita));
            this.panelImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgConsultaHora = new System.Windows.Forms.DataGridView();
            this.btnConsultaHora = new System.Windows.Forms.Button();
            this.lblConsultaHora = new System.Windows.Forms.Label();
            this.cmbHoraCita = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.lblIdCita = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cmbSintomas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRealizarCita = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHora)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImage.BackgroundImage")));
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImage.Location = new System.Drawing.Point(12, 112);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(463, 277);
            this.panelImage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgConsultaHora);
            this.panel1.Controls.Add(this.btnConsultaHora);
            this.panel1.Controls.Add(this.lblConsultaHora);
            this.panel1.Controls.Add(this.cmbHoraCita);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.dtpFechaCita);
            this.panel1.Controls.Add(this.lblFechaCita);
            this.panel1.Controls.Add(this.txtIdCita);
            this.panel1.Controls.Add(this.lblIdCita);
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Location = new System.Drawing.Point(535, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 431);
            this.panel1.TabIndex = 1;
            // 
            // dtgConsultaHora
            // 
            this.dtgConsultaHora.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dtgConsultaHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaHora.Location = new System.Drawing.Point(127, 259);
            this.dtgConsultaHora.Name = "dtgConsultaHora";
            this.dtgConsultaHora.Size = new System.Drawing.Size(299, 90);
            this.dtgConsultaHora.TabIndex = 14;
            // 
            // btnConsultaHora
            // 
            this.btnConsultaHora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaHora.BackgroundImage")));
            this.btnConsultaHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultaHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaHora.FlatAppearance.BorderSize = 0;
            this.btnConsultaHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaHora.Location = new System.Drawing.Point(258, 204);
            this.btnConsultaHora.Name = "btnConsultaHora";
            this.btnConsultaHora.Size = new System.Drawing.Size(46, 37);
            this.btnConsultaHora.TabIndex = 13;
            this.btnConsultaHora.UseVisualStyleBackColor = true;
            this.btnConsultaHora.Click += new System.EventHandler(this.btnConsultaHora_Click);
            // 
            // lblConsultaHora
            // 
            this.lblConsultaHora.AutoSize = true;
            this.lblConsultaHora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaHora.ForeColor = System.Drawing.Color.White;
            this.lblConsultaHora.Location = new System.Drawing.Point(113, 185);
            this.lblConsultaHora.Name = "lblConsultaHora";
            this.lblConsultaHora.Size = new System.Drawing.Size(328, 16);
            this.lblConsultaHora.TabIndex = 12;
            this.lblConsultaHora.Text = "CONSULTE LAS HORAS DISPONIBLES PARA ESE DIA";
            // 
            // cmbHoraCita
            // 
            this.cmbHoraCita.FormattingEnabled = true;
            this.cmbHoraCita.Items.AddRange(new object[] {
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "14:00:00"});
            this.cmbHoraCita.Location = new System.Drawing.Point(201, 382);
            this.cmbHoraCita.Name = "cmbHoraCita";
            this.cmbHoraCita.Size = new System.Drawing.Size(121, 21);
            this.cmbHoraCita.TabIndex = 8;
            this.cmbHoraCita.SelectedIndexChanged += new System.EventHandler(this.cmbHoraCita_SelectedIndexChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(126, 363);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(293, 16);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "INGRESE LA HORA EN LA QUE QUIERE LA CITA";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(201, 120);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(121, 21);
            this.dtpFechaCita.TabIndex = 6;
            this.dtpFechaCita.Value = new System.DateTime(2024, 2, 15, 0, 0, 0, 0);
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCita.ForeColor = System.Drawing.Color.White;
            this.lblFechaCita.Location = new System.Drawing.Point(126, 101);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(296, 16);
            this.lblFechaCita.TabIndex = 5;
            this.lblFechaCita.Text = "INGRESE LA FECHA EN LA QUE QUIERE LA CITA";
            this.lblFechaCita.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdCita
            // 
            this.txtIdCita.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCita.Location = new System.Drawing.Point(148, 66);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(256, 21);
            this.txtIdCita.TabIndex = 4;
            // 
            // lblIdCita
            // 
            this.lblIdCita.AutoSize = true;
            this.lblIdCita.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCita.ForeColor = System.Drawing.Color.White;
            this.lblIdCita.Location = new System.Drawing.Point(145, 47);
            this.lblIdCita.Name = "lblIdCita";
            this.lblIdCita.Size = new System.Drawing.Size(259, 16);
            this.lblIdCita.TabIndex = 3;
            this.lblIdCita.Text = "INGRESE SU NUMERO DE IDENTIFICACIÓN";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.White;
            this.lblDatos.Location = new System.Drawing.Point(201, 14);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(134, 16);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.Text = "DATOS REQUERIDOS";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.Color.White;
            this.lblOpcion.Location = new System.Drawing.Point(113, 31);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(293, 16);
            this.lblOpcion.TabIndex = 9;
            this.lblOpcion.Text = "SELECCIONE EL ESPECIALISTA PARA SU CASO";
            this.lblOpcion.Click += new System.EventHandler(this.label2_Click);
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
            this.cmbSintomas.Location = new System.Drawing.Point(84, 50);
            this.cmbSintomas.Name = "cmbSintomas";
            this.cmbSintomas.Size = new System.Drawing.Size(348, 21);
            this.cmbSintomas.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "(NOTA: RECUERDE QUE SI ELIGE PRACTICANTE O GENERAL PUEDE HABER MAS DISPONIBILIDAD" +
    ")";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblOpcion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbSintomas);
            this.panel2.Location = new System.Drawing.Point(535, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 117);
            this.panel2.TabIndex = 12;
            // 
            // btnRealizarCita
            // 
            this.btnRealizarCita.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRealizarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarCita.FlatAppearance.BorderSize = 0;
            this.btnRealizarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarCita.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarCita.Location = new System.Drawing.Point(155, 511);
            this.btnRealizarCita.Name = "btnRealizarCita";
            this.btnRealizarCita.Size = new System.Drawing.Size(195, 55);
            this.btnRealizarCita.TabIndex = 13;
            this.btnRealizarCita.Text = "PEDIR CITA";
            this.btnRealizarCita.UseVisualStyleBackColor = false;
            this.btnRealizarCita.Click += new System.EventHandler(this.btnRealizarCita_Click);
            // 
            // frmPedirCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1134, 595);
            this.Controls.Add(this.btnRealizarCita);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImage);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedirCita";
            this.Text = "Solicitud de Citas";
            this.Load += new System.EventHandler(this.frmPedirCita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHora)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label lblIdCita;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cmbSintomas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRealizarCita;
        private System.Windows.Forms.DataGridView dtgConsultaHora;
        private System.Windows.Forms.Button btnConsultaHora;
        private System.Windows.Forms.Label lblConsultaHora;
        private System.Windows.Forms.ComboBox cmbHoraCita;
    }
}