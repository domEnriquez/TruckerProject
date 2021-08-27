using System;
using System.IO;
using System.Windows.Forms;

namespace Trucker.WindowsForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string TRIP_STORAGE_FILE = @"C:\Trucker\TripStorage.txt";
            const string MAINTENANCE_STORAGE_FILE = @"C:\Trucker\MaintenanceStorage.txt";
            const string TRUCK_STORAGE_FILE = @"C:\Trucker\TruckStorage.txt";

            createDirectory(@"C:\Trucker");
            createFile(TRIP_STORAGE_FILE);
            createFile(MAINTENANCE_STORAGE_FILE);
            createFile(TRUCK_STORAGE_FILE);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(
                new TripRepository(TRIP_STORAGE_FILE), 
                new MaintenanceRepository(MAINTENANCE_STORAGE_FILE), 
                new TruckRepository(TRUCK_STORAGE_FILE)));
        }

        private static void createDirectory(string directory)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(@"C:\Trucker");
        }

        private static void createFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                FileStream stream = File.Create(filePath);
                stream.Close();
            }
        }
    }
}
