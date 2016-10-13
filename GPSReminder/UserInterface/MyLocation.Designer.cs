namespace GPSReminder.UserInterface
{
    partial class MyLocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LatitudeLbl = new System.Windows.Forms.Label();
            this.LongitudeLbl = new System.Windows.Forms.Label();
            this.SatelliteInfolbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.Text = "Location And Satellite Info";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Latitude:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Longitude:";
            // 
            // LatitudeLbl
            // 
            this.LatitudeLbl.BackColor = System.Drawing.Color.Black;
            this.LatitudeLbl.ForeColor = System.Drawing.Color.White;
            this.LatitudeLbl.Location = new System.Drawing.Point(106, 84);
            this.LatitudeLbl.Name = "LatitudeLbl";
            this.LatitudeLbl.Size = new System.Drawing.Size(131, 20);
            // 
            // LongitudeLbl
            // 
            this.LongitudeLbl.BackColor = System.Drawing.Color.Black;
            this.LongitudeLbl.ForeColor = System.Drawing.Color.White;
            this.LongitudeLbl.Location = new System.Drawing.Point(106, 133);
            this.LongitudeLbl.Name = "LongitudeLbl";
            this.LongitudeLbl.Size = new System.Drawing.Size(131, 20);
            // 
            // SatelliteInfolbl
            // 
            this.SatelliteInfolbl.BackColor = System.Drawing.Color.Black;
            this.SatelliteInfolbl.ForeColor = System.Drawing.Color.White;
            this.SatelliteInfolbl.Location = new System.Drawing.Point(3, 228);
            this.SatelliteInfolbl.Name = "SatelliteInfolbl";
            this.SatelliteInfolbl.Size = new System.Drawing.Size(232, 16);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.Text = "Satellites in View:";
            // 
            // MyLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SatelliteInfolbl);
            this.Controls.Add(this.LongitudeLbl);
            this.Controls.Add(this.LatitudeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyLocation";
            this.Load += new System.EventHandler(this.MyLocation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LatitudeLbl;
        public System.Windows.Forms.Label LongitudeLbl;
        public System.Windows.Forms.Label SatelliteInfolbl;
        private System.Windows.Forms.Label label4;


    }
}
