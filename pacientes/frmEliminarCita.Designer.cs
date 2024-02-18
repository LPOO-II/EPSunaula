namespace CitasEpsUNAULA
{
    partial class frmEliminarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarCita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdCancel = new System.Windows.Forms.TextBox();
            this.lblIdReagenda = new System.Windows.Forms.Label();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.lblIdCita = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblNota);
            this.panel1.Controls.Add(this.txtIdCita);
            this.panel1.Controls.Add(this.lblIdCita);
            this.panel1.Controls.Add(this.txtIdCancel);
            this.panel1.Controls.Add(this.lblIdReagenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 140);
            this.panel1.TabIndex = 0;
            // 
            // txtIdCancel
            // 
            this.txtIdCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCancel.Location = new System.Drawing.Point(110, 28);
            this.txtIdCancel.Name = "txtIdCancel";
            this.txtIdCancel.PasswordChar = '*';
            this.txtIdCancel.Size = new System.Drawing.Size(256, 21);
            this.txtIdCancel.TabIndex = 9;
            // 
            // lblIdReagenda
            // 
            this.lblIdReagenda.AutoSize = true;
            this.lblIdReagenda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdReagenda.ForeColor = System.Drawing.Color.Black;
            this.lblIdReagenda.Location = new System.Drawing.Point(107, 9);
            this.lblIdReagenda.Name = "lblIdReagenda";
            this.lblIdReagenda.Size = new System.Drawing.Size(259, 16);
            this.lblIdReagenda.TabIndex = 8;
            this.lblIdReagenda.Text = "INGRESE SU NUMERO DE IDENTIFICACIÓN";
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarCita.BackgroundImage")));
            this.btnCancelarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCita.FlatAppearance.BorderSize = 0;
            this.btnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCita.Location = new System.Drawing.Point(179, 520);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(131, 79);
            this.btnCancelarCita.TabIndex = 1;
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            this.btnCancelarCita.Click += new System.EventHandler(this.btnCancelarCita_Click);
            // 
            // lblIdCita
            // 
            this.lblIdCita.AutoSize = true;
            this.lblIdCita.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCita.ForeColor = System.Drawing.Color.Black;
            this.lblIdCita.Location = new System.Drawing.Point(119, 64);
            this.lblIdCita.Name = "lblIdCita";
            this.lblIdCita.Size = new System.Drawing.Size(236, 16);
            this.lblIdCita.TabIndex = 10;
            this.lblIdCita.Text = "INGRESE SU NUMERO(ID) DE LA CITA";
            // 
            // txtIdCita
            // 
            this.txtIdCita.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCita.Location = new System.Drawing.Point(110, 83);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.PasswordChar = '*';
            this.txtIdCita.Size = new System.Drawing.Size(256, 21);
            this.txtIdCita.TabIndex = 11;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.Black;
            this.lblNota.Location = new System.Drawing.Point(15, 116);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(493, 13);
            this.lblNota.TabIndex = 12;
            this.lblNota.Text = "RECUERDE QUE EL ID DE SU CITA LO PUEDE OBTENER CONSULTANDO SU CITA EN LA PLATAFOR" +
    "MA";
            // 
            // frmEliminarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(511, 611);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarCita";
            this.Text = "CANCELAR CITA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdCancel;
        private System.Windows.Forms.Label lblIdReagenda;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label lblIdCita;
    }
}