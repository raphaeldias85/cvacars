using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinACARS
{
    public partial class ACARS : Form
    {
        public ACARS()
        {
            InitializeComponent();
        }

        private void ACARS_Resize( object sender, EventArgs e )
        {
            if ( WindowState == FormWindowState.Minimized )
                Hide();
        }

        Hashtable WindowViews = new Hashtable();
        private void ACARS_Load( object sender, EventArgs e )
        {
            WindowViews.Add( "CVACARS", new UI.UserCP( this ) );

            foreach ( string key in WindowViews.Keys )
            {
                UISelectBox.Items.Add( key );
            }
        }

        private void ACARS_FormClosing( object sender, FormClosingEventArgs e )
        {
            Hide();
            WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void contextExit_Click( object sender, EventArgs e )
        {
            Environment.Exit( 0 );
        }

        private void notifyIcon_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if ( e.Button != MouseButtons.Left )
                return;
            if ( WindowState != FormWindowState.Normal )
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void UISelectBox_SelectionChangeCommitted( object sender, EventArgs e )
        {
            foreach ( string key in WindowViews.Keys )
            {
                UI.IUIPanel panel = (UI.IUIPanel)WindowViews[key];
                panel.Hide();
            }
            UI.IUIPanel box = (UI.IUIPanel)WindowViews[UISelectBox.SelectedItem.ToString()];
            box.Show();
        }
    }
}
