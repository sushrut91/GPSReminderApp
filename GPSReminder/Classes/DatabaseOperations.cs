using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data;
using Microsoft.WindowsMobile.PocketOutlook;

namespace GPSReminder.Classes
{
    class DatabaseOperations
    {
        private static double AlarmDistance = 2.401867609;
        private static string connectionstring = @"Data Source=Program Files\GPSReminder\TasksAndPlaces.sdf; password=''";
        private static SqlCeConnection con = new SqlCeConnection(connectionstring);
        private static List<int> Taskidlist = new List<int>();
        private static string sub = null;
        private static SqlCeDataAdapter adpt = new SqlCeDataAdapter();
        private static DataSet ds = new DataSet();
        private static CustomTask task;
        private static Place tempplace;

        // Below Members Used in Check Proximity
        private static double temp_lat;
        private static double temp_longi;
        private static double lat_difference;
        private static double longi_difference;
        private static double distance_calculation;

        public static bool AddObjectToDbase(Object o)
        {
            bool answer; // see if database insertion is successful or not           
            try
            {
                SqlCeCommand command = new SqlCeCommand();
                con.Open();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                int i = 0; // count added rows


                if (o is CustomTask)
                {
                    task = o as CustomTask;
                    command.CommandText = "Insert into Tasks values (" + task.TaskIDProp + "," + task.PlaceIdProp.ToString() + ")";
                    i = command.ExecuteNonQuery();

                }
                else if (o is Place)
                {
                    tempplace = o as Place;
                    command.CommandText = "Insert into Places values (" + tempplace.PlaceIDProp + ",'" + tempplace.PlaceNameProp + "'," +
                        tempplace.PlaceLatitudeProp + "," + tempplace.PlaceLongitudeProp + ");";
                    i = command.ExecuteNonQuery();
                }
                con.Close();
                if (i > 0)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            catch (Exception)
            {
                answer = false;
                con.Close();
            }
            return answer;
        }

        public static bool DeleteObjectFromDbase(Object o)
        {
            bool answer; // see if record deletion is successful or not           
            try
            {
                SqlCeCommand command = new SqlCeCommand();
                con.Open();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                int i = 0; // count deleted rows


                if (o is CustomTask)
                {
                    task = o as CustomTask;
                    command.CommandText = "DELETE FROM Tasks where Task_ID=" + task.ItemId;
                    i = command.ExecuteNonQuery();

                }
                else if (o is Place)
                {
                    tempplace = o as Place;
                    command.CommandText = "DELETE FROM Places where Place_ID=" + tempplace.PlaceIDProp.ToString();
                    i = command.ExecuteNonQuery();
                }
                con.Close();
                if (i > 0)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            catch (Exception)
            {
                answer = false;
                con.Close();
            }
            return answer;
        }
        public static int GetNoOfPlaces()
        {
            int count;
            int max = 0;
            SqlCeCommand CountCommand = new SqlCeCommand();
            SqlCeCommand MaxCommand = new SqlCeCommand();
            con.Open();

            CountCommand.Connection = con;
            CountCommand.CommandType = CommandType.Text;
            CountCommand.CommandText = "SELECT COUNT(Place_ID) FROM Places";
            count = (int)CountCommand.ExecuteScalar();

            MaxCommand.Connection = con;
            MaxCommand.CommandType = CommandType.Text;
            MaxCommand.CommandText = "SELECT MAX(Place_ID) FROM Places ;";

            if (count > 0)
            {
                max = (int)MaxCommand.ExecuteScalar();
            }
            con.Close();
            return max;
        }
        public static int GetNoOfTasks()
        {

            con.Open();
            SqlCeCommand selectcommand = new SqlCeCommand();
            selectcommand.Connection = con;
            selectcommand.CommandType = CommandType.Text;
            selectcommand.CommandText = "SELECT COUNT(Task_ID) FROM TASKS ;";
            int count = (int)selectcommand.ExecuteScalar();
            con.Close();
            return count;

        }
        public static List<Place> GetAllPlaces()
        {
            int placeid;
            string placename;
            List<Place> places = new List<Place>(); // create a list object      

            con.Open();
            string query = "select * from Places";
            SqlCeCommand selectCmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = selectCmd.ExecuteReader();
            while (dr.Read())
            {
                placeid = (int)dr["Place_ID"];
                placename = dr["Place_Name"].ToString();
                places.Add(new Place(placeid, placename));
            }
            con.Close();
            return places;
        }


        public static List<int> GetTaskIDList(int PlaceID)
        {
            int taskid = 0;

            SqlCeCommand Select_Tasks = new SqlCeCommand();
            //con.Open();
            Select_Tasks.Connection = con;
            Select_Tasks.CommandType = CommandType.Text;
            Select_Tasks.CommandText = "SELECT Task_ID FROM TASKS WHERE Place_ID=" + PlaceID;
            adpt.SelectCommand = Select_Tasks;
            adpt.Fill(ds, "tasks");

            foreach (DataRow dr in ds.Tables["tasks"].Rows)
            {
                taskid = (int)dr["Task_ID"];

                Taskidlist.Add(taskid);
            }
            return Taskidlist;
        }
        public static string GetPlaceName(int PlaceID)
        {
            con.Open();
            SqlCeCommand selectcommand = new SqlCeCommand();
            selectcommand.Connection = con;
            selectcommand.CommandType = CommandType.Text;
            selectcommand.CommandText = "SELECT Place_Name FROM Places WHERE Place_ID=" + PlaceID;
            string placename = (string)selectcommand.ExecuteScalar();
            con.Close();
            return placename;
        }
        public static int GetPlaceID(int TaskID)
        {
            int noofplaces = GetNoOfPlaces();
            if (noofplaces > 0)
            {
                con.Open();
                SqlCeCommand selectcommand = new SqlCeCommand();
                selectcommand.Connection = con;
                selectcommand.CommandType = CommandType.Text;
                selectcommand.CommandText = "SELECT Place_ID FROM Tasks WHERE Task_ID=" + TaskID;
                int placeid = (int)selectcommand.ExecuteScalar();
                con.Close();
                return placeid;
            }
            else
            {
                return -1;         // no place exisists
            }
        }

        public static int CheckProximity(double latitude, double longitude)
        {
            SqlCeCommand SelectCmd = new SqlCeCommand();
            //con.Open();
            SelectCmd.Connection = con;
            SelectCmd.CommandType = CommandType.Text;
            SelectCmd.CommandText = "SELECT * FROM PLACES;";
            adpt.SelectCommand = SelectCmd;
            adpt.Fill(ds, "places");

            if (ds.Tables["places"].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables["places"].Rows)
                {
                    temp_lat = (double)dr["Place_Latitude"]; 
                    temp_longi = (double)dr["Place_Longitude"];

                    lat_difference = latitude - temp_lat;
                    longi_difference = longitude - temp_longi;

                    distance_calculation = Math.Pow(lat_difference, 2) + Math.Pow(longi_difference, 2); // temp lat is the value from place in dbase

                    if (Math.Sqrt(distance_calculation) < AlarmDistance)
                    {
                        return (int)dr["Place_ID"];
                    }
                    else
                    {
                        return -1;        // -1 indicates nothing matched
                    }
                }
            }

            return -1;                //nothing matched
        }
        public static string GetTaskSubjectFromFolder(int taskid)
        {
            OutlookSession os = new OutlookSession();
            TaskFolder folder = os.Tasks;
            TaskCollection collection = folder.Items;

            foreach (Task temp in collection)
            {
                if (temp.ItemId.ToString().Equals(taskid.ToString()))
                {
                    sub = temp.Subject.ToString();
                }
            }
            return sub;
        }
        public static void RemoveTaskPlaceAssociation(int taskid)
        {
            SqlCeCommand selectcommand = new SqlCeCommand();
            selectcommand.Connection = con;
            selectcommand.CommandType = CommandType.Text;
            selectcommand.CommandText = "Insert Into Tasks(Place_ID) values(0);";
            selectcommand.ExecuteNonQuery();
        }
        public static TaskCollection GetAllTasksFromFolder()
        {
            OutlookSession os = new OutlookSession();
            TaskFolder folder = os.Tasks;
            TaskCollection collection = folder.Items;
            return collection;
        }


        public static List<ItemId> GetTaskIdFromOutlookSession()
        {
            List<ItemId> Idlist = new List<ItemId>();


            OutlookSession os = new OutlookSession();
            TaskFolder folder = os.Tasks;

            foreach (Task t in folder.Items)
            {
                Idlist.Add(t.ItemId);
            }
            return Idlist;

        }



        public static bool DeleteTaskFromDb(ItemId i)
        {
            SqlCeCommand insertCmd = new SqlCeCommand();
            bool answer; // see if record deletion is successful or not           
            try
            {
                con.ConnectionString = @"Data Source=Program Files\GPSReminder\TasksAndPlaces.sdf; password=''";
                con.Open();
                insertCmd.Connection = con;
                insertCmd.CommandType = CommandType.Text;
                int i1 = 0; // count deleted rows

                insertCmd.CommandText = "DELETE FROM Tasks where Task_ID="+i.ToString();
                i1 = insertCmd.ExecuteNonQuery();


                con.Close();
                if (i1 > 0)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            catch (Exception)
            {
                answer = false;
            }
            return answer;
        }

        public static void DeleteTasksFromDatabase(int id)
        {
            SqlCeCommand insertCmd = new SqlCeCommand();
            bool answer; // see if record deletion is successful or not           
           
            
                con.ConnectionString = @"Data Source=Program Files\GPSReminder\TasksAndPlaces.sdf; password=''";
                con.Open();
                insertCmd.Connection = con;
                insertCmd.CommandType = CommandType.Text;
                int di = 0; // count deleted rows

                insertCmd.CommandText = "DELETE FROM Tasks where Task_ID="+id;
                di = insertCmd.ExecuteNonQuery();


                con.Close();
               
           
        }


        public static bool CheckIDExistance(ItemId id)
        {
            int taskid;
            bool answer = false;
           
            SqlCeCommand selectcmd = new SqlCeCommand();
            selectcmd.Connection = con;
            selectcmd.CommandType = CommandType.Text;

            selectcmd.CommandText = "Select * from Tasks;";
            adpt.SelectCommand = selectcmd;
            adpt.Fill(ds, "tasks");

            string s = id.ToString();
            foreach (DataRow dr in ds.Tables["tasks"].Rows)
            {
                taskid = Int32.Parse(dr["Task_ID"].ToString());
                string ts = taskid.ToString();

                if (ts.Equals(s))
                {
                    answer = true;

                }
                else
                {
                    answer = false;
                }



            }
            con.Close();

            return answer;
        }

        public static bool UpdatePlaceObject(Place place)
        {
            SqlCeCommand UpdateCommand = new SqlCeCommand();
            UpdateCommand.Connection = con;
            con.Open();
            UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.CommandText = "UPDATE PLACES SET Place_Name='"+place.PlaceNameProp+"', Place_Longitude="+place.PlaceLongitudeProp+", Place_Latitude="+ place.PlaceLatitudeProp +
                "WHERE Place_ID=" + place.PlaceIDProp ;
            int result=UpdateCommand.ExecuteNonQuery();
            if (result > 0)
                return true;
            else
                return false;
        }

        //public static bool DeleteTaskFromOutlook(ItemId id)
        //{
        //    Task temp = new Task();
        //    bool delete = false;
        //    OutlookSession os = new OutlookSession();
        //    TaskFolder folder = os.Tasks;

        //    if (temp.ItemId == id)
        //    {
        //        folder.Items.Remove(temp);
        //        delete = true;
        //    }

        //    return delete;

        //}

        public static void SynchronizeDatabaseWithOutlook()
        {
            bool flag, delete = false;    

            List<ItemId> OutlookID = DatabaseOperations.GetTaskIdFromOutlookSession();
            if(OutlookID != null)
            {
                 foreach (ItemId id in OutlookID)
                   {

                       flag = CheckIDExistance(id);

                       if (flag)
                       {
                           delete = DeleteTaskFromDb(id);
                       }
                   }
            }         


        }

  } // class Ends
        
 } // Namespace Ends

