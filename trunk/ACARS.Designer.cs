namespace cvacars
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
            this.acarsStatus = new System.Windows.Forms.StatusStrip();
            this.timerFSPoll = new System.Windows.Forms.Timer(this.components);
            this.timerNetPING = new System.Windows.Forms.Timer(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabNews = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabDispatch = new System.Windows.Forms.TabPage();
            this.tabWeather = new System.Windows.Forms.TabPage();
            this.textNews = new System.Windows.Forms.TextBox();
            this.tabs.SuspendLayout();
            this.tabNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // acarsStatus
            // 
            this.acarsStatus.Location = new System.Drawing.Point(0, 353);
            this.acarsStatus.Name = "acarsStatus";
            this.acarsStatus.Size = new System.Drawing.Size(544, 22);
            this.acarsStatus.TabIndex = 0;
            this.acarsStatus.Text = "statusStrip1";
            this.acarsStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabNews);
            this.tabs.Controls.Add(this.tabProfile);
            this.tabs.Controls.Add(this.tabDispatch);
            this.tabs.Controls.Add(this.tabWeather);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(520, 338);
            this.tabs.TabIndex = 1;
            // 
            // tabNews
            // 
            this.tabNews.Controls.Add(this.textNews);
            this.tabNews.Location = new System.Drawing.Point(4, 22);
            this.tabNews.Name = "tabNews";
            this.tabNews.Padding = new System.Windows.Forms.Padding(3);
            this.tabNews.Size = new System.Drawing.Size(512, 312);
            this.tabNews.TabIndex = 0;
            this.tabNews.Text = "News";
            this.tabNews.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(512, 312);
            this.tabProfile.TabIndex = 1;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tabDispatch
            // 
            this.tabDispatch.Location = new System.Drawing.Point(4, 22);
            this.tabDispatch.Name = "tabDispatch";
            this.tabDispatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabDispatch.Size = new System.Drawing.Size(512, 312);
            this.tabDispatch.TabIndex = 2;
            this.tabDispatch.Text = "Dispatch";
            this.tabDispatch.UseVisualStyleBackColor = true;
            // 
            // tabWeather
            // 
            this.tabWeather.Location = new System.Drawing.Point(4, 22);
            this.tabWeather.Name = "tabWeather";
            this.tabWeather.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeather.Size = new System.Drawing.Size(512, 312);
            this.tabWeather.TabIndex = 3;
            this.tabWeather.Text = "Weather";
            this.tabWeather.UseVisualStyleBackColor = true;
            // 
            // textNews
            // 
            this.textNews.Location = new System.Drawing.Point(-2, 0);
            this.textNews.Multiline = true;
            this.textNews.Name = "textNews";
            this.textNews.ReadOnly = true;
            this.textNews.Size = new System.Drawing.Size(518, 312);
            this.textNews.TabIndex = 0;
            // 
            // ACARS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 375);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.acarsStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ACARS";
            this.ShowInTaskbar = false;
            this.Text = "CVACARS";
            this.TopMost = true;
            this.tabs.ResumeLayout(false);
            this.tabNews.ResumeLayout(false);
            this.tabNews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip acarsStatus;
        private System.Windows.Forms.Timer timerFSPoll;
        private System.Windows.Forms.Timer timerNetPING;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabNews;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabDispatch;
        private System.Windows.Forms.TabPage tabWeather;
        private System.Windows.Forms.TextBox textNews;
    }
}