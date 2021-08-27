using System;
using System.Collections.Generic;
using System.IO;

namespace Trucker
{
    public class TripRepository : FileRepository
    {
        public TripRepository(string storageFile)
        {
            this.storageFile = storageFile;
        }

        public IEnumerable<Trip> GetTripByTruckNo(string truckNo)
        {
            if (!File.Exists(storageFile))
                throw new NoExistingStorageFileExcepition("There is no existing storage file");

            if (string.IsNullOrEmpty(truckNo))
                throw new ArgumentException("Empty or null truck number is not allowed when getting trip");

            List<Trip> trips = new List<Trip>();

            using (StreamReader file = new StreamReader(storageFile))
            {
                string line = string.Empty;

                while ((line = file.ReadLine()) != null)
                {
                    string[] tripData = line.Split(',');

                    if (tripData[1] == truckNo)
                        trips.Add((Trip)MakeEntity(tripData));
                }
            }
            
            return trips;
        }

        protected override Entity MakeEntity(string[] fields)
        {
            return new Trip
            {
                Id = Convert.ToInt32(fields[0]),
                TruckNo = fields[1],
                Date = fields[2],
                Source = fields[3],
                Destination = fields[4],
                Client = fields[5],
                DirectCost = Convert.ToDouble(fields[6]),
                Rate = Convert.ToDouble(fields[7])
            };
        }
    }
}
