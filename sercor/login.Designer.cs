﻿namespace sercor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pnForm = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.ptcStatus = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.ptcLogo = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnForm.SuspendLayout();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcStatus)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.BackColor = System.Drawing.Color.Transparent;
            this.pnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnForm.Controls.Add(this.pnBottom);
            this.pnForm.Controls.Add(this.pnBody);
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(0, 0);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(287, 298);
            this.pnForm.TabIndex = 0;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnBottom.Controls.Add(this.ptcStatus);
            this.pnBottom.Controls.Add(this.statusStrip1);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 273);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(285, 23);
            this.pnBottom.TabIndex = 10;
            // 
            // ptcStatus
            // 
            this.ptcStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptcStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptcStatus.Location = new System.Drawing.Point(125, 3);
            this.ptcStatus.Name = "ptcStatus";
            this.ptcStatus.Size = new System.Drawing.Size(20, 20);
            this.ptcStatus.TabIndex = 2;
            this.ptcStatus.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(285, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(125, 17);
            this.lblStatus.Text = "Conectado a SercorDB";
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.lblPass);
            this.pnBody.Controls.Add(this.lblUser);
            this.pnBody.Controls.Add(this.ptcLogo);
            this.pnBody.Controls.Add(this.txtUser);
            this.pnBody.Controls.Add(this.txtPsw);
            this.pnBody.Controls.Add(this.btnlogin);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.ForeColor = System.Drawing.Color.White;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(285, 296);
            this.pnBody.TabIndex = 9;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPass.Location = new System.Drawing.Point(11, 179);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(83, 19);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUser.Location = new System.Drawing.Point(11, 127);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 19);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Usuario";
            // 
            // ptcLogo
            // 
            this.ptcLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptcLogo.BackgroundImage = global::sercor.Properties.Resources.server;
            this.ptcLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcLogo.Location = new System.Drawing.Point(87, 11);
            this.ptcLogo.Name = "ptcLogo";
            this.ptcLogo.Size = new System.Drawing.Size(112, 109);
            this.ptcLogo.TabIndex = 5;
            this.ptcLogo.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(11, 149);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(263, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtUser, "Ingrese su identificador de usuario");
            // 
            // txtPsw
            // 
            this.txtPsw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPsw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsw.Location = new System.Drawing.Point(11, 201);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '•';
            this.txtPsw.Size = new System.Drawing.Size(263, 27);
            this.txtPsw.TabIndex = 1;
            this.txtPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtPsw, "Ingrese su contraseña");
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.Location = new System.Drawing.Point(87, 235);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(112, 32);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Acceder";
            this.toolTip1.SetToolTip(this.btnlogin, "Inicia sesión en Sercor");
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Asistente Secor";
            // 
            // login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 298);
            this.Controls.Add(this.pnForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sercor - Login";
            this.pnForm.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcStatus)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox ptcLogo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox ptcStatus;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

