using System;

namespace Trucker
{
    public class TruckViewModel : ViewModel
    {
        private string truckNo;
        private string plateNo;
        private string driverName;
        private string age;
        
        public TruckViewModel()
        {

        }

        public TruckViewModel(Truck truck)
        {
            Id = truck.Id.ToString();
            TruckNo = truck.TruckNo;
            PlateNo = truck.PlateNo;
            DriverName = truck.DriverName;
            Age = truck.Age.ToString();
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

        public string PlateNo
        {
            get
            {
                return plateNo;
            }
            set
            {
                validateIfHasValue("Plate No", value);
                plateNo = value;
            }
        }

        public string DriverName
        {
            get
            {
                return driverName;
            }
            set
            {
                validateIfHasValue("Driver's name", value);
                driverName = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                validateIfHasValue("Age", value);
                validateIfNumbersOnly("Age", value);
                age = value;
            }
        }

        public Truck MakeTruck()
        {
            return new Truck
            {
                Id = Convert.ToInt32(Id),
                TruckNo = TruckNo,
                PlateNo = PlateNo,
                DriverName = DriverName,
                Age = Convert.ToInt32(Age)
            };
        }
    }
}
