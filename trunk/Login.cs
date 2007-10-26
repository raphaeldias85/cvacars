using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cvacars
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tsLoginServerStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            tsLoginServerStatus.Text = "UNABLE TO LOGIN";
        }
    }
}