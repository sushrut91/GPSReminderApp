namespace GPSReminder.UserInterface
{
    partial class DeleteTaskOrAssociation
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
            this.DeleteTaskRadio = new System.Windows.Forms.RadioButton();
            this.DeletePlaceRadio = new System.Windows.Forms.RadioButton();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AssociatedPlaceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteTaskRadio
            // 
            this.DeleteTaskRadio.BackColor = System.Drawing.Color.Black;
            this.DeleteTaskRadio.ForeColor = System.Drawing.Color.White;
            this.DeleteTaskRadio.Location = new System.Drawing.Point(22, 70);
            this.DeleteTaskRadio.Name = "DeleteTaskRadio";
            this.DeleteTaskRadio.Size = new System.Drawing.Size(96, 21);
            this.DeleteTaskRadio.TabIndex = 0;
            this.DeleteTaskRadio.Text = "Delete Task";
            // 
            // DeletePlaceRadio
            // 
            this.DeletePlaceRadio.BackColor = System.Drawing.Color.Black;
            this.DeletePlaceRadio.ForeColor = System.Drawing.Color.White;
            this.DeletePlaceRadio.Location = new System.Drawing.Point(22, 108);
            this.DeletePlaceRadio.Name = "DeletePlaceRadio";
            this.DeletePlaceRadio.Size = new System.Drawing.Size(183, 22);
            this.DeletePlaceRadio.TabIndex = 1;
            this.DeletePlaceRadio.Text = "Delete Associated Place";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(81, 172);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(72, 20);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.Text = "Associated Place:";
            // 
            // AssociatedPlaceLbl
            // 
            this.AssociatedPlaceLbl.BackColor = System.Drawing.Color.Black;
            this.AssociatedPlaceLbl.ForeColor = System.Drawing.Color.White;
            this.AssociatedPlaceLbl.Location = new System.Drawing.Point(114, 25);
            this.AssociatedPlaceLbl.Name = "AssociatedPlaceLbl";
            this.AssociatedPlaceLbl.Size = new System.Drawing.Size(123, 20);
            // 
            // DeleteTaskOrAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.AssociatedPlaceLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.DeletePlaceRadio);
            this.Controls.Add(this.DeleteTaskRadio);
            this.Menu = this.mainMenu1;
            this.Name = "DeleteTaskOrAssociation";
            this.Text = "GPS Reminder";
            this.Load += new System.EventHandler(this.DeleteTaskOrAssociation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton DeleteTaskRadio;
        private System.Windows.Forms.RadioButton DeletePlaceRadio;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AssociatedPlaceLbl;
    }
}