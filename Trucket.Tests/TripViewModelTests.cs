using NUnit.Framework;
using Trucker;

namespace Trucket.Tests
{
    [TestFixture]
    public class TripViewModelTests
    {
        [Test]
        public void WhenCreateNewTripViewModelFromTrip_ThenReturnNewTripViewModelWiththeTripProperties()
        {
            Trip trip = new Trip
            {
                Id = 1,
                TruckNo = "Truck1",
                Client = "Jollibee",
                Source = "source",
                Destination = "destination",
                DirectCost = 10,
                Rate = 20
            };

            TripViewModel tripVm = new TripViewModel(trip);

            assertEqualTrips(tripVm.MakeTrip(), trip);
        }

        [Test]
        public void GivenDateNotFollowingMMDDYYYY_WhenCreateTripViewModel_ThenThrowInvalidDateTimeFormat()
        {
            Assert.Throws<TripViewModel.InvalidDateFormat>(
                () => new TripViewModelDataBuilder()
                .WithDate("2018/01/01")
                .Build());
        }

        [Test]
        public void GivenDateIsEmpty_WhenCreateTripViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<TripViewModel.EmptyArgument>(
                () => new TripViewModelDataBuilder()
                .WithDate(string.Empty)
                .Build());
        }

        [Test]
        public void GivenTruckNoIsEmpty_WhenCreateTripViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<TripViewModel.EmptyArgument>(
                () => new TripViewModelDataBuilder()
                .WithTruckNo(string.Empty)
                .Build());
        }

        [Test]
        public void GivenSourceIsEmpty_WhenCreateTripViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<TripViewModel.EmptyArgument>(
                () => new TripViewModelDataBuilder()
                .WithSource(string.Empty)
                .Build());
        }

        [Test]
        public void GivenDestinationIsEmpty_WhenCreateTripViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<TripViewModel.EmptyArgument>(
                () => new TripViewModelDataBuilder()
                .WithDestination(string.Empty)
                .Build());
        }

        [Test]
        public void GivenClientIsEmpty_WhenCreateTripViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<TripViewModel.EmptyArgument>(
                () => new TripViewModelDataBuilder()
                .WithClient(string.Empty)
                .Build());
        }

        [Test]
        public void GivenDirectCostIsEmpty_WhenCreateTripViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<TripViewModel.EmptyArgument>(
                () => new TripViewModelDataBuilder()
                .WithDirectCost(string.Empty)
                .Build());
        }

        [Test]
        public void GivenRateIsEmpty_WhenCreateTripViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<TripViewModel.EmptyArgument>(
                () => new TripViewModelDataBuilder()
                .WithRate(string.Empty)
                .Build());
        }

        [Test]
        public void GivenDirectCostIsNotANumber_WhenCreateTripViewModel_ThenThrowInvalidArgumentFormatException()
        {
            Assert.Throws<TripViewModel.InvalidArgumentFormat>(
                () => new TripViewModelDataBuilder()
                .WithDirectCost("10.x1")
                .Build());
        }

        [Test]
        public void GivenRateIsNotANumber_WhenCreateTripViewModel_ThenThrowInvalidArgumentFormatException()
        {
            Assert.Throws<TripViewModel.InvalidArgumentFormat>(
                () => new TripViewModelDataBuilder()
                .WithRate("10.x1")
                .Build());
        }

        private void assertEqualTrips(Trip actualTrip, Trip expectedTrip)
        {
            Assert.AreEqual(expectedTrip.Id, actualTrip.Id);
            Assert.AreEqual(expectedTrip.TruckNo, actualTrip.TruckNo);
            Assert.AreEqual(expectedTrip.Date, actualTrip.Date);
            Assert.AreEqual(expectedTrip.Source, actualTrip.Source);
            Assert.AreEqual(expectedTrip.Destination, actualTrip.Destination);
            Assert.AreEqual(expectedTrip.Client, actualTrip.Client);
            Assert.AreEqual(expectedTrip.DirectCost, actualTrip.DirectCost);
            Assert.AreEqual(expectedTrip.Rate, actualTrip.Rate);
        }

    }
}
