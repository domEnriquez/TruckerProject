using System;

namespace Trucker
{
    public class TripViewModel : ViewModel
    {
        private string truckNo;
        private string date;
        private string source;
        private string destination;
        private string client;
        private string directCost;
        private string rate;

        public TripViewModel()
        {

        }

        public TripViewModel(Trip trip)
        {
            Id = trip.Id.ToString();
            truckNo = trip.TruckNo;
            date = trip.Date;
            source = trip.Source;
            destination = trip.Destination;
            client = trip.Client;
            directCost = trip.DirectCost.ToString();
            rate = trip.Rate.ToString();
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

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                validateIfHasValue("Source", value);
                source = value;
            }
        }
        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                validateIfHasValue("Destination", value);
                destination = value;
            }
        }
        public string Client
        {
            get
            {
                return client;
            }
            set
            {
                validateIfHasValue("Client", value);
                client = value;
            }
        }
        public string DirectCost
        {
            get
            {
                return directCost;
            }
            set
            {
                validateIfHasValue("Direct Cost", value);
                validateIfNumbersOnly("Direct Cost", value);
                directCost = value;
            }
        }

        public string Rate
        {
            get
            {
                return rate;
            }
            set
            {
                validateIfHasValue("Rate", value);
                validateIfNumbersOnly("Rate", value);
                rate = value;
            }
        }

        public Trip MakeTrip()
        {
            return new Trip
            {
                Id = Convert.ToInt32(Id),
                TruckNo = TruckNo,
                Date = Date,
                Source = Source,
                Destination = Destination,
                Client = Client,
                DirectCost = Convert.ToDouble(DirectCost),
                Rate = Convert.ToDouble(Rate)
            };
        }
    }
}
