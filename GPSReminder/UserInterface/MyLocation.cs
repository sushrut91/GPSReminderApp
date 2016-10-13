using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace GPSReminder.UserInterface
{
    public partial class MyLocation : GPSReminder.HomeScreen
    {
        private Bitmap BackgroundImage;
        public MyLocation()
        {
            InitializeComponent();
        }
        public static Bitmap ShowLocationOnMap(double lat, double longi)
        {
            try
            {              

                Uri uri = new Uri("http://maps.google.com/maps/api/staticmap?center=" + lat + "," + longi + "&zoom=15&markers=size:mid|color:blue|" + lat + "," + longi + "&size=240x320&sensor=true");

                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(uri);
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream imagestream = response.GetResponseStream();
                Bitmap buddyIcon = new Bitmap(imagestream);
                response.Close();
                imagestream.Close();
                return buddyIcon;
            }
            catch (WebException ex)
            {
                Bitmap error = new Bitmap(@"\Program Files\GPSReminder\Images\Error.png");
                return error;
            }

        }

        private void MyLocation_Load(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(@"\Program Files\GPSReminder\Images\BlackImage.jpg");
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            g.DrawImage(BackgroundImage, 0, 0);            
        }

       

     
      
      
    }
}

