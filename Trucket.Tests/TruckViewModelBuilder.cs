using Trucker;

namespace Trucket.Tests
{
    public class TruckViewModelBuilder
    {
        private string id = "0";
        private string truckNo = "T1";
        private string plateNo = "XRU141";
        private string driverName = "Bogart";
        private string age = "5";

        public TruckViewModelBuilder WithId(string id)
        {
            this.id = id;
            return this;
        }

        public TruckViewModelBuilder WithTruckNo(string truckNo)
        {
            this.truckNo = truckNo;
            return this;
        }

        public TruckViewModelBuilder WithPlateNo(string plateNo)
        {
            this.plateNo = plateNo;
            return this;
        }

        public TruckViewModelBuilder WithDriverName(string driverName)
        {
            this.driverName = driverName;
            return this;
        }

        public TruckViewModelBuilder WithAge(string age)
        {
            this.age = age;
            return this;
        }

        public TruckViewModel Build()
        {
            return new TruckViewModel
            {
                Id = id,
                TruckNo = truckNo,
                PlateNo = plateNo,
                DriverName = driverName,
                Age = age
            };
        }
    }
}
