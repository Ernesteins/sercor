﻿namespace sercor
{
    partial class Administrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrativo));
            this.userControl = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.admin4 = new System.Windows.Forms.CheckBox();
            this.user2 = new System.Windows.Forms.CheckBox();
            this.user1 = new System.Windows.Forms.CheckBox();
            this.admin1 = new System.Windows.Forms.CheckBox();
            this.admin2 = new System.Windows.Forms.CheckBox();
            this.user3 = new System.Windows.Forms.CheckBox();
            this.admin3 = new System.Windows.Forms.CheckBox();
            this.user4 = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.userControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControl
            // 
            this.userControl.BackColor = System.Drawing.Color.White;
            this.userControl.Controls.Add(this.label6);
            this.userControl.Controls.Add(this.txtContrasenia);
            this.userControl.Controls.Add(this.txtLastName);
            this.userControl.Controls.Add(this.txtCi);
            this.userControl.Controls.Add(this.txtDireccion);
            this.userControl.Controls.Add(this.txtTelefono);
            this.userControl.Controls.Add(this.txtName);
            this.userControl.Controls.Add(this.label4);
            this.userControl.Controls.Add(this.btnDelete);
            this.userControl.Controls.Add(this.btnEdit);
            this.userControl.Controls.Add(this.btnNew);
            this.userControl.Controls.Add(this.groupBox1);
            this.userControl.Controls.Add(this.label5);
            this.userControl.Controls.Add(this.cbmUsuario);
            this.userControl.Controls.Add(this.label3);
            this.userControl.Controls.Add(this.label2);
            this.userControl.Controls.Add(this.label1);
            this.userControl.Controls.Add(this.lblUser);
            this.userControl.Location = new System.Drawing.Point(4, 24);
            this.userControl.Name = "userControl";
            this.userControl.Padding = new System.Windows.Forms.Padding(3);
            this.userControl.Size = new System.Drawing.Size(300, 369);
            this.userControl.TabIndex = 0;
            this.userControl.Text = "Usuarios";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(79, 125);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(79, 183);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(211, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(79, 211);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(211, 22);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtCi
            // 
            this.txtCi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCi.Location = new System.Drawing.Point(79, 97);
            this.txtCi.Name = "txtCi";
            this.txtCi.ReadOnly = true;
            this.txtCi.Size = new System.Drawing.Size(211, 22);
            this.txtCi.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(5, 129);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "R.U.C/C.I";
            // 
            // cbmUsuario
            // 
            this.cbmUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbmUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmUsuario.FormattingEnabled = true;
            this.cbmUsuario.Location = new System.Drawing.Point(79, 40);
            this.cbmUsuario.Name = "cbmUsuario";
            this.cbmUsuario.Size = new System.Drawing.Size(211, 23);
            this.cbmUsuario.TabIndex = 3;
            this.cbmUsuario.SelectedIndexChanged += new System.EventHandler(this.cbmUsuario_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(5, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Usuario";
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
            this.groupBox1.Location = new System.Drawing.Point(8, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 125);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // admin4
            // 
            this.admin4.AutoCheck = false;
            this.admin4.AutoSize = true;
            this.admin4.ForeColor = System.Drawing.Color.Tomato;
            this.admin4.Location = new System.Drawing.Point(6, 97);
            this.admin4.Name = "admin4";
            this.admin4.Size = new System.Drawing.Size(74, 19);
            this.admin4.TabIndex = 13;
            this.admin4.Text = "Reportes";
            this.admin4.UseVisualStyleBackColor = true;
            // 
            // user2
            // 
            this.user2.AutoCheck = false;
            this.user2.AutoSize = true;
            this.user2.Location = new System.Drawing.Point(144, 47);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(132, 19);
            this.user2.TabIndex = 15;
            this.user2.Text = "Cuentas por cobrar";
            this.user2.UseVisualStyleBackColor = true;
            // 
            // user1
            // 
            this.user1.AutoCheck = false;
            this.user1.AutoSize = true;
            this.user1.Location = new System.Drawing.Point(144, 22);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(62, 19);
            this.user1.TabIndex = 14;
            this.user1.Text = "Ventas";
            this.user1.UseVisualStyleBackColor = true;
            // 
            // admin1
            // 
            this.admin1.AutoCheck = false;
            this.admin1.AutoSize = true;
            this.admin1.ForeColor = System.Drawing.Color.Tomato;
            this.admin1.Location = new System.Drawing.Point(6, 22);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(107, 19);
            this.admin1.TabIndex = 10;
            this.admin1.Text = "Administrativo";
            this.admin1.UseVisualStyleBackColor = true;
            // 
            // admin2
            // 
            this.admin2.AutoCheck = false;
            this.admin2.AutoSize = true;
            this.admin2.ForeColor = System.Drawing.Color.Tomato;
            this.admin2.Location = new System.Drawing.Point(6, 47);
            this.admin2.Name = "admin2";
            this.admin2.Size = new System.Drawing.Size(83, 19);
            this.admin2.TabIndex = 11;
            this.admin2.Text = "Inventario";
            this.admin2.UseVisualStyleBackColor = true;
            // 
            // user3
            // 
            this.user3.AutoCheck = false;
            this.user3.AutoSize = true;
            this.user3.Location = new System.Drawing.Point(144, 72);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(74, 19);
            this.user3.TabIndex = 16;
            this.user3.Text = "Trabajos";
            this.user3.UseVisualStyleBackColor = true;
            // 
            // admin3
            // 
            this.admin3.AutoCheck = false;
            this.admin3.AutoSize = true;
            this.admin3.ForeColor = System.Drawing.Color.Tomato;
            this.admin3.Location = new System.Drawing.Point(6, 72);
            this.admin3.Name = "admin3";
            this.admin3.Size = new System.Drawing.Size(135, 19);
            this.admin3.TabIndex = 12;
            this.admin3.Text = "Movimiento de caja";
            this.admin3.UseVisualStyleBackColor = true;
            // 
            // user4
            // 
            this.user4.AutoCheck = false;
            this.user4.AutoSize = true;
            this.user4.Location = new System.Drawing.Point(144, 97);
            this.user4.Name = "user4";
            this.user4.Size = new System.Drawing.Size(101, 19);
            this.user4.TabIndex = 17;
            this.user4.Text = "Fecha factura";
            this.user4.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNew.Image = global::sercor.Properties.Resources.plus16;
            this.btnNew.Location = new System.Drawing.Point(8, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 25);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.Image = global::sercor.Properties.Resources.edit1;
            this.btnEdit.Location = new System.Drawing.Point(98, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Image = global::sercor.Properties.Resources.error16;
            this.btnDelete.Location = new System.Drawing.Point(199, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(79, 153);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(211, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(5, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "Apellido";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(79, 69);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '•';
            this.txtContrasenia.ReadOnly = true;
            this.txtContrasenia.Size = new System.Drawing.Size(211, 22);
            this.txtContrasenia.TabIndex = 4;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(5, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 68;
            this.label6.Text = "Contraseña";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.userControl);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(308, 397);
            this.tabControl.TabIndex = 0;
            // 
            // Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 397);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimizeBox = false;
            this.Name = "Administrativo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativo";
            this.userControl.ResumeLayout(false);
            this.userControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage userControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
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
        private System.Windows.Forms.ComboBox cbmUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TabControl tabControl;
    }
}