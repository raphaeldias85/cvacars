namespace WinACARS
{
    partial class ACARS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ACARS ) );
            this.notifyIcon = new System.Windows.Forms.NotifyIcon( this.components );
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.contextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.UISelectBox = new System.Windows.Forms.ComboBox();
            this.aCARSBindingSource = new System.Windows.Forms.BindingSource( this.components );
            this.contextMenuStrip.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.aCARSBindingSource ) ).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ( (System.Drawing.Icon)( resources.GetObject( "notifyIcon.Icon" ) ) );
            this.notifyIcon.Text = "CVACARS";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.notifyIcon_MouseDoubleClick );
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.contextExit} );
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size( 104, 26 );
            // 
            // contextExit
            // 
            this.contextExit.Name = "contextExit";
            this.contextExit.Size = new System.Drawing.Size( 103, 22 );
            this.contextExit.Text = "E&xit";
            this.contextExit.Click += new System.EventHandler( this.contextExit_Click );
            // 
            // UISelectBox
            // 
            this.UISelectBox.FormattingEnabled = true;
            this.UISelectBox.Location = new System.Drawing.Point( 12, 12 );
            this.UISelectBox.Name = "UISelectBox";
            this.UISelectBox.Size = new System.Drawing.Size( 342, 21 );
            this.UISelectBox.TabIndex = 1;
            this.UISelectBox.SelectionChangeCommitted += new System.EventHandler( this.UISelectBox_SelectionChangeCommitted );
            // 
            // aCARSBindingSource
            // 
            this.aCARSBindingSource.DataSource = typeof( WinACARS.ACARS );
            // 
            // ACARS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 366, 424 );
            this.Controls.Add( this.UISelectBox );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACARS";
            this.Text = "CVACARS";
            this.Load += new System.EventHandler( this.ACARS_Load );
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ACARS_FormClosing );
            this.Resize += new System.EventHandler( this.ACARS_Resize );
            this.contextMenuStrip.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.aCARSBindingSource ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ComboBox UISelectBox;
        private System.Windows.Forms.BindingSource aCARSBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextExit;
    }
}

