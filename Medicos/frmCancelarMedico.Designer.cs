namespace CitasEpsUNAULA
{
    partial class frmCancelarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelarMedico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdCitaCancel = new System.Windows.Forms.TextBox();
            this.lblIdCitaRe = new System.Windows.Forms.Label();
            this.txtIdCancel = new System.Windows.Forms.TextBox();
            this.lblIdReagenda = new System.Windows.Forms.Label();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtIdCitaCancel);
            this.panel1.Controls.Add(this.lblIdCitaRe);
            this.panel1.Controls.Add(this.txtIdCancel);
            this.panel1.Controls.Add(this.lblIdReagenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 140);
            this.panel1.TabIndex = 1;
            // 
            // txtIdCitaCancel
            // 
            this.txtIdCitaCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCitaCancel.Location = new System.Drawing.Point(168, 94);
            this.txtIdCitaCancel.Name = "txtIdCitaCancel";
            this.txtIdCitaCancel.Size = new System.Drawing.Size(119, 21);
            this.txtIdCitaCancel.TabIndex = 11;
            // 
            // lblIdCitaRe
            // 
            this.lblIdCitaRe.AutoSize = true;
            this.lblIdCitaRe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCitaRe.ForeColor = System.Drawing.Color.Black;
            this.lblIdCitaRe.Location = new System.Drawing.Point(120, 75);
            this.lblIdCitaRe.Name = "lblIdCitaRe";
            this.lblIdCitaRe.Size = new System.Drawing.Size(226, 16);
            this.lblIdCitaRe.TabIndex = 10;
            this.lblIdCitaRe.Text = "INGRESE EL NUMERO ID DE LA CITA";
            // 
            // txtIdCancel
            // 
            this.txtIdCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCancel.Location = new System.Drawing.Point(105, 28);
            this.txtIdCancel.Name = "txtIdCancel";
            this.txtIdCancel.Size = new System.Drawing.Size(256, 21);
            this.txtIdCancel.TabIndex = 9;
            // 
            // lblIdReagenda
            // 
            this.lblIdReagenda.AutoSize = true;
            this.lblIdReagenda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdReagenda.ForeColor = System.Drawing.Color.Black;
            this.lblIdReagenda.Location = new System.Drawing.Point(102, 9);
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
            this.btnCancelarCita.Location = new System.Drawing.Point(168, 520);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(131, 79);
            this.btnCancelarCita.TabIndex = 2;
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            this.btnCancelarCita.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCancelarMedico
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
            this.Name = "frmCancelarMedico";
            this.Text = "CANCELAR CITAS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdCitaCancel;
        private System.Windows.Forms.Label lblIdCitaRe;
        private System.Windows.Forms.TextBox txtIdCancel;
        private System.Windows.Forms.Label lblIdReagenda;
        private System.Windows.Forms.Button btnCancelarCita;
    }
}