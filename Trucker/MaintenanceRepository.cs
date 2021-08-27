using System;

namespace Trucker
{
    public class MaintenanceRepository : FileRepository
    {
        public MaintenanceRepository(string storageFile)
        {
            this.storageFile = storageFile;
        }

        protected override Entity MakeEntity(string[] fields)
        {
            return new Maintenance
            {
                Id = Convert.ToInt32(fields[0]),
                TruckNo = fields[1],
                Date = fields[2],
                Type = fields[3],
                Cost = Convert.ToInt32(fields[4])
            };
        }
    }
}
