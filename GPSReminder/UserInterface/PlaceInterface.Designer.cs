namespace GPSReminder.UserInterface
{
    partial class PlaceInterface
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PlaceLongitudeTxt = new System.Windows.Forms.TextBox();
            this.PlaceLatitudeTxt = new System.Windows.Forms.TextBox();
            this.PlaceNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlaceLongitudeLbl = new System.Windows.Forms.Label();
            this.PlaceLatitudeLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.AddressLookupBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EditPlaceBtn = new System.Windows.Forms.Button();
            this.DeletePlaceBtn = new System.Windows.Forms.Button();
            this.PlacesListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 265);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveBtn);
            this.tabPage1.Controls.Add(this.PlaceLongitudeTxt);
            this.tabPage1.Controls.Add(this.PlaceLatitudeTxt);
            this.tabPage1.Controls.Add(this.PlaceNameTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 242);
            this.tabPage1.Text = "New/Edit Place";
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(79, 197);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 20);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PlaceLongitudeTxt
            // 
            this.PlaceLongitudeTxt.Location = new System.Drawing.Point(113, 138);
            this.PlaceLongitudeTxt.Name = "PlaceLongitudeTxt";
            this.PlaceLongitudeTxt.Size = new System.Drawing.Size(120, 21);
            this.PlaceLongitudeTxt.TabIndex = 5;
            // 
            // PlaceLatitudeTxt
            // 
            this.PlaceLatitudeTxt.Location = new System.Drawing.Point(113, 91);
            this.PlaceLatitudeTxt.Name = "PlaceLatitudeTxt";
            this.PlaceLatitudeTxt.Size = new System.Drawing.Size(120, 21);
            this.PlaceLatitudeTxt.TabIndex = 4;
            // 
            // PlaceNameTxt
            // 
            this.PlaceNameTxt.Location = new System.Drawing.Point(113, 42);
            this.PlaceNameTxt.Name = "PlaceNameTxt";
            this.PlaceNameTxt.Size = new System.Drawing.Size(120, 21);
            this.PlaceNameTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Longitude:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Latitude:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Place Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PlaceLongitudeLbl);
            this.tabPage2.Controls.Add(this.PlaceLatitudeLbl);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.AddressLbl);
            this.tabPage2.Controls.Add(this.AddressLookupBtn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.AddressTxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 242);
            this.tabPage2.Text = "GeoCoding ";
            this.tabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage2_Paint);
            // 
            // PlaceLongitudeLbl
            // 
            this.PlaceLongitudeLbl.BackColor = System.Drawing.Color.Black;
            this.PlaceLongitudeLbl.ForeColor = System.Drawing.Color.White;
            this.PlaceLongitudeLbl.Location = new System.Drawing.Point(91, 211);
            this.PlaceLongitudeLbl.Name = "PlaceLongitudeLbl";
            this.PlaceLongitudeLbl.Size = new System.Drawing.Size(141, 20);
            // 
            // PlaceLatitudeLbl
            // 
            this.PlaceLatitudeLbl.BackColor = System.Drawing.Color.Black;
            this.PlaceLatitudeLbl.ForeColor = System.Drawing.Color.White;
            this.PlaceLatitudeLbl.Location = new System.Drawing.Point(91, 173);
            this.PlaceLatitudeLbl.Name = "PlaceLatitudeLbl";
            this.PlaceLatitudeLbl.Size = new System.Drawing.Size(142, 20);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.Text = "Longitude:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.Text = "Latitude:";
            // 
            // AddressLbl
            // 
            this.AddressLbl.BackColor = System.Drawing.Color.Black;
            this.AddressLbl.ForeColor = System.Drawing.Color.White;
            this.AddressLbl.Location = new System.Drawing.Point(7, 109);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(230, 45);
            // 
            // AddressLookupBtn
            // 
            this.AddressLookupBtn.Location = new System.Drawing.Point(84, 86);
            this.AddressLookupBtn.Name = "AddressLookupBtn";
            this.AddressLookupBtn.Size = new System.Drawing.Size(72, 20);
            this.AddressLookupBtn.TabIndex = 3;
            this.AddressLookupBtn.Text = "Lookup";
            this.AddressLookupBtn.Click += new System.EventHandler(this.AddressLookupBtn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.Text = "eg: Place,Area,City,Country";
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(7, 39);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(226, 21);
            this.AddressTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.Text = "Input Place Address/Area";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.EditPlaceBtn);
            this.tabPage3.Controls.Add(this.DeletePlaceBtn);
            this.tabPage3.Controls.Add(this.PlacesListBox);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 242);
            this.tabPage3.Text = "All Places";
            this.tabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage3_Paint);
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // EditPlaceBtn
            // 
            this.EditPlaceBtn.Location = new System.Drawing.Point(122, 164);
            this.EditPlaceBtn.Name = "EditPlaceBtn";
            this.EditPlaceBtn.Size = new System.Drawing.Size(87, 28);
            this.EditPlaceBtn.TabIndex = 2;
            this.EditPlaceBtn.Text = "Edit Place";
            this.EditPlaceBtn.Click += new System.EventHandler(this.EditPlaceBtn_Click);
            // 
            // DeletePlaceBtn
            // 
            this.DeletePlaceBtn.Location = new System.Drawing.Point(26, 164);
            this.DeletePlaceBtn.Name = "DeletePlaceBtn";
            this.DeletePlaceBtn.Size = new System.Drawing.Size(90, 28);
            this.DeletePlaceBtn.TabIndex = 1;
            this.DeletePlaceBtn.Text = "Delete Place";
            this.DeletePlaceBtn.Click += new System.EventHandler(this.DeletePlaceBtn_Click);
            // 
            // PlacesListBox
            // 
            this.PlacesListBox.Location = new System.Drawing.Point(7, 30);
            this.PlacesListBox.Name = "PlacesListBox";
            this.PlacesListBox.Size = new System.Drawing.Size(225, 128);
            this.PlacesListBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(75, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.Text = "All Places";
            // 
            // PlaceInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Name = "PlaceInterface";
            this.Text = "Places";
            this.Load += new System.EventHandler(this.PlaceInterface_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox PlaceLongitudeTxt;
        private System.Windows.Forms.TextBox PlaceLatitudeTxt;
        private System.Windows.Forms.TextBox PlaceNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Button AddressLookupBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button DeletePlaceBtn;
        private System.Windows.Forms.ListBox PlacesListBox;
        private System.Windows.Forms.Button EditPlaceBtn;
        private System.Windows.Forms.Label PlaceLongitudeLbl;
        private System.Windows.Forms.Label PlaceLatitudeLbl;
        private System.Windows.Forms.Label label8;
    }
}
