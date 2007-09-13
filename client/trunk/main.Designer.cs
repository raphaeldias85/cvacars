namespace cvacars
{
    partial class main
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabDispatch = new System.Windows.Forms.TabPage();
            this.tabFlightPlanning = new System.Windows.Forms.TabPage();
            this.tabWeather = new System.Windows.Forms.TabPage();
            this.tabsWeather = new System.Windows.Forms.TabControl();
            this.tabWeatherOrigin = new System.Windows.Forms.TabPage();
            this.tabWeatherEnRoute = new System.Windows.Forms.TabPage();
            this.tabWeatherDestination = new System.Windows.Forms.TabPage();
            this.tabWeatherAux = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sep1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.briefingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.tabWeather.SuspendLayout();
            this.tabsWeather.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabDispatch);
            this.tabs.Controls.Add(this.tabFlightPlanning);
            this.tabs.Controls.Add(this.tabWeather);
            this.tabs.Location = new System.Drawing.Point(0, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(492, 389);
            this.tabs.TabIndex = 0;
            // 
            // tabDispatch
            // 
            this.tabDispatch.Location = new System.Drawing.Point(4, 22);
            this.tabDispatch.Name = "tabDispatch";
            this.tabDispatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabDispatch.Size = new System.Drawing.Size(484, 363);
            this.tabDispatch.TabIndex = 0;
            this.tabDispatch.Text = "Dispatch";
            this.tabDispatch.UseVisualStyleBackColor = true;
            // 
            // tabFlightPlanning
            // 
            this.tabFlightPlanning.Location = new System.Drawing.Point(4, 22);
            this.tabFlightPlanning.Name = "tabFlightPlanning";
            this.tabFlightPlanning.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlightPlanning.Size = new System.Drawing.Size(484, 363);
            this.tabFlightPlanning.TabIndex = 2;
            this.tabFlightPlanning.Text = "Flight Planning";
            this.tabFlightPlanning.UseVisualStyleBackColor = true;
            // 
            // tabWeather
            // 
            this.tabWeather.Controls.Add(this.tabsWeather);
            this.tabWeather.Location = new System.Drawing.Point(4, 22);
            this.tabWeather.Name = "tabWeather";
            this.tabWeather.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeather.Size = new System.Drawing.Size(484, 363);
            this.tabWeather.TabIndex = 1;
            this.tabWeather.Text = "Weather";
            this.tabWeather.UseVisualStyleBackColor = true;
            // 
            // tabsWeather
            // 
            this.tabsWeather.Controls.Add(this.tabWeatherOrigin);
            this.tabsWeather.Controls.Add(this.tabWeatherEnRoute);
            this.tabsWeather.Controls.Add(this.tabWeatherDestination);
            this.tabsWeather.Controls.Add(this.tabWeatherAux);
            this.tabsWeather.Location = new System.Drawing.Point(0, 6);
            this.tabsWeather.Name = "tabsWeather";
            this.tabsWeather.SelectedIndex = 0;
            this.tabsWeather.Size = new System.Drawing.Size(482, 357);
            this.tabsWeather.TabIndex = 0;
            // 
            // tabWeatherOrigin
            // 
            this.tabWeatherOrigin.Location = new System.Drawing.Point(4, 22);
            this.tabWeatherOrigin.Name = "tabWeatherOrigin";
            this.tabWeatherOrigin.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeatherOrigin.Size = new System.Drawing.Size(474, 331);
            this.tabWeatherOrigin.TabIndex = 0;
            this.tabWeatherOrigin.Text = "Origin";
            this.tabWeatherOrigin.UseVisualStyleBackColor = true;
            // 
            // tabWeatherEnRoute
            // 
            this.tabWeatherEnRoute.Location = new System.Drawing.Point(4, 22);
            this.tabWeatherEnRoute.Name = "tabWeatherEnRoute";
            this.tabWeatherEnRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeatherEnRoute.Size = new System.Drawing.Size(474, 331);
            this.tabWeatherEnRoute.TabIndex = 1;
            this.tabWeatherEnRoute.Text = "En Route";
            this.tabWeatherEnRoute.UseVisualStyleBackColor = true;
            // 
            // tabWeatherDestination
            // 
            this.tabWeatherDestination.Location = new System.Drawing.Point(4, 22);
            this.tabWeatherDestination.Name = "tabWeatherDestination";
            this.tabWeatherDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeatherDestination.Size = new System.Drawing.Size(474, 331);
            this.tabWeatherDestination.TabIndex = 2;
            this.tabWeatherDestination.Text = "Destination";
            this.tabWeatherDestination.UseVisualStyleBackColor = true;
            // 
            // tabWeatherAux
            // 
            this.tabWeatherAux.Location = new System.Drawing.Point(4, 22);
            this.tabWeatherAux.Name = "tabWeatherAux";
            this.tabWeatherAux.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeatherAux.Size = new System.Drawing.Size(474, 331);
            this.tabWeatherAux.TabIndex = 3;
            this.tabWeatherAux.Text = "Aux";
            this.tabWeatherAux.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus,
            this.sep1,
            this.fsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "|";
            // 
            // connectionStatus
            // 
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(95, 17);
            this.connectionStatus.Text = "Connection Status";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(11, 17);
            this.sep1.Text = "|";
            // 
            // fsStatus
            // 
            this.fsStatus.Name = "fsStatus";
            this.fsStatus.Size = new System.Drawing.Size(53, 17);
            this.fsStatus.Text = "FS Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(492, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.soundToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Checked = true;
            this.soundToolStripMenuItem.CheckOnClick = true;
            this.soundToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundToolStripMenuItem.Enabled = false;
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.soundToolStripMenuItem.Text = "&Sound";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Enabled = false;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "Contents";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightPlanToolStripMenuItem,
            this.logBookToolStripMenuItem,
            this.weatherToolStripMenuItem});
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "&Print";
            // 
            // flightPlanToolStripMenuItem
            // 
            this.flightPlanToolStripMenuItem.Enabled = false;
            this.flightPlanToolStripMenuItem.Name = "flightPlanToolStripMenuItem";
            this.flightPlanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.flightPlanToolStripMenuItem.Text = "&Flight Plan";
            // 
            // logBookToolStripMenuItem
            // 
            this.logBookToolStripMenuItem.Enabled = false;
            this.logBookToolStripMenuItem.Name = "logBookToolStripMenuItem";
            this.logBookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logBookToolStripMenuItem.Text = "&Log Book";
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.briefingToolStripMenuItem,
            this.conditionsToolStripMenuItem,
            this.forecastToolStripMenuItem});
            this.weatherToolStripMenuItem.Enabled = false;
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.weatherToolStripMenuItem.Text = "&Weather";
            // 
            // briefingToolStripMenuItem
            // 
            this.briefingToolStripMenuItem.Enabled = false;
            this.briefingToolStripMenuItem.Name = "briefingToolStripMenuItem";
            this.briefingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.briefingToolStripMenuItem.Text = "&Briefing";
            // 
            // conditionsToolStripMenuItem
            // 
            this.conditionsToolStripMenuItem.Enabled = false;
            this.conditionsToolStripMenuItem.Name = "conditionsToolStripMenuItem";
            this.conditionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conditionsToolStripMenuItem.Text = "&Conditions";
            // 
            // forecastToolStripMenuItem
            // 
            this.forecastToolStripMenuItem.Enabled = false;
            this.forecastToolStripMenuItem.Name = "forecastToolStripMenuItem";
            this.forecastToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forecastToolStripMenuItem.Text = "&Forecast";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CVACARS";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.tabs.ResumeLayout(false);
            this.tabWeather.ResumeLayout(false);
            this.tabsWeather.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabDispatch;
        private System.Windows.Forms.TabPage tabWeather;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel fsStatus;
        private System.Windows.Forms.ToolStripStatusLabel sep1;
        private System.Windows.Forms.TabControl tabsWeather;
        private System.Windows.Forms.TabPage tabWeatherOrigin;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabWeatherEnRoute;
        private System.Windows.Forms.TabPage tabWeatherDestination;
        private System.Windows.Forms.TabPage tabWeatherAux;
        private System.Windows.Forms.TabPage tabFlightPlanning;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem flightPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem briefingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forecastToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

