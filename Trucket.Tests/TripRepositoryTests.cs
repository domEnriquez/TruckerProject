using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Trucker;

namespace Trucket.Tests
{
    [TestFixture]
    public class TripRepositoryTests
    {
        private TripRepository tripRepo;
        public const string STORAGE_FILE = @"C:\GitRepos\Trucker\Trucket.Tests\TestFiles\tripsStorage.txt";

        [SetUp]
        public void GivenNewTripRepoAndTripStorageFile()
        {
            FileHelper.CreateFile(STORAGE_FILE, string.Empty);
            tripRepo = new TripRepository(STORAGE_FILE);
        } 

        [TearDown]
        public void DeleteStorageFile()
        {
            FileHelper.DeleteFile(STORAGE_FILE);
        }

        [Test]
        public void GivenNoStorageFileExists_WhenAddTrip_ThenThrowNoTripStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<TripRepository.NoExistingStorageFileExcepition>(() 
                => tripRepo.Add(new Trip()));
        }

        [Test]
        public void GivenNullTrip_WhenAddTrip_ThenThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(()
                => tripRepo.Add(null));
        }

        [Test]
        public void GivenATrip_WhenAddTrip_ThenStoreTripDataInFile()
        {
            tripRepo.Add(new TripViewModelDataBuilder()
                .Build()
                .MakeTrip());

            assertEqualTrips((Trip)tripRepo.Get(0), 
                new TripViewModelDataBuilder().Build().MakeTrip());
        }

        [Test]
        public void WhenAddTrip_ThenIncrementTripIdPerTripAddedInFile()
        {
            Trip trip1 = new TripViewModelDataBuilder()
                .Build()
                .MakeTrip();
            Trip trip2 = new TripViewModelDataBuilder()
                .WithTruckNo("A1234")
                .Build()
                .MakeTrip();

            tripRepo.Add(trip1);
            tripRepo.Add(trip2);

            assertEqualTrips((Trip)tripRepo.Get(0), trip1);
            assertEqualTrips((Trip)tripRepo.Get(1), trip2);
        }

        [Test]
        public void GivenNoTripStorageFile_WhenGetTrip_ThenThrowNoTripStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<TripRepository.NoExistingStorageFileExcepition>(()
                => tripRepo.Get(1));
        }

        [Test]
        public void WhenGetTripAndNoneIsFound_ThenReturnNull()
        {
            Assert.IsNull(tripRepo.Get(1));
        }

        [Test]
        public void GivenNoTripStorageFile_WhenGetTripByTruckNo_ThenThrowNoTripStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<TripRepository.NoExistingStorageFileExcepition>(()
                => tripRepo.GetTripByTruckNo("Truck1"));
        }

        [Test]
        public void GivenNullOrEmptyTruckNo_WhenGetTripByTruckNo_ThenThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(()
                => tripRepo.GetTripByTruckNo(""));

            Assert.Throws<ArgumentException>(()
                => tripRepo.GetTripByTruckNo(null));
        }

        [Test]
        public void WhenGetTripByTruckNoAndNoneIsFound_ThenReturnEmptyTripCollection()
        {
            Assert.IsEmpty(tripRepo.GetTripByTruckNo("Truck1"));
        }


        [Test]
        public void GivenNoTripStorageFile_WhenGetAllTrips_ThenThrowNoTripStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<TripRepository.NoExistingStorageFileExcepition>(()
                => tripRepo.GetAll());
        }

        [Test]
        public void WhenGetAllTripsAndNoneIsFound_ThenReturnEmptyCollection()
        {
            Assert.IsEmpty(tripRepo.GetAll());
        }

        [Test]
        public void WhenGetAllTrips_ThenReturnTripDataOfAllTruckNumbers()
        {
            Trip trip1 = new TripViewModelDataBuilder()
                .WithId(0)
                .WithTruckNo("Truck1")
                .Build()
                .MakeTrip();

            Trip trip2 = new TripViewModelDataBuilder()
                .WithId(1)
                .WithTruckNo("Truck2")
                .Build()
                .MakeTrip();

            tripRepo.Add(trip1);
            tripRepo.Add(trip2);

            IEnumerable<Entity> trips = tripRepo.GetAll();

            Assert.AreEqual(2, trips.Count());
            assertEqualTrips((Trip)trips.ElementAt(0), trip1);
            assertEqualTrips((Trip)trips.ElementAt(1), trip2);
        }

        [Test]
        public void GivenAValidTruckNumber_WhenGetTripByTruckNumber_ThenReturnTripDataOfAllTruckNumbers()
        {
            Trip trip1 = new TripViewModelDataBuilder()
                .WithId(0)
                .WithTruckNo("Truck1")
                .Build()
                .MakeTrip();

            Trip trip2 = new TripViewModelDataBuilder()
                .WithId(1)
                .WithTruckNo("Truck1")
                .Build()
                .MakeTrip();

            Trip trip3 = new TripViewModelDataBuilder()
                .WithId(2)
                .WithTruckNo("Truck2")
                .Build()
                .MakeTrip();

            tripRepo.Add(trip1);
            tripRepo.Add(trip2);
            tripRepo.Add(trip3);

            List<Trip> trips = tripRepo.GetTripByTruckNo("Truck1").ToList();

            Assert.AreEqual(2, trips.Count);
            assertEqualTrips(trips[0], trip1);
            assertEqualTrips(trips[1], trip2);
        }

        [Test]
        public void GivenNonExistingTripId_WhenDeleteTrip_ThenThrowNoExistingTripException()
        {
            Assert.Throws<FileRepository.NoExistingEntityExcepition>(()
                => tripRepo.Delete(1));
        }

        [Test]
        public void GivenExistingTripId_WhenDeleteTrip_ThenDeleteTripWithTripIdFromStorageFile()
        {
            Trip trip0 = new TripViewModelDataBuilder()
                .WithId(0)
                .Build()
                .MakeTrip();
            Trip trip1 = new TripViewModelDataBuilder()
                .WithId(1)
                .Build()
                .MakeTrip();
            tripRepo.Add(trip0);
            tripRepo.Add(trip1);

            tripRepo.Delete(0);

            Assert.IsNull(tripRepo.Get(0));
            assertEqualTrips((Trip)tripRepo.Get(1), trip1);
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
