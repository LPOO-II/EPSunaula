namespace CitasEpsUNAULA
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lbl1 = new System.Windows.Forms.Label();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnTerminos = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblIf = new System.Windows.Forms.Label();
            this.cboTipoUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIzquierdo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl1.Location = new System.Drawing.Point(233, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(535, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Bienvenido al sistema de citas EPS-UNAULA";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelIzquierdo.Controls.Add(this.btnCerrar);
            this.panelIzquierdo.Controls.Add(this.btnTerminos);
            this.panelIzquierdo.Controls.Add(this.btnIngresar);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(200, 617);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(3, 565);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(194, 33);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnTerminos
            // 
            this.btnTerminos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminos.FlatAppearance.BorderSize = 0;
            this.btnTerminos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminos.ForeColor = System.Drawing.Color.White;
            this.btnTerminos.Location = new System.Drawing.Point(0, 486);
            this.btnTerminos.Name = "btnTerminos";
            this.btnTerminos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTerminos.Size = new System.Drawing.Size(194, 48);
            this.btnTerminos.TabIndex = 1;
            this.btnTerminos.Text = "TERMINOS Y CONDICIONES";
            this.btnTerminos.UseVisualStyleBackColor = true;
            this.btnTerminos.Click += new System.EventHandler(this.btnTerminos_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(3, 387);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIngresar.Size = new System.Drawing.Size(194, 33);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelSuperior.Controls.Add(this.lbl1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(200, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1045, 100);
            this.panelSuperior.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gray;
            this.lblId.Location = new System.Drawing.Point(88, 110);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(289, 19);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Ingrese su número de identicación";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(92, 132);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '*';
            this.txtId.Size = new System.Drawing.Size(285, 20);
            this.txtId.TabIndex = 4;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.Gray;
            this.lblContrasena.Location = new System.Drawing.Point(117, 203);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(220, 19);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Ingrese su primer nombre";
            this.lblContrasena.Click += new System.EventHandler(this.lblContrasena_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(121, 225);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblIf
            // 
            this.lblIf.AutoSize = true;
            this.lblIf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIf.ForeColor = System.Drawing.Color.Gray;
            this.lblIf.Location = new System.Drawing.Point(72, 392);
            this.lblIf.Name = "lblIf";
            this.lblIf.Size = new System.Drawing.Size(339, 19);
            this.lblIf.TabIndex = 7;
            this.lblIf.Text = "Seleccione si usted es Medico o Paciente";
            // 
            // cboTipoUser
            // 
            this.cboTipoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoUser.FormattingEnabled = true;
            this.cboTipoUser.Items.AddRange(new object[] {
            "Medico",
            "Paciente"});
            this.cboTipoUser.Location = new System.Drawing.Point(146, 423);
            this.cboTipoUser.Name = "cboTipoUser";
            this.cboTipoUser.Size = new System.Drawing.Size(168, 21);
            this.cboTipoUser.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(165, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "EPS-UNAULA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTipoUser);
            this.panel1.Controls.Add(this.lblIf);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblContrasena);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(478, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 476);
            this.panel1.TabIndex = 11;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1245, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.Text = "EPS-UNAULA";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelIzquierdo.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnTerminos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIf;
        private System.Windows.Forms.ComboBox cboTipoUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

