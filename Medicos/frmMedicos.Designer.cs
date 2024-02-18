namespace CitasEpsUNAULA
{
    partial class frmMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.Panel();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnHistorialPaciente = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.historial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelPrincipal.Controls.Add(this.historial);
            this.panelPrincipal.Controls.Add(this.panel3);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrincipal.Location = new System.Drawing.Point(745, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(275, 595);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblEliminar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Location = new System.Drawing.Point(77, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 108);
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
            this.lblEliminar.Click += new System.EventHandler(this.lblEliminar_Click);
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
            this.panel2.Location = new System.Drawing.Point(77, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 118);
            this.panel2.TabIndex = 8;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.White;
            this.lblModificar.Location = new System.Drawing.Point(36, 18);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(74, 16);
            this.lblModificar.TabIndex = 7;
            this.lblModificar.Text = "VER CITAS";
            this.lblModificar.Click += new System.EventHandler(this.lblModificar_Click);
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
            // historial
            // 
            this.historial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historial.Controls.Add(this.lblHistorial);
            this.historial.Controls.Add(this.btnHistorialPaciente);
            this.historial.Location = new System.Drawing.Point(77, 430);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(141, 108);
            this.historial.TabIndex = 10;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.Color.White;
            this.lblHistorial.Location = new System.Drawing.Point(0, 11);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(140, 16);
            this.lblHistorial.TabIndex = 8;
            this.lblHistorial.Text = "HISTORIAL PACIENTE";
            // 
            // btnHistorialPaciente
            // 
            this.btnHistorialPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistorialPaciente.BackgroundImage")));
            this.btnHistorialPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistorialPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialPaciente.FlatAppearance.BorderSize = 0;
            this.btnHistorialPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPaciente.Location = new System.Drawing.Point(24, 30);
            this.btnHistorialPaciente.Name = "btnHistorialPaciente";
            this.btnHistorialPaciente.Size = new System.Drawing.Size(88, 67);
            this.btnHistorialPaciente.TabIndex = 8;
            this.btnHistorialPaciente.UseVisualStyleBackColor = true;
            this.btnHistorialPaciente.Click += new System.EventHandler(this.btnHistorialPaciente_Click);
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1020, 595);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicos";
            this.Text = "frmMedicos";
            this.panelPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.historial.ResumeLayout(false);
            this.historial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel historial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnHistorialPaciente;
    }
}