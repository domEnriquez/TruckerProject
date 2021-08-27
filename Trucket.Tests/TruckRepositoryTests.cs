using NUnit.Framework;
using System;
using Trucker;

namespace Trucket.Tests
{
    [TestFixture]
    public class TruckRepositoryTests
    {
        private TruckRepository truckRepo;
        public const string STORAGE_FILE = @"C:\GitRepos\Trucker\Trucket.Tests\TestFiles\truckStorage.txt";

        [SetUp]
        public void GivenNewTruckRepoAndTruckStorageFile()
        {
            FileHelper.CreateFile(STORAGE_FILE, string.Empty);
            truckRepo = new TruckRepository(STORAGE_FILE);
        }

        [TearDown]
        public void DeleteStorageFile()
        {
            FileHelper.DeleteFile(STORAGE_FILE);
        }

        [Test]
        public void GivenNoStorageFileExists_WhenAddTruck_ThenThrowNoTripStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<FileRepository.NoExistingStorageFileExcepition>(()
                => truckRepo.Add(new Truck()));
        }


        [Test]
        public void GivenNullTrip_WhenAddTrip_ThenThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(()
                => truckRepo.Add(null));
        }

        [Test]
        public void GivenATruck_WhenAddTruck_ThenStoreTruckInFile()
        {
            Truck truck = new TruckViewModelBuilder().Build().MakeTruck();

            truckRepo.Add(truck);

            assertEqualTrucks((Truck)truckRepo.Get(0), truck);
        }

        [Test]
        public void WhenAddTruck_ThenIncrementTruckIdPerTruckAddedInFile()
        {
            Truck truck1 = new TruckViewModelBuilder()
                .Build()
                .MakeTruck();
            Truck truck2 = new TruckViewModelBuilder()
                .WithTruckNo("A1234")
                .Build()
                .MakeTruck();

            truckRepo.Add(truck1);
            truckRepo.Add(truck2);

            assertEqualTrucks((Truck)truckRepo.Get(0), truck1);
            assertEqualTrucks((Truck)truckRepo.Get(1), truck2);
        }

        private void assertEqualTrucks(Truck truck1, Truck truck2)
        {
            Assert.AreEqual(truck2.Id, truck1.Id);
            Assert.AreEqual(truck2.TruckNo, truck1.TruckNo);
            Assert.AreEqual(truck2.PlateNo, truck1.PlateNo);
            Assert.AreEqual(truck2.DriverName, truck1.DriverName);
            Assert.AreEqual(truck2.Age, truck1.Age);
        }
    }
}
