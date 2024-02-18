namespace CitasEpsUNAULA
{
    partial class frmPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnConsultarCitas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrioritaria = new System.Windows.Forms.Label();
            this.btnPrioritaria = new System.Windows.Forms.Button();
            this.panelCita = new System.Windows.Forms.Panel();
            this.lblPedirCita = new System.Windows.Forms.Label();
            this.btnPedirCita = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelPrincipal.Controls.Add(this.panel4);
            this.panelPrincipal.Controls.Add(this.panel3);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Controls.Add(this.panelCita);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrincipal.Location = new System.Drawing.Point(606, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(406, 595);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblConsulta);
            this.panel4.Controls.Add(this.btnConsultarCitas);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(30, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 117);
            this.panel4.TabIndex = 10;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(9, 18);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(123, 16);
            this.lblConsulta.TabIndex = 1;
            this.lblConsulta.Text = "CONSULTAR CITAS";
            // 
            // btnConsultarCitas
            // 
            this.btnConsultarCitas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConsultarCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarCitas.BackgroundImage")));
            this.btnConsultarCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultarCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarCitas.FlatAppearance.BorderSize = 0;
            this.btnConsultarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCitas.Location = new System.Drawing.Point(33, 37);
            this.btnConsultarCitas.Name = "btnConsultarCitas";
            this.btnConsultarCitas.Size = new System.Drawing.Size(72, 61);
            this.btnConsultarCitas.TabIndex = 0;
            this.btnConsultarCitas.UseVisualStyleBackColor = false;
            this.btnConsultarCitas.Click += new System.EventHandler(this.btnConsultarCitas_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblEliminar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Location = new System.Drawing.Point(235, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 117);
            this.panel3.TabIndex = 9;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.White;
            this.lblEliminar.Location = new System.Drawing.Point(21, 11);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(108, 16);
            this.lblEliminar.TabIndex = 8;
            this.lblEliminar.Text = "CANCELAR CITA";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(24, 30);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 67);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblModificar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Location = new System.Drawing.Point(30, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 118);
            this.panel2.TabIndex = 8;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.White;
            this.lblModificar.Location = new System.Drawing.Point(15, 17);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(118, 16);
            this.lblModificar.TabIndex = 7;
            this.lblModificar.Text = "REAGENDAR CITA";
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(38, 37);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 78);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPrioritaria);
            this.panel1.Controls.Add(this.btnPrioritaria);
            this.panel1.Location = new System.Drawing.Point(30, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 111);
            this.panel1.TabIndex = 5;
            // 
            // lblPrioritaria
            // 
            this.lblPrioritaria.AutoSize = true;
            this.lblPrioritaria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioritaria.ForeColor = System.Drawing.Color.White;
            this.lblPrioritaria.Location = new System.Drawing.Point(5, 6);
            this.lblPrioritaria.Name = "lblPrioritaria";
            this.lblPrioritaria.Size = new System.Drawing.Size(127, 16);
            this.lblPrioritaria.TabIndex = 4;
            this.lblPrioritaria.Text = "CITA PRIORITARIA";
            // 
            // btnPrioritaria
            // 
            this.btnPrioritaria.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrioritaria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrioritaria.BackgroundImage")));
            this.btnPrioritaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrioritaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrioritaria.FlatAppearance.BorderSize = 0;
            this.btnPrioritaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrioritaria.Location = new System.Drawing.Point(33, 25);
            this.btnPrioritaria.Name = "btnPrioritaria";
            this.btnPrioritaria.Size = new System.Drawing.Size(76, 74);
            this.btnPrioritaria.TabIndex = 3;
            this.btnPrioritaria.UseVisualStyleBackColor = false;
            this.btnPrioritaria.Click += new System.EventHandler(this.btnPrioritaria_Click);
            // 
            // panelCita
            // 
            this.panelCita.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCita.Controls.Add(this.lblPedirCita);
            this.panelCita.Controls.Add(this.btnPedirCita);
            this.panelCita.ForeColor = System.Drawing.Color.White;
            this.panelCita.Location = new System.Drawing.Point(30, 164);
            this.panelCita.Name = "panelCita";
            this.panelCita.Size = new System.Drawing.Size(141, 117);
            this.panelCita.TabIndex = 2;
            this.panelCita.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblPedirCita
            // 
            this.lblPedirCita.AutoSize = true;
            this.lblPedirCita.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedirCita.Location = new System.Drawing.Point(30, 18);
            this.lblPedirCita.Name = "lblPedirCita";
            this.lblPedirCita.Size = new System.Drawing.Size(79, 16);
            this.lblPedirCita.TabIndex = 1;
            this.lblPedirCita.Text = "PEDIR CITA";
            // 
            // btnPedirCita
            // 
            this.btnPedirCita.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPedirCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedirCita.BackgroundImage")));
            this.btnPedirCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPedirCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedirCita.FlatAppearance.BorderSize = 0;
            this.btnPedirCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedirCita.Location = new System.Drawing.Point(37, 37);
            this.btnPedirCita.Name = "btnPedirCita";
            this.btnPedirCita.Size = new System.Drawing.Size(72, 61);
            this.btnPedirCita.TabIndex = 0;
            this.btnPedirCita.UseVisualStyleBackColor = false;
            this.btnPedirCita.Click += new System.EventHandler(this.btnPedirCita_Click);
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1012, 595);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaciente";
            this.Text = "PACIENTE";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCita.ResumeLayout(false);
            this.panelCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblPedirCita;
        private System.Windows.Forms.Button btnPedirCita;
        private System.Windows.Forms.Panel panelCita;
        private System.Windows.Forms.Button btnPrioritaria;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrioritaria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnConsultarCitas;
    }
}