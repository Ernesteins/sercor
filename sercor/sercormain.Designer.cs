namespace sercor
{
    partial class sercormain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.MaskedTextBox();
            this.facturaView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lbImpuesto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAbono = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.facturaView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(79, 10);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(79, 36);
            this.txtTelefono.Mask = "9999999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(79, 63);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(79, 90);
            this.txtCi.Mask = "9999999999";
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(100, 20);
            this.txtCi.TabIndex = 4;
            // 
            // facturaView
            // 
            this.facturaView.AllowUserToOrderColumns = true;
            this.facturaView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facturaView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.facturaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.unitario,
            this.total});
            this.facturaView.Location = new System.Drawing.Point(12, 142);
            this.facturaView.MultiSelect = false;
            this.facturaView.Name = "facturaView";
            this.facturaView.ReadOnly = true;
            this.facturaView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.facturaView.RowHeadersVisible = false;
            this.facturaView.Size = new System.Drawing.Size(672, 171);
            this.facturaView.TabIndex = 6;
            // 
            // codigo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "NA";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigo.FillWeight = 50F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo.ToolTipText = "Código de producto";
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 300F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 50F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // unitario
            // 
            this.unitario.HeaderText = "V Unitario";
            this.unitario.Name = "unitario";
            this.unitario.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "V Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(602, 319);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(82, 20);
            this.txt.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(602, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(602, 371);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(602, 398);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(602, 424);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(529, 322);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(35, 13);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "label1";
            // 
            // lbImpuesto
            // 
            this.lbImpuesto.AutoSize = true;
            this.lbImpuesto.Location = new System.Drawing.Point(529, 348);
            this.lbImpuesto.Name = "lbImpuesto";
            this.lbImpuesto.Size = new System.Drawing.Size(35, 13);
            this.lbImpuesto.TabIndex = 12;
            this.lbImpuesto.Text = "label2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(529, 374);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "label3";
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(529, 401);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(35, 13);
            this.lblAbono.TabIndex = 14;
            this.lblAbono.Text = "label4";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(529, 427);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(35, 13);
            this.lblSaldo.TabIndex = 15;
            this.lblSaldo.Text = "label5";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(731, 345);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(45, 20);
            this.textBox6.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.AutoCompleteCustomSource.AddRange(new string[] {
            "ADSAD",
            "ADAD",
            "DADA",
            "DAD",
            "DAD",
            "ADA",
            "AEWTEW",
            "RWRT"});
            this.txtApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(185, 10);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // sercormain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbImpuesto);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.facturaView);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Name = "sercormain";
            this.Text = "sercor";
            this.Load += new System.EventHandler(this.sercormain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox txtCi;
        private System.Windows.Forms.DataGridView facturaView;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lbImpuesto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox txtApellido;
    }
}