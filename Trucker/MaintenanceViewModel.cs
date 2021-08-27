using System;

namespace Trucker
{
    public class MaintenanceViewModel : ViewModel
    {
        private string truckNo;
        private string date;
        private string type;
        private string cost;

        public MaintenanceViewModel()
        {

        }

        public MaintenanceViewModel(Maintenance maintenance)
        {
            Id = maintenance.Id.ToString();
            TruckNo = maintenance.TruckNo;
            Date = maintenance.Date;
            Type = maintenance.Type;
            Cost = maintenance.Cost.ToString();
        }

        public string Id { get; set; }

        public string TruckNo
        {
            get
            {
                return truckNo;
            }
            set
            {
                validateIfHasValue("Truck No", value);
                truckNo = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                validateIfHasValue("Date", value);
                validateDateFormat(value);
                date = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                validateIfHasValue("Maintenance Type", value);
                type = value;
            }
        }

        public string Cost
        {
            get
            {
                return cost;
            }
            set
            {
                validateIfHasValue("Maintenance Cost", value);
                validateIfNumbersOnly("Maintenance Cost", value);
                cost = value;
            }
        }

        public Maintenance MakeMaintenance()
        {
            return new Maintenance
            {
                Id = Convert.ToInt32(Id),
                TruckNo = TruckNo,
                Date = Date,
                Type = Type,
                Cost = Convert.ToDouble(Cost)
            };
        }
    }
}
