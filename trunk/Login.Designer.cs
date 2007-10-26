namespace cvacars
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.cmdlogin = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tsLogin = new System.Windows.Forms.StatusStrip();
            this.tsLoginServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 168);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(176, 20);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 191);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(176, 20);
            this.password.TabIndex = 2;
            // 
            // cmdlogin
            // 
            this.cmdlogin.Location = new System.Drawing.Point(13, 217);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(175, 28);
            this.cmdlogin.TabIndex = 3;
            this.cmdlogin.Text = "&Login";
            this.cmdlogin.UseVisualStyleBackColor = true;
            this.cmdlogin.Click += new System.EventHandler(this.cmdlogin_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "CVACARS";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tsLogin
            // 
            this.tsLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoginServerStatus});
            this.tsLogin.Location = new System.Drawing.Point(0, 260);
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(199, 22);
            this.tsLogin.TabIndex = 4;
            this.tsLogin.Text = "statusStrip1";
            // 
            // tsLoginServerStatus
            // 
            this.tsLoginServerStatus.Name = "tsLoginServerStatus";
            this.tsLoginServerStatus.Size = new System.Drawing.Size(37, 17);
            this.tsLoginServerStatus.Text = "Offline";
            this.tsLoginServerStatus.Click += new System.EventHandler(this.tsLoginServerStatus_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 282);
            this.Controls.Add(this.tsLogin);
            this.Controls.Add(this.cmdlogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "CVACARS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsLogin.ResumeLayout(false);
            this.tsLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.StatusStrip tsLogin;
        private System.Windows.Forms.ToolStripStatusLabel tsLoginServerStatus;
    }
}

