using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSReminder.Classes;
using Microsoft.WindowsMobile.PocketOutlook;

namespace GPSReminder.UserInterface
{
    public partial class DeleteTaskOrAssociation : Form
    {
        private int task_id;
        private Bitmap background;
        public DeleteTaskOrAssociation()
        {
            InitializeComponent();
        }

        private void DeleteTaskOrAssociation_Load(object sender, EventArgs e)
        {
            background = new Bitmap(@"\Program Files\GPSReminder\Images\BlackImage.jpg");
            task_id = TaskInterface.Selected_Task_ID;
            int place_id=DatabaseOperations.GetPlaceID(task_id);
            if (place_id != -1)
            {
                AssociatedPlaceLbl.Text = DatabaseOperations.GetPlaceName(place_id);
            }
            else
            {
                AssociatedPlaceLbl.Text = "No Associated Place";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DeleteTaskRadio.Checked)
            {
                OutlookSession os = new OutlookSession();
                ItemId id = new ItemId(task_id);
                Task t = new Task(id);
                os.Tasks.Items.Remove(t);
                DatabaseOperations.DeleteTaskFromDb(id);
                MessageBox.Show("Task Successfully Deleted");
                this.Close();
            }
            else if (DeletePlaceRadio.Checked)
            {
                DatabaseOperations.RemoveTaskPlaceAssociation(task_id);
            }
            else
            {
                MessageBox.Show("Select At least 1 Option");
            }
        }
        protected override void  OnPaint(PaintEventArgs e)
        {
 	         //base.OnPaint(e);
            Graphics g = e.Graphics ;
            g.DrawImage(background,0,0);
        }
    }
}