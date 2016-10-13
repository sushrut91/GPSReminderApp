using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using GPSReminder.Classes;

namespace GPSReminder.UserInterface
{
    public partial class PlaceInterface : GPSReminder.HomeScreen
    {
        string PlaceName;
        string lat;
        string lon;
        private XmlTextReader reader;
        private XmlNodeType type;
        private Classes.Place place;
        private int countrecords=0;
        private bool success; // check if database entry is successful
        private List<Place> places; // Reference to Get all places
        private Bitmap Background;
        private string copytext = "";
        private bool EditFlag = false;
        private int EditPlaceid;
        public PlaceInterface()
        {
            InitializeComponent();
        }

        private void AddressLookupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                reader = new XmlTextReader("http://maps.googleapis.com/maps/api/geocode/xml?address=" + AddressTxt.Text + "&sensor=false");
                reader.WhitespaceHandling = WhitespaceHandling.None;

                while (reader.Read())
                {
                    type = reader.NodeType;

                    // Print out info on node 
                    if (type == XmlNodeType.Element)
                    {
                        if (reader.Name == "address_component")
                        {
                            reader.Skip();
                        }
                        if (reader.Name == "formatted_address")
                        {
                            reader.Read();
                            PlaceName = reader.Value;
                        }

                        if (reader.Name == "location")
                        {
                            reader.Read();
                            reader.Read();
                            lat = reader.Value; // latitude

                            reader.Read();
                            reader.Read();
                            reader.Read();
                            lon = reader.Value; // longitude  
                            break;
                        }
                    }
                } // while ends
                reader.Close();
                AddressLbl.Text = PlaceName;
                PlaceLatitudeLbl.Text = lat.ToString();
                PlaceLongitudeLbl.Text = lon.ToString();
                PlaceLatitudeTxt.Text = lat.ToString();
                PlaceLongitudeTxt.Text = lon.ToString();
            } // try ends
            catch (UriFormatException)
            {
                MessageBox.Show("Invalid URL format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
                reader.Close();
            }
            catch (WebException)
            {
                MessageBox.Show("Can't Connect To Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            }
        }    //GeoCoding Service Implementation

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditFlag == false)
                {
                    if (PlaceLatitudeTxt.Text != "" || PlaceLongitudeTxt.Text != "")
                    {
                        countrecords = Classes.DatabaseOperations.GetNoOfPlaces();
                        countrecords++;                                                // increment no of records in dbase by 1
                        place = new Classes.Place(countrecords, PlaceNameTxt.Text,
                            double.Parse(PlaceLatitudeTxt.Text), double.Parse(PlaceLongitudeTxt.Text));
                        success = place.SavePlaceToDbase(place);

                        if (success)
                        {
                            MessageBox.Show("Place Saved Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                            PlaceNameTxt.Text = PlaceLatitudeTxt.Text = PlaceLongitudeTxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error Saving Place!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Both Latitude & Longitude Values and Retry!");
                    }

                }
                else
                {
                    place = new Classes.Place(EditPlaceid, PlaceNameTxt.Text,
                            double.Parse(PlaceLatitudeTxt.Text), double.Parse(PlaceLongitudeTxt.Text));
                    success = DatabaseOperations.UpdatePlaceObject(place);
                    if (success)
                    {
                        MessageBox.Show("Place Saved Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        PlaceNameTxt.Text = PlaceLatitudeTxt.Text = PlaceLongitudeTxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error Saving Place!");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Latitude/Longitude Value", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            
        }
     

        private void PlaceInterface_Load(object sender, EventArgs e)
        {
            Background = new Bitmap(@"\Program Files\GPSReminder\Images\BlackImage.jpg");/* places = DatabaseOperations.GetAllPlaces();

            foreach (Place p in places)
            {
                PlacesListBox.Items.Add(p.PlaceNameProp.ToString());
            }*/
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            this.Refresh();           
        }

        private void DeletePlaceBtn_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedItem != null)
            {
                if (MessageBox.Show("Are You Sure You Want To Delete the Selected Place?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Place temp = null;

                    foreach (Place p in places)
                    {
                        if (p.PlaceNameProp.Equals(PlacesListBox.SelectedItem.ToString()))
                        {
                            temp = p;
                            PlacesListBox.Items.Remove(PlacesListBox.SelectedItem);
                            break;
                        }
                    }
                    success = temp.DeletePlaceFromDbase(temp);

                    if (success)
                    {
                        MessageBox.Show("Place Successfully Deleted", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Place Deletion Unsuccessful", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select At least 1 Item & Retry");
            }
                
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            places = DatabaseOperations.GetAllPlaces();
            PlacesListBox.Items.Clear();
            foreach (Place p in places)
            {
                PlacesListBox.Items.Add(p.PlaceNameProp.ToString());
            }
            
        }

        private void EditPlaceBtn_Click(object sender, EventArgs e)
        {
           
            if (PlacesListBox.SelectedItem != null)
            {
                tabPage1.BringToFront();
                EditFlag = true;

                foreach (Place p in places)
                {
                    if (p.PlaceNameProp.Equals(PlacesListBox.SelectedItem.ToString()))
                    {
                        PlaceNameTxt.Text = p.PlaceNameProp;
                        PlaceLatitudeTxt.Text = p.PlaceLatitudeProp.ToString();
                        PlaceLongitudeTxt.Text = p.PlaceLongitudeProp.ToString();
                        EditPlaceid = p.PlaceIDProp;
                        break;
                    }
                }

            }
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Background, 0, 0);
        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Background, 0, 0);
        }

        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Background, 0, 0);
        }


      
    }
}

