using System;

namespace Trucker
{
    public class TruckRepository : FileRepository
    {
        public TruckRepository(string storageFile)
        {
            this.storageFile = storageFile;
        }

        protected override Entity MakeEntity(string[] fields)
        {
            return new Truck
            {
                Id = Convert.ToInt32(fields[0]),
                TruckNo = fields[1],
                PlateNo = fields[2],
                DriverName = fields[3],
                Age = Convert.ToInt32(fields[4])
            };
        }
    }
}
