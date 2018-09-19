namespace sercor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrativo));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userControl = new System.Windows.Forms.TabPage();
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabRestore.SuspendLayout();
            this.userControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Asistente Sercor";
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.button4);
            this.tabRestore.Controls.Add(this.button3);
            this.tabRestore.Controls.Add(this.button2);
            this.tabRestore.Controls.Add(this.button1);
            this.tabRestore.Controls.Add(this.label7);
            this.tabRestore.Controls.Add(this.textBox1);
            this.tabRestore.Location = new System.Drawing.Point(4, 24);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestore.Size = new System.Drawing.Size(300, 369);
            this.tabRestore.TabIndex = 1;
            this.tabRestore.Text = "Copias de seguridad y restauracion";
            this.tabRestore.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 71);
            this.label7.TabIndex = 5;
            this.label7.Text = "* Tenga en cuenta que estas operaciones son irreversibles y completamente de su r" +
    "esponsabilidad. Ingrese la contraseña de administrador general para continuar.";
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
            this.admin4.TabStop = false;
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
            this.user2.TabStop = false;
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
            this.user1.TabStop = false;
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
            this.admin1.TabStop = false;
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
            this.admin2.TabStop = false;
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
            this.user3.TabStop = false;
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
            this.admin3.TabStop = false;
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
            this.user4.TabStop = false;
            this.user4.Text = "Fecha factura";
            this.user4.UseVisualStyleBackColor = true;
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
            this.txtName.TabStop = false;
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
            this.txtTelefono.TabStop = false;
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
            this.txtDireccion.TabStop = false;
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
            this.txtCi.TabStop = false;
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
            this.txtLastName.TabStop = false;
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
            this.txtContrasenia.TabStop = false;
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
            this.tabControl.Controls.Add(this.tabRestore);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(308, 397);
            this.tabControl.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
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
            this.toolTip1.SetToolTip(this.btnDelete, "Elimina el usuario sleccionado actualmenta, El usuario \"admin\" no se puede elimin" +
        "ar.\r\n");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
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
            this.toolTip1.SetToolTip(this.btnEdit, "Edita el usuario seleccionado actualmente. El usuario \"admin\" no se puede editar." +
        "\r\n");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Gainsboro;
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
            this.toolTip1.SetToolTip(this.btnNew, "Crea un nuevo usuario en Sercor");
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Image = global::sercor.Properties.Resources.databaseUpload;
            this.button4.Location = new System.Drawing.Point(155, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 76);
            this.button4.TabIndex = 8;
            this.button4.Text = "Restaurar a partir de copia de seguridad";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = global::sercor.Properties.Resources.databaseOrigin;
            this.button3.Location = new System.Drawing.Point(8, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 76);
            this.button3.TabIndex = 8;
            this.button3.Text = "Restaurar desde el origen";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button3, "Crea un nuevo usuario en Sercor");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = global::sercor.Properties.Resources.success16;
            this.button2.Location = new System.Drawing.Point(8, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Acepto y entiendo los riesgos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button2, "Crea un nuevo usuario en Sercor");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = global::sercor.Properties.Resources.database;
            this.button1.Location = new System.Drawing.Point(8, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar copia de seguridad";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button1, "Crea un nuevo usuario en Sercor");
            this.button1.UseVisualStyleBackColor = false;
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
            this.tabRestore.ResumeLayout(false);
            this.tabRestore.PerformLayout();
            this.userControl.ResumeLayout(false);
            this.userControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabRestore;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
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