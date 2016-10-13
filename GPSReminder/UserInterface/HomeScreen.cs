using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSReminder.Classes;
using Microsoft.WindowsMobile.Samples.Location;
using Microsoft.WindowsMobile.PocketOutlook;
using GPSReminder.UserInterface;
using Microsoft.WindowsCE.Forms;
using System.IO;


namespace GPSReminder
{
    public partial class HomeScreen : Form
    {

        private EventHandler updateDataHandler;        
        GpsPosition position = null;
        Gps gps = new Gps();               
        private static string temp;                             //used to store reminder string
        private Notification notify = null;  // Used to show alarm dialogue
       
        private List<int> TaskIDList = new List<int>();     // Used In Update Data
        private MyLocation locationfrm;
        private string satelliteinfo = "";
        private delegate void ControlUpdater(Control c, string s);
        private bool Reminder_Occurs = false;
        private Bitmap BackgroundImage;
        private Bitmap Icon;
        private Bitmap TitleImage;
        private List<Notification> notifylist = new List<Notification>();
    

        public HomeScreen()
        {
            InitializeComponent();           
        }

        private void GPSMenuItem_Click(object sender, EventArgs e)
        {           

            if (!gps.Opened)
            {

                updateDataHandler = new EventHandler(UpdateData);
                gps.LocationChanged += new LocationChangedEventHandler(gps_LocationChanged); // location changed is an event
                gps.Open();           
                GPSMenuItem.Text = "Turn Gps Off";
            }
            else
            {
               
                gps.LocationChanged -= gps_LocationChanged;
                gps.Close();
                GPSMenuItem.Text = " Turn Gps On";
                Reminder_Occurs = false;
              
            }
        }
     

      

        private void TasksMenuItem_Click(object sender, EventArgs e)
        {
            new UserInterface.TaskInterface().Show();            
        }

        private void PlacesMenuItem_Click(object sender, EventArgs e)
        {
            new UserInterface.PlaceInterface().Show();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
            BackgroundImage = new Bitmap(@"\Program Files\GPSReminder\Images\BlackImage.jpg");
            Icon = new Bitmap(@"\Program Files\GPSReminder\Images\SatelliteResize.jpg");
            TitleImage = new Bitmap(@"\Program Files\GPSReminder\Images\TitleImage.jpg");
        }

        private void MyLocationMenuItem_Click(object sender, EventArgs e)
        {
            locationfrm = new MyLocation();
            locationfrm.Show();
        }

        private void HomeScreen_Closing(object sender, CancelEventArgs e)
        {
            if (gps.Opened)
            {
                gps.LocationChanged -= gps_LocationChanged;
                gps.Close();
            }         
            Application.Exit();
        }

        protected void gps_LocationChanged(object sender, LocationChangedEventArgs args)
        {
            ControlUpdater cu = UpdateControl;
            updateDataHandler = new EventHandler(UpdateData);
            position = args.Position;
            if (locationfrm != null)
            {
                if (position.LatitudeValid)
                {
                    Invoke(cu, locationfrm.LatitudeLbl, position.Latitude.ToString()); // delgate method,Control on form, value to be updated                    
                }

                if (position.LongitudeValid)
                {
                    Invoke(cu, locationfrm.LongitudeLbl, position.Longitude.ToString());
                }
                
                if (position.SatellitesInSolutionValid &&
                            position.SatellitesInViewValid &&
                            position.SatelliteCountValid)
                {
                    Invoke(cu, locationfrm.SatelliteInfolbl, satelliteinfo += "Satellite Count:   " + position.GetSatellitesInSolution().Length.ToString() + "/" +
                     position.GetSatellitesInView().Length.ToString() + " (" +
                     position.SatelliteCount.ToString() + ")\n");
                }
            }
           
            // call the UpdateData method via the updateDataHandler so that we      
            if (!Reminder_Occurs)
            {
                Invoke(updateDataHandler);
            }
        }


        void UpdateData(object sender, System.EventArgs args)
        {
            if (gps.Opened)
            {
                if (position.LongitudeValid && position.LongitudeValid)
                {
                    int placeid; // place id returned
                    
                    
                    placeid = DatabaseOperations.CheckProximity(position.Latitude, position.Longitude);
                               
                    TaskIDList = DatabaseOperations.GetTaskIDList(placeid);                   
                    // if the above code returns -1 then we are not close to the place
                    if (placeid != -1)
                    {                      
                        foreach (int tempid in TaskIDList)
                        {
                            temp = DatabaseOperations.GetTaskSubjectFromFolder(tempid);
                            
                            notify = new Notification();
                            notify.Text = temp;
                            notifylist.Add(notify);                         
                                                        
                           // DatabaseOperations.DeleteTasksFromDatabase(tempid);
                        }
                        foreach (Notification n in notifylist)
                        {
                            n.Caption = "Alert!";
                            n.Critical = false;
                            n.Visible = true;
                        }
                       

                        Reminder_Occurs = true;                       
                    }
                }               

            }
        } // Update Data Ends



        public void UpdateControl(Control c, string s)
        {
            c.Text = s;
        }

        private void ExitMenuItem_Click_1(object sender, EventArgs e)
        {
            if (gps.Opened)
            {
                gps.LocationChanged -= gps_LocationChanged;
                gps.Close();
            }
            Application.Exit();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new UserInterface.About().Show();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\Windows\iexplore.exe", @"\Program%20Files\GPSReminder\readme.html");        
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
           // base.OnPaintBackground(e);
           
            Graphics g = e.Graphics;
            g.DrawImage(BackgroundImage,0,0);
            g.DrawImage(Icon, 120, 134);
            g.DrawImage(TitleImage, 20, 60);
        }

       
       
     
    }// Class Ends
} // Namespace Ends