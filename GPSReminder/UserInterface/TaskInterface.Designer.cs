namespace GPSReminder.UserInterface
{
    partial class TaskInterface
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReminderMinutesCombo = new System.Windows.Forms.ComboBox();
            this.ReminderHourCombo = new System.Windows.Forms.ComboBox();
            this.PlaceCombo = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubjectCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainDelete = new System.Windows.Forms.Button();
            this.TasksListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 265);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ReminderMinutesCombo);
            this.tabPage1.Controls.Add(this.ReminderHourCombo);
            this.tabPage1.Controls.Add(this.PlaceCombo);
            this.tabPage1.Controls.Add(this.SaveBtn);
            this.tabPage1.Controls.Add(this.DueDateTimePicker);
            this.tabPage1.Controls.Add(this.StartDateTimePicker);
            this.tabPage1.Controls.Add(this.SubjectCombo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 242);
            this.tabPage1.Text = "Create Task";
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.Text = "Min";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.Text = "hrs";
            // 
            // ReminderMinutesCombo
            // 
            this.ReminderMinutesCombo.Location = new System.Drawing.Point(160, 158);
            this.ReminderMinutesCombo.Name = "ReminderMinutesCombo";
            this.ReminderMinutesCombo.Size = new System.Drawing.Size(63, 22);
            this.ReminderMinutesCombo.TabIndex = 22;
            // 
            // ReminderHourCombo
            // 
            this.ReminderHourCombo.Location = new System.Drawing.Point(82, 158);
            this.ReminderHourCombo.Name = "ReminderHourCombo";
            this.ReminderHourCombo.Size = new System.Drawing.Size(71, 22);
            this.ReminderHourCombo.TabIndex = 21;
            // 
            // PlaceCombo
            // 
            this.PlaceCombo.Location = new System.Drawing.Point(82, 186);
            this.PlaceCombo.Name = "PlaceCombo";
            this.PlaceCombo.Size = new System.Drawing.Size(151, 22);
            this.PlaceCombo.TabIndex = 14;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SaveBtn.Location = new System.Drawing.Point(82, 219);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 20);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DueDateTimePicker
            // 
            this.DueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DueDateTimePicker.Location = new System.Drawing.Point(82, 107);
            this.DueDateTimePicker.Name = "DueDateTimePicker";
            this.DueDateTimePicker.Size = new System.Drawing.Size(151, 22);
            this.DueDateTimePicker.TabIndex = 10;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTimePicker.Location = new System.Drawing.Point(82, 77);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(151, 22);
            this.StartDateTimePicker.TabIndex = 9;
            // 
            // SubjectCombo
            // 
            this.SubjectCombo.BackColor = System.Drawing.Color.White;
            this.SubjectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.SubjectCombo.ForeColor = System.Drawing.Color.Black;
            this.SubjectCombo.Location = new System.Drawing.Point(82, 36);
            this.SubjectCombo.Name = "SubjectCombo";
            this.SubjectCombo.Size = new System.Drawing.Size(151, 22);
            this.SubjectCombo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.Text = "Place:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.Text = "Alarm Time:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.Text = "Starts:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.Text = "Subject:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.MainDelete);
            this.tabPage2.Controls.Add(this.TasksListBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 242);
            this.tabPage2.Text = "See All Tasks";
            this.tabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage2_Paint);
            // 
            // MainDelete
            // 
            this.MainDelete.Location = new System.Drawing.Point(84, 166);
            this.MainDelete.Name = "MainDelete";
            this.MainDelete.Size = new System.Drawing.Size(72, 20);
            this.MainDelete.TabIndex = 1;
            this.MainDelete.Text = "Delete";
            this.MainDelete.Click += new System.EventHandler(this.MainDelete_Click);
            // 
            // TasksListBox
            // 
            this.TasksListBox.Location = new System.Drawing.Point(7, 34);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.Size = new System.Drawing.Size(226, 114);
            this.TasksListBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(84, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.Text = "All Tasks";
            // 
            // TaskInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Name = "TaskInterface";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.TaskInterface_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox SubjectCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PlaceCombo;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DateTimePicker DueDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Button MainDelete;
        private System.Windows.Forms.ListBox TasksListBox;
        private System.Windows.Forms.ComboBox ReminderHourCombo;
        private System.Windows.Forms.ComboBox ReminderMinutesCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}
