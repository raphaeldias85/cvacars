using System;
using System.Collections.Generic;
using System.Text;

namespace WinACARS.UI
{
    public class UserCP : IUIPanel
    {
        private System.Windows.Forms.Form form;
        private System.Windows.Forms.GroupBox box = new System.Windows.Forms.GroupBox();
        private System.Windows.Forms.Button cmdLogin = new System.Windows.Forms.Button();
        private System.Windows.Forms.TextBox txtPassword = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.CheckBox chkPasswordSave = new System.Windows.Forms.CheckBox();
        private System.Windows.Forms.CheckBox chkPilotIDSave = new System.Windows.Forms.CheckBox();
        private System.Windows.Forms.Label lblPassword = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label lblPilotID = new System.Windows.Forms.Label();
        private System.Windows.Forms.TextBox txtPilotID = new System.Windows.Forms.TextBox();

        public UserCP(System.Windows.Forms.Form form)
        {
            this.form = form;
            form.Controls.Add( box );
            box.Controls.Add( this.cmdLogin );
            box.Controls.Add( this.txtPassword );
            box.Controls.Add( this.chkPasswordSave );
            box.Controls.Add( this.chkPilotIDSave );
            box.Controls.Add( this.lblPassword );
            box.Controls.Add( this.lblPilotID );
            box.Controls.Add( this.txtPilotID );
            box.Location = new System.Drawing.Point( 12, 39 );
            box.Name = "gbMain";
            box.Size = new System.Drawing.Size( 342, 373 );
            box.TabIndex = 0;
            box.TabStop = false;
            box.Text = "CVACARS";

            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point( 100, 71 );
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size( 70, 26 );
            this.cmdLogin.TabIndex = 15;
            this.cmdLogin.Text = "&Login";
            this.cmdLogin.UseCompatibleTextRendering = true;
            this.cmdLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point( 100, 45 );
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '.';
            this.txtPassword.Size = new System.Drawing.Size( 135, 20 );
            this.txtPassword.TabIndex = 14;
            if ( Properties.Settings.Default.savePassword )
                this.txtPassword.Text = Properties.Settings.Default.Password;
            // 
            // chkPasswordSave
            // 
            this.chkPasswordSave.AutoSize = true;
            this.chkPasswordSave.Location = new System.Drawing.Point( 241, 45 );
            this.chkPasswordSave.Name = "chkPasswordSave";
            this.chkPasswordSave.Size = new System.Drawing.Size( 51, 17 );
            this.chkPasswordSave.TabIndex = 13;
            this.chkPasswordSave.Text = "Save";
            this.chkPasswordSave.UseVisualStyleBackColor = true;
            if (Properties.Settings.Default.savePassword)
                this.chkPasswordSave.Checked = true;
            // 
            // chkPilotIDSave
            // 
            this.chkPilotIDSave.AutoSize = true;
            this.chkPilotIDSave.Location = new System.Drawing.Point( 241, 19 );
            this.chkPilotIDSave.Name = "chkPilotIDSave";
            this.chkPilotIDSave.Size = new System.Drawing.Size( 51, 17 );
            this.chkPilotIDSave.TabIndex = 12;
            this.chkPilotIDSave.Text = "Save";
            this.chkPilotIDSave.UseVisualStyleBackColor = true;
            if ( Properties.Settings.Default.saveUsername )
                this.chkPilotIDSave.Checked = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point( 38, 48 );
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size( 56, 13 );
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // lblPilotID
            // 
            this.lblPilotID.AutoSize = true;
            this.lblPilotID.Location = new System.Drawing.Point( 50, 22 );
            this.lblPilotID.Name = "lblPilotID";
            this.lblPilotID.Size = new System.Drawing.Size( 44, 13 );
            this.lblPilotID.TabIndex = 10;
            this.lblPilotID.Text = "Pilot ID:";
            // 
            // txtPilotID
            // 
            this.txtPilotID.Location = new System.Drawing.Point( 100, 19 );
            this.txtPilotID.Name = "txtPilotID";
            this.txtPilotID.Size = new System.Drawing.Size( 135, 20 );
            this.txtPilotID.TabIndex = 9;
            if ( Properties.Settings.Default.saveUsername )
                this.txtPilotID.Text = Properties.Settings.Default.Username;

            this.Hide();
        }
        public void Hide()
        {
            box.Visible = false;
        }
        public void Show()
        {
            box.Visible = true;
        }
    }
}
