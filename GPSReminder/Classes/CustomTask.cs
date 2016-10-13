using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;

namespace GPSReminder.Classes
{
    public class CustomTask : Task
    {
        private int PlaceId;       
        private Task temp;

        public CustomTask( string subject , bool status, DateTime starts, DateTime due , bool reminderset , DateTime time , int placeid)
        {
            temp = new Task();
            temp.Subject = subject ;          
            temp.Complete = status;
            temp.StartDate= starts;
            temp.DueDate = due;
            temp.ReminderSet = reminderset;
            temp.ReminderTime = time;
            PlaceId = placeid;
        }
        public ItemId TaskIDProp
        {
            get { return temp.ItemId; }            
        }
        public int PlaceIdProp
        {
            get { return PlaceId; }
            set { PlaceId = value; }
        }
        public bool SaveTaskToDbase( CustomTask task)
        {
            bool ans = (bool)DatabaseOperations.AddObjectToDbase(task);
            return ans;
        }
        
        

        public void SaveTaskToOutlookFolder()
        {
            OutlookSession os = new OutlookSession();
            TaskFolder folder = os.Tasks;
            folder.Items.Add(temp);   
           
        }
    }
}
