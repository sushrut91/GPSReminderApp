using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GPSReminder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            GPSReminder.Classes.DatabaseOperations.SynchronizeDatabaseWithOutlook();
            Application.Run(new HomeScreen());           
        }
    }
}