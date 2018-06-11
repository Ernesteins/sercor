namespace sercor
{
    partial class login
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(157, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(157, 72);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(100, 20);
            this.txtPsw.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(38, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuario";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(38, 75);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(61, 13);
            this.lblPsw.TabIndex = 3;
            this.lblPsw.Text = "Contraseña";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(157, 115);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Iniciar Sesión";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 189);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtUser);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Button btnlogin;
    }
}

