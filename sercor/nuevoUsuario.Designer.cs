namespace sercor
{
    partial class nuevoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoUsuario));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user4 = new System.Windows.Forms.CheckBox();
            this.admin3 = new System.Windows.Forms.CheckBox();
            this.user3 = new System.Windows.Forms.CheckBox();
            this.admin2 = new System.Windows.Forms.CheckBox();
            this.admin1 = new System.Windows.Forms.CheckBox();
            this.user1 = new System.Windows.Forms.CheckBox();
            this.user2 = new System.Windows.Forms.CheckBox();
            this.admin4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Image = global::sercor.Properties.Resources.error16;
            this.btnCancelar.Location = new System.Drawing.Point(202, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 29);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.Image = global::sercor.Properties.Resources.success16;
            this.btnAceptar.Location = new System.Drawing.Point(100, 338);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 29);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(83, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(216, 22);
            this.txtUser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtUser, "El identificador de usuario. Este sirve para iniciar sesión.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 100;
            this.label6.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(83, 38);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '•';
            this.txtContrasenia.Size = new System.Drawing.Size(216, 22);
            this.txtContrasenia.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtContrasenia, "Contraseña para inicio de sesión del usuario.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "Apellido";
            // 
            // txtLastName
            // 
            this.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(82, 122);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(216, 22);
            this.txtLastName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtLastName, "Apellido del usuario.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user4);
            this.groupBox1.Controls.Add(this.admin3);
            this.groupBox1.Controls.Add(this.user3);
            this.groupBox1.Controls.Add(this.admin2);
            this.groupBox1.Controls.Add(this.admin1);
            this.groupBox1.Controls.Add(this.user1);
            this.groupBox1.Controls.Add(this.user2);
            this.groupBox1.Controls.Add(this.admin4);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(10, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 125);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // user4
            // 
            this.user4.AutoSize = true;
            this.user4.Location = new System.Drawing.Point(148, 100);
            this.user4.Name = "user4";
            this.user4.Size = new System.Drawing.Size(101, 19);
            this.user4.TabIndex = 14;
            this.user4.Text = "Fecha factura";
            this.toolTip1.SetToolTip(this.user4, "Permite modificar el cambio de fecha en la factura");
            this.user4.UseVisualStyleBackColor = true;
            // 
            // admin3
            // 
            this.admin3.AutoSize = true;
            this.admin3.ForeColor = System.Drawing.Color.Tomato;
            this.admin3.Location = new System.Drawing.Point(6, 75);
            this.admin3.Name = "admin3";
            this.admin3.Size = new System.Drawing.Size(135, 19);
            this.admin3.TabIndex = 9;
            this.admin3.Text = "Movimiento de caja";
            this.toolTip1.SetToolTip(this.admin3, "Permite uso del módulo \"Movimiento de Caja\"");
            this.admin3.UseVisualStyleBackColor = true;
            // 
            // user3
            // 
            this.user3.AutoSize = true;
            this.user3.Location = new System.Drawing.Point(148, 75);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(74, 19);
            this.user3.TabIndex = 13;
            this.user3.Text = "Trabajos";
            this.toolTip1.SetToolTip(this.user3, "Permite uso del módulo \"Trabajos\"");
            this.user3.UseVisualStyleBackColor = true;
            // 
            // admin2
            // 
            this.admin2.AutoSize = true;
            this.admin2.ForeColor = System.Drawing.Color.Tomato;
            this.admin2.Location = new System.Drawing.Point(6, 50);
            this.admin2.Name = "admin2";
            this.admin2.Size = new System.Drawing.Size(83, 19);
            this.admin2.TabIndex = 8;
            this.admin2.Text = "Inventario";
            this.toolTip1.SetToolTip(this.admin2, "Permite uso del módulo \"Inventario\"");
            this.admin2.UseVisualStyleBackColor = true;
            // 
            // admin1
            // 
            this.admin1.AutoSize = true;
            this.admin1.ForeColor = System.Drawing.Color.Tomato;
            this.admin1.Location = new System.Drawing.Point(7, 25);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(107, 19);
            this.admin1.TabIndex = 7;
            this.admin1.Text = "Administrativo";
            this.toolTip1.SetToolTip(this.admin1, "Permite administrar los usuarios");
            this.admin1.UseVisualStyleBackColor = true;
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.Location = new System.Drawing.Point(148, 25);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(62, 19);
            this.user1.TabIndex = 11;
            this.user1.Text = "Ventas";
            this.toolTip1.SetToolTip(this.user1, "Permite uso del módulo \"Ventas\"");
            this.user1.UseVisualStyleBackColor = true;
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.Location = new System.Drawing.Point(148, 50);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(132, 19);
            this.user2.TabIndex = 12;
            this.user2.Text = "Cuentas por cobrar";
            this.toolTip1.SetToolTip(this.user2, "Permite uso del módulo \"Cuentas por cobrar\"");
            this.user2.UseVisualStyleBackColor = true;
            // 
            // admin4
            // 
            this.admin4.AutoSize = true;
            this.admin4.ForeColor = System.Drawing.Color.Tomato;
            this.admin4.Location = new System.Drawing.Point(6, 100);
            this.admin4.Name = "admin4";
            this.admin4.Size = new System.Drawing.Size(74, 19);
            this.admin4.TabIndex = 10;
            this.admin4.Text = "Reportes";
            this.toolTip1.SetToolTip(this.admin4, "Permite uso del módulo \"Reportes\"");
            this.admin4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 97;
            this.label5.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 96;
            this.label3.Text = "R.U.C/C.I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(8, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 94;
            this.label1.Text = "Teléfono";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(7, 97);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 93;
            this.lblUser.Text = "Nombre";
            // 
            // txtCi
            // 
            this.txtCi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCi.Location = new System.Drawing.Point(83, 66);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(216, 22);
            this.txtCi.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCi, "Ingrese el número de identidad del usuario.");
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(82, 179);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(216, 22);
            this.txtDireccion.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtDireccion, "Ingrese la dirección del usuario.");
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(83, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(215, 22);
            this.txtTelefono.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtTelefono, "Ingrese el teléfono del usuario");
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(82, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 22);
            this.txtName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtName, "Nombre del usaurio.");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Asistente Secor";
            // 
            // nuevoUsuario
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(310, 375);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox user4;
        private System.Windows.Forms.CheckBox admin3;
        private System.Windows.Forms.CheckBox user3;
        private System.Windows.Forms.CheckBox admin2;
        private System.Windows.Forms.CheckBox admin1;
        private System.Windows.Forms.CheckBox user1;
        private System.Windows.Forms.CheckBox user2;
        private System.Windows.Forms.CheckBox admin4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}