namespace Trucker
{
    public class Truck : Entity
    {
        public string TruckNo { get; set; }
        public string PlateNo { get; set; }
        public string DriverName { get; set; }
        public int Age { get; set; }

        public override string ConvertToCsv()
        {
            return Id + ","
                + TruckNo + ","
                + PlateNo + ","
                + DriverName + ","
                + Age;
        }
    }
}
