using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GPSReminder.Classes
{
    class Place
    {
        private int PlaceID;
        private string PlaceName;
        private double Place_Latitude;
        private double Place_Longitude;

        public Place(int PlaceID, string PlaceName, double Place_Latitude, double Place_Longitude)
        {
            this.PlaceID = PlaceID;
            this.PlaceName = PlaceName;
            this.Place_Latitude = Place_Latitude;
            this.Place_Longitude = Place_Longitude;
        }
        public Place(int PlaceID, string PlaceName)
        {
            this.PlaceID = PlaceID;
            this.PlaceName = PlaceName;
        }

        public int PlaceIDProp
        {
            get { return PlaceID; }
            set { PlaceID = value; }
        }

        public string PlaceNameProp
        {
            get { return PlaceName; }
            set { PlaceName = value; }
        }

        public double PlaceLatitudeProp
        {
            get { return Place_Latitude; }
            set { Place_Latitude = value; }
        }

        public double PlaceLongitudeProp
        {
            get { return Place_Longitude; }
            set { Place_Longitude = value; }
        }
        public bool SavePlaceToDbase( Place p)
        {    
           
           bool ans=DatabaseOperations.AddObjectToDbase(p);
           return ans;
        }
        public bool DeletePlaceFromDbase( Place p)
        {
            bool ans = DatabaseOperations.DeleteObjectFromDbase(p);
            return ans;
        }
    }
}
