using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace cvacars
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SoundEnabled == true)
                this.soundToolStripMenuItem.Checked = true;
            else
                this.soundToolStripMenuItem.Checked = false;
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SoundEnabled = this.soundToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void station_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.TopMost = true;
            about.ShowDialog();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}