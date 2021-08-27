namespace Trucker
{
    public class Maintenance : Entity
    {
        public string TruckNo { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public override string ConvertToCsv()
        {
            return Id + ","
                + TruckNo + ","
                + Date + ","
                + Type + ","
                + Cost;
        }
    }
}
