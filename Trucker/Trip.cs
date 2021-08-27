namespace Trucker
{
    public class Trip : Entity
    {
        public string TruckNo { get; set; }
        public string Date { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Client { get; set; }
        public double DirectCost { get; set; }
        public double Rate { get; set; }
        public override string ConvertToCsv()
        {
            return Id + ","
                + TruckNo + ","
                + Date + ","
                + Source + ","
                + Destination + ","
                + Client + ","
                + DirectCost + ","
                + Rate;
        }
    }
}
