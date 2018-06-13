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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pnForm = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIndiactor = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.ptcLogo = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pnHead = new System.Windows.Forms.Panel();
            this.ptcTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnForm.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogo)).BeginInit();
            this.pnHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.BackColor = System.Drawing.Color.Transparent;
            this.pnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnForm.Controls.Add(this.pnBottom);
            this.pnForm.Controls.Add(this.pnBody);
            this.pnForm.Controls.Add(this.pnHead);
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(0, 0);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(287, 294);
            this.pnForm.TabIndex = 0;
            // 
            // pnBottom
            // 
            this.pnBottom.AutoSize = true;
            this.pnBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnBottom.Controls.Add(this.statusStrip1);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 270);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(285, 22);
            this.pnBottom.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblIndiactor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(285, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(125, 17);
            this.lblStatus.Text = "Conectado a SercorDB";
            // 
            // lblIndiactor
            // 
            this.lblIndiactor.BackColor = System.Drawing.Color.Transparent;
            this.lblIndiactor.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblIndiactor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblIndiactor.ForeColor = System.Drawing.Color.Lime;
            this.lblIndiactor.Name = "lblIndiactor";
            this.lblIndiactor.Size = new System.Drawing.Size(17, 17);
            this.lblIndiactor.Text = "■";
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
            this.pnBody.Location = new System.Drawing.Point(0, 25);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(285, 267);
            this.pnBody.TabIndex = 9;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPass.Location = new System.Drawing.Point(12, 180);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 16);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUser.Location = new System.Drawing.Point(12, 129);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 16);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Usuario";
            // 
            // ptcLogo
            // 
            this.ptcLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptcLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptcLogo.BackgroundImage")));
            this.ptcLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcLogo.Location = new System.Drawing.Point(86, 10);
            this.ptcLogo.Name = "ptcLogo";
            this.ptcLogo.Size = new System.Drawing.Size(112, 109);
            this.ptcLogo.TabIndex = 5;
            this.ptcLogo.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(12, 149);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(263, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPsw
            // 
            this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsw.Location = new System.Drawing.Point(12, 199);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '•';
            this.txtPsw.Size = new System.Drawing.Size(263, 22);
            this.txtPsw.TabIndex = 1;
            this.txtPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Silver;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.Location = new System.Drawing.Point(88, 229);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(112, 31);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Acceder";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pnHead
            // 
            this.pnHead.BackColor = System.Drawing.Color.Gray;
            this.pnHead.Controls.Add(this.ptcTitle);
            this.pnHead.Controls.Add(this.lblTitle);
            this.pnHead.Controls.Add(this.btnInfo);
            this.pnHead.Controls.Add(this.btnClose);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(285, 25);
            this.pnHead.TabIndex = 8;
            this.pnHead.Visible = false;
            this.pnHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseMove);
            // 
            // ptcTitle
            // 
            this.ptcTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptcTitle.BackgroundImage")));
            this.ptcTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptcTitle.Location = new System.Drawing.Point(3, 3);
            this.ptcTitle.Name = "ptcTitle";
            this.ptcTitle.Size = new System.Drawing.Size(19, 20);
            this.ptcTitle.TabIndex = 13;
            this.ptcTitle.TabStop = false;
            this.ptcTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 16);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Sercor";
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseMove);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Silver;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Image = global::sercor.Properties.Resources._003_substract;
            this.btnInfo.Location = new System.Drawing.Point(235, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 25);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::sercor.Properties.Resources._002_close;
            this.btnClose.Location = new System.Drawing.Point(260, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 294);
            this.Controls.Add(this.pnForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogo)).EndInit();
            this.pnHead.ResumeLayout(false);
            this.pnHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox ptcLogo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.PictureBox ptcTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblIndiactor;
    }
}

