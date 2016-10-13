namespace GPSReminder
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.OptionsMenuItem = new System.Windows.Forms.MenuItem();
            this.TasksMenuItem = new System.Windows.Forms.MenuItem();
            this.PlacesMenuItem = new System.Windows.Forms.MenuItem();
            this.MyLocationMenuItem = new System.Windows.Forms.MenuItem();
            this.AboutMenuItem = new System.Windows.Forms.MenuItem();
            this.HelpMenuItem = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.GPSMenuItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.OptionsMenuItem);
            this.mainMenu1.MenuItems.Add(this.GPSMenuItem);
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.MenuItems.Add(this.TasksMenuItem);
            this.OptionsMenuItem.MenuItems.Add(this.PlacesMenuItem);
            this.OptionsMenuItem.MenuItems.Add(this.MyLocationMenuItem);
            this.OptionsMenuItem.MenuItems.Add(this.AboutMenuItem);
            this.OptionsMenuItem.MenuItems.Add(this.HelpMenuItem);
            this.OptionsMenuItem.MenuItems.Add(this.ExitMenuItem);
            this.OptionsMenuItem.Text = "Menu";
            // 
            // TasksMenuItem
            // 
            this.TasksMenuItem.Text = "Tasks";
            this.TasksMenuItem.Click += new System.EventHandler(this.TasksMenuItem_Click);
            // 
            // PlacesMenuItem
            // 
            this.PlacesMenuItem.Text = "Places";
            this.PlacesMenuItem.Click += new System.EventHandler(this.PlacesMenuItem_Click);
            // 
            // MyLocationMenuItem
            // 
            this.MyLocationMenuItem.Text = "My Location";
            this.MyLocationMenuItem.Click += new System.EventHandler(this.MyLocationMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click_1);
            // 
            // GPSMenuItem
            // 
            this.GPSMenuItem.Text = "GPS On/Off";
            this.GPSMenuItem.Click += new System.EventHandler(this.GPSMenuItem_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Menu = this.mainMenu1;
            this.Name = "HomeScreen";
            this.Text = "GPS Reminder";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.HomeScreen_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem OptionsMenuItem;
        private System.Windows.Forms.MenuItem GPSMenuItem;
        private System.Windows.Forms.MenuItem TasksMenuItem;
        private System.Windows.Forms.MenuItem PlacesMenuItem;
        private System.Windows.Forms.MenuItem AboutMenuItem;
        private System.Windows.Forms.MenuItem MyLocationMenuItem;
        private System.Windows.Forms.MenuItem HelpMenuItem;
        private System.Windows.Forms.MenuItem ExitMenuItem;
    }
}