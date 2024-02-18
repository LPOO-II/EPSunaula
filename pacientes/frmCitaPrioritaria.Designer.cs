namespace CitasEpsUNAULA
{
    partial class frmCitaPrioritaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitaPrioritaria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.btnRealizarPriori = new System.Windows.Forms.Button();
            this.lblPedirCita = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHora)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(34, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 323);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtgConsultaHora);
            this.panel2.Controls.Add(this.btnConsultaHora);
            this.panel2.Controls.Add(this.lblConsultaHora);
            this.panel2.Controls.Add(this.cmbHoraCita);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.dtpFechaCita);
            this.panel2.Controls.Add(this.lblFechaCita);
            this.panel2.Controls.Add(this.txtIdCita);
            this.panel2.Controls.Add(this.lblIdCita);
            this.panel2.Controls.Add(this.lblDatos);
            this.panel2.Location = new System.Drawing.Point(527, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 456);
            this.panel2.TabIndex = 2;
            // 
            // dtgConsultaHora
            // 
            this.dtgConsultaHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaHora.Location = new System.Drawing.Point(123, 281);
            this.dtgConsultaHora.Name = "dtgConsultaHora";
            this.dtgConsultaHora.Size = new System.Drawing.Size(299, 90);
            this.dtgConsultaHora.TabIndex = 11;
            this.dtgConsultaHora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConsultaHora
            // 
            this.btnConsultaHora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaHora.BackgroundImage")));
            this.btnConsultaHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultaHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaHora.FlatAppearance.BorderSize = 0;
            this.btnConsultaHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaHora.Location = new System.Drawing.Point(242, 238);
            this.btnConsultaHora.Name = "btnConsultaHora";
            this.btnConsultaHora.Size = new System.Drawing.Size(46, 37);
            this.btnConsultaHora.TabIndex = 10;
            this.btnConsultaHora.UseVisualStyleBackColor = true;
            this.btnConsultaHora.Click += new System.EventHandler(this.btnConsultaHora_Click);
            // 
            // lblConsultaHora
            // 
            this.lblConsultaHora.AutoSize = true;
            this.lblConsultaHora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaHora.ForeColor = System.Drawing.Color.Black;
            this.lblConsultaHora.Location = new System.Drawing.Point(97, 219);
            this.lblConsultaHora.Name = "lblConsultaHora";
            this.lblConsultaHora.Size = new System.Drawing.Size(328, 16);
            this.lblConsultaHora.TabIndex = 9;
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
            this.cmbHoraCita.Location = new System.Drawing.Point(207, 407);
            this.cmbHoraCita.Name = "cmbHoraCita";
            this.cmbHoraCita.Size = new System.Drawing.Size(121, 21);
            this.cmbHoraCita.TabIndex = 8;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(132, 388);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(293, 16);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "INGRESE LA HORA EN LA QUE QUIERE LA CITA";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(204, 141);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaCita.TabIndex = 6;
            this.dtpFechaCita.Value = new System.DateTime(2024, 2, 15, 0, 0, 0, 0);
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCita.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCita.Location = new System.Drawing.Point(129, 122);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(296, 16);
            this.lblFechaCita.TabIndex = 5;
            this.lblFechaCita.Text = "INGRESE LA FECHA EN LA QUE QUIERE LA CITA";
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
            this.lblIdCita.ForeColor = System.Drawing.Color.Black;
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
            this.lblDatos.ForeColor = System.Drawing.Color.Black;
            this.lblDatos.Location = new System.Drawing.Point(201, 14);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(134, 16);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.Text = "DATOS REQUERIDOS";
            // 
            // btnRealizarPriori
            // 
            this.btnRealizarPriori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRealizarPriori.BackgroundImage")));
            this.btnRealizarPriori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRealizarPriori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarPriori.FlatAppearance.BorderSize = 0;
            this.btnRealizarPriori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPriori.Location = new System.Drawing.Point(749, 474);
            this.btnRealizarPriori.Name = "btnRealizarPriori";
            this.btnRealizarPriori.Size = new System.Drawing.Size(100, 74);
            this.btnRealizarPriori.TabIndex = 3;
            this.btnRealizarPriori.UseVisualStyleBackColor = true;
            this.btnRealizarPriori.Click += new System.EventHandler(this.btnRealizarPriori_Click);
            // 
            // lblPedirCita
            // 
            this.lblPedirCita.AutoSize = true;
            this.lblPedirCita.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedirCita.ForeColor = System.Drawing.Color.Black;
            this.lblPedirCita.Location = new System.Drawing.Point(717, 551);
            this.lblPedirCita.Name = "lblPedirCita";
            this.lblPedirCita.Size = new System.Drawing.Size(169, 16);
            this.lblPedirCita.TabIndex = 4;
            this.lblPedirCita.Text = "PEDIR CITA PRIORITARIA";
            // 
            // frmCitaPrioritaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1134, 595);
            this.Controls.Add(this.lblPedirCita);
            this.Controls.Add(this.btnRealizarPriori);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCitaPrioritaria";
            this.Text = "Cita Prioritaria";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbHoraCita;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label lblIdCita;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnRealizarPriori;
        private System.Windows.Forms.Label lblPedirCita;
        private System.Windows.Forms.DataGridView dtgConsultaHora;
        private System.Windows.Forms.Button btnConsultaHora;
        private System.Windows.Forms.Label lblConsultaHora;
    }
}