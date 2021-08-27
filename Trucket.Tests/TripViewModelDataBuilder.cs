using Trucker;

namespace Trucket.Tests
{
    public class TripViewModelDataBuilder
    {
        private int id = 0;
        private string truckNo = "1864";
        private string date = "01/03/2019";
        private string source = "source";
        private string destination = "destination";
        private string client = "Jollibee";
        private string directCost = "100";
        private string rate = "300";

        public TripViewModelDataBuilder WithId(int id)
        {
            this.id = id;

            return this;
        }

        public TripViewModelDataBuilder WithTruckNo(string truckNo)
        {
            this.truckNo = truckNo;

            return this;
        }

        public TripViewModelDataBuilder WithDate(string date)
        {
            this.date = date;

            return this;
        }

        public TripViewModelDataBuilder WithSource(string source)
        {
            this.source = source;

            return this;
        }

        public TripViewModelDataBuilder WithDestination(string destination)
        {
            this.destination = destination;

            return this;
        }

        public TripViewModelDataBuilder WithClient(string client)
        {
            this.client = client;

            return this;
        }

        public TripViewModelDataBuilder WithDirectCost(string directCost)
        {
            this.directCost = directCost;

            return this;
        }
        public TripViewModelDataBuilder WithRate(string rate)
        {
            this.rate = rate;

            return this;
        }

        public TripViewModel Build()
        {
            return new TripViewModel
            {
                Id = id.ToString(),
                TruckNo = truckNo,
                Date = date,
                Source = source,
                Destination = destination,
                Client = client,
                DirectCost = directCost,
                Rate = rate
            };
        }

    }
}
