using Trucker;

namespace Trucket.Tests
{
    public class MaintenanceViewModelBuilder
    {
        private string id = "0";
        private string truckNo = "Truck1";
        private string date = "01/01/2019";
        private string type = "Fuel";
        private string cost = "20";


        public MaintenanceViewModelBuilder WithId(string id)
        {
            this.id = id;
            return this;
        }

        public MaintenanceViewModelBuilder WithTruckNo(string truckNo)
        {
            this.truckNo = truckNo;
            return this;
        }

        public MaintenanceViewModelBuilder WithDate(string date)
        {
            this.date = date;
            return this;
        }

        public MaintenanceViewModelBuilder WithType(string type)
        {
            this.type = type;
            return this;
        }

        public MaintenanceViewModelBuilder WithCost(string cost)
        {
            this.cost = cost;
            return this;
        }

        public MaintenanceViewModel Build()
        {
            return new MaintenanceViewModel
            {
                Id = id,
                TruckNo = truckNo,
                Date = date,
                Type = type,
                Cost = cost
            };
        }
    }
}
