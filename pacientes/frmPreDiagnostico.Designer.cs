namespace CitasEpsUNAULA
{
    partial class frmPreDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreDiagnostico));
            this.lblOpcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDolor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDesmayo = new System.Windows.Forms.ComboBox();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.btnVerificarPre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.Color.Black;
            this.lblOpcion.Location = new System.Drawing.Point(209, 28);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(316, 16);
            this.lblOpcion.TabIndex = 10;
            this.lblOpcion.Text = "DEL 1 AL 10 CUANTO DUELE LA PARTE AFECTADA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "SIENDO 1 CASI NADA DE DOLOR Y SIENDO 10 UN DOLOR EXTREMO";
            // 
            // cmbDolor
            // 
            this.cmbDolor.FormattingEnabled = true;
            this.cmbDolor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbDolor.Location = new System.Drawing.Point(323, 63);
            this.cmbDolor.Name = "cmbDolor";
            this.cmbDolor.Size = new System.Drawing.Size(88, 21);
            this.cmbDolor.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(235, 168);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(290, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "HA SUFRIDO DE CONVULSIONES O DESMAYOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(235, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "CUANDO LLEVA CON ESTA SINTOMATOLOGIA";
            // 
            // cmbDesmayo
            // 
            this.cmbDesmayo.FormattingEnabled = true;
            this.cmbDesmayo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbDesmayo.Location = new System.Drawing.Point(323, 187);
            this.cmbDesmayo.Name = "cmbDesmayo";
            this.cmbDesmayo.Size = new System.Drawing.Size(88, 21);
            this.cmbDesmayo.TabIndex = 15;
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Items.AddRange(new object[] {
            "DE 1 A 2 SEMANAS",
            "DE 2 A 4 SEMANAS",
            "DE 1 A 3 MESES",
            "MAS DE 3 MESES"});
            this.cmbTiempo.Location = new System.Drawing.Point(323, 280);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(88, 21);
            this.cmbTiempo.TabIndex = 16;
            // 
            // btnVerificarPre
            // 
            this.btnVerificarPre.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVerificarPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificarPre.FlatAppearance.BorderSize = 0;
            this.btnVerificarPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarPre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarPre.Location = new System.Drawing.Point(313, 368);
            this.btnVerificarPre.Name = "btnVerificarPre";
            this.btnVerificarPre.Size = new System.Drawing.Size(127, 37);
            this.btnVerificarPre.TabIndex = 17;
            this.btnVerificarPre.Text = "VERIFICAR";
            this.btnVerificarPre.UseVisualStyleBackColor = false;
            this.btnVerificarPre.Click += new System.EventHandler(this.btnVerificarPre_Click);
            // 
            // frmPreDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificarPre);
            this.Controls.Add(this.cmbTiempo);
            this.Controls.Add(this.cmbDesmayo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOpcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreDiagnostico";
            this.Text = "PreDiagnostico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDesmayo;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.Button btnVerificarPre;
    }
}