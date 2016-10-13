using System;
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
    public partial class TaskInterface : GPSReminder.HomeScreen
    {
        private CustomTask tsk;
        private Task task;                               // Task without location association
        private List<Place> place_list;
        private List<CustomTask> Custom_Task_Collection;
        private TaskCollection Task_Collection;
        private int Selected_Place_ID;         // Place id for place object selected through combobox
        public static int Selected_Task_ID;           // Used to access from DeleteTaskOrAssociation Form
        bool complete = false;
    
        private Bitmap BackgroundImage;// Task is complete or not
        
        public TaskInterface()
        {
            InitializeComponent();
        }

        private void TaskInterface_Load(object sender, EventArgs e)
        {
          
            BackgroundImage = new Bitmap(@"\Program Files\GPSReminder\Images\BlackImage.jpg");
            SubjectCombo.Items.Add("Complete");
            SubjectCombo.Items.Add("Work On");
            SubjectCombo.Items.Add("Buy");
            SubjectCombo.Items.Add("Update");
            SubjectCombo.Items.Add("Study");
            SubjectCombo.Items.Add("Call");
            SubjectCombo.Items.Add("Plan");
            SubjectCombo.Items.Add("Request");
            SubjectCombo.Items.Add("Contact");

            

          ReminderHourCombo.Items.Add("No Alarm");
          ReminderMinutesCombo.Items.Add("No Alarm");
          ReminderHourCombo.Items.Add("00");
            for (int i = 1 ; i <= 23; i++)
            {
                if( i <= 9 )
                ReminderHourCombo.Items.Add("0"+i.ToString());
                else
                ReminderHourCombo.Items.Add(i.ToString());
            }
            
            ////////////////////////////////////////////

            for (int i = 0; i < 60; i++)
            {
                if (i <= 9)
                    ReminderMinutesCombo.Items.Add("0" + i.ToString());
                else
                    ReminderMinutesCombo.Items.Add(i.ToString());
            }

            place_list = DatabaseOperations.GetAllPlaces();
            PlaceCombo.Items.Clear();
            foreach (Place p in place_list)
            {
                PlaceCombo.Items.Add(p.PlaceNameProp.ToString());
            }
           
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = StartDateTimePicker.Value;
                string temp="0" ; 
                string minute_temp="0";      // store temp time
                int hour=0;                    // parsed hour
                int minute = 0;
                bool reminderset = false;    // To Check if User Wants a Reminder or Not

                if (PlaceCombo.SelectedItem == null)    // Task Has no associated place
                {
                    if (ReminderHourCombo.SelectedItem != null)
                    {
                        if (!ReminderHourCombo.SelectedItem.Equals("No Alarm"))
                        {
                            temp = ReminderHourCombo.SelectedItem.ToString(); // parse the hour                         
                            reminderset = true;
                        }
                        else
                        {
                            reminderset = false;
                        }
                      
                        
                    }
                    if (ReminderMinutesCombo.SelectedItem != null)
                    {
                        if (!ReminderMinutesCombo.SelectedItem.Equals("No Alarm"))
                        {
                            minute_temp = ReminderMinutesCombo.SelectedItem.ToString();
                            reminderset = true;
                        }
                        else
                        {
                            reminderset = false;
                        }
                    }

                    hour = int.Parse(temp);// convert hour to int
                    minute = int.Parse(minute_temp); // convert minutes to int
                    DateTime due = new DateTime(DueDateTimePicker.Value.Year, DueDateTimePicker.Value.Month,
                    DueDateTimePicker.Value.Day, hour, minute , 0); // pass the integer hour as parameter to constructor
                        task = new Task();
                        task.Subject = SubjectCombo.Text;
                        task.Complete = complete;
                        task.StartDate = StartDateTimePicker.Value;
                        task.DueDate = due;

                        if (reminderset == true)
                        {
                            task.ReminderTime = due;
                        }
                        OutlookSession os = new OutlookSession();
                        TaskFolder folder = os.Tasks;
                        if (SubjectCombo.Text.ToString() != "")
                        {
                            folder.Items.Add(task);  // save to folder  
                            MessageBox.Show("Task Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        }
                        else
                        {
                            MessageBox.Show("Subject Can't Be Empty");
                        }
                  
                }
                else                                      //Task has an associated place
                {
                    if (ReminderHourCombo.SelectedItem != null)
                    {
                        if (!ReminderHourCombo.SelectedItem.Equals("No Alarm"))
                        {
                            temp = ReminderHourCombo.SelectedItem.ToString(); // parse the hour                         
                            reminderset = true;
                        }
                        else
                        {
                            reminderset = false;
                        }


                    }
                    if (ReminderMinutesCombo.SelectedItem != null)
                    {
                        if (!ReminderMinutesCombo.SelectedItem.Equals("No Alarm"))
                        {
                            minute_temp = ReminderMinutesCombo.SelectedItem.ToString();
                            reminderset = true;
                        }
                        else
                        {
                            reminderset = false;
                        }
                    }

                    hour = int.Parse(temp);// convert hour to int
                    minute = int.Parse(minute_temp); // convert minutes to int

                    foreach (Place p in place_list)
                    {
                        if (p.PlaceNameProp.Equals(PlaceCombo.SelectedItem.ToString()))
                        {
                            Selected_Place_ID = p.PlaceIDProp;
                        }
                    }
                    hour = int.Parse(temp);         // convert hour to int
                    minute = int.Parse(minute_temp); // convert minutes to int
                    DateTime due = new DateTime(DueDateTimePicker.Value.Year, DueDateTimePicker.Value.Month,
                    DueDateTimePicker.Value.Day, hour, minute, 0); // pass the integer hour as parameter to constructor
                    
                    tsk = new CustomTask(SubjectCombo.Text.ToString(),
                                            complete, start, due, reminderset
                                            , due, Selected_Place_ID);

                    if (SubjectCombo.Text != null)
                    {
                        tsk.SaveTaskToOutlookFolder(); // save to folder
                        tsk.SaveTaskToDbase(tsk);
                    }
                    else
                    {
                        MessageBox.Show("Subject Can't Be Empty");
                    }

                    ////////////////////////////////////////////////// Save to Dbase  
                    // set selected place id to Task Object  
                    MessageBox.Show("Task Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                   
                  
                }

            

              
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error Saving Task...Please Retry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            }

   
            SubjectCombo.Text = null;          
            ReminderHourCombo.Text = null;
            PlaceCombo.Text = null;
         }         

   

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TasksListBox.Items.Clear();
            Task_Collection = DatabaseOperations.GetAllTasksFromFolder();
            
            foreach (Task t in Task_Collection)
            {               
                TasksListBox.Items.Add(t.Subject.ToString());    
            }
        }

        private void MainDelete_Click(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedItem != null)
            {
                string temp = TasksListBox.SelectedItem.ToString();
                Task task = null;
                foreach (Task t in Task_Collection)
                {
                    if (t.Subject.Equals(temp))
                    {
                        task = t;
                    }
                }

                Selected_Task_ID = int.Parse(task.ItemId.ToString());
                new DeleteTaskOrAssociation().ShowDialog();
            }
            else
            {
                MessageBox.Show("No Task Selected!");
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
          
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(BackgroundImage, 0, 0);
        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(BackgroundImage, 0, 0);
        }

     
     

     
       
    }
}

