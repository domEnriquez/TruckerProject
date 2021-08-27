using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Trucker;

namespace Trucket.Tests
{
    [TestFixture]
    public class MaintenanceRepositoryTests 
    {
        private MaintenanceRepository maintenanceRepo;
        private const string STORAGE_FILE = @"C:\GitRepos\Trucker\Trucket.Tests\TestFiles\maintenanceStorage.txt";

        [SetUp]
        public void GivenMaintenanceRepoAndTripStorageFile()
        {
            maintenanceRepo = new MaintenanceRepository(STORAGE_FILE);
            FileHelper.CreateFile(STORAGE_FILE, string.Empty);
        }


        [TearDown]
        public void DeleteStorageFile()
        {
            FileHelper.DeleteFile(STORAGE_FILE);
        }


        [Test]
        public void GivenNullMaintenance_WhenAddMaintenance_ThenThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(()
                => maintenanceRepo.Add(null));
        }

        [Test]
        public void GivenNonExistingStorageFile_WhenAddMaintenance_ThenThrowNoExistingStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<FileRepository.NoExistingStorageFileExcepition>(()
                => maintenanceRepo.Add(new Maintenance()));
        }

        [Test]
        public void GivenValidMaintenanceObject_WhenAddMaintenance_ThenAddMaintenanceToStorageFile()
        {
            Maintenance m = new MaintenanceViewModelBuilder().Build().MakeMaintenance();

            maintenanceRepo.Add(m);

            assertEqualMaintenance((Maintenance)maintenanceRepo.Get(0), m);
        }

        [Test]
        public void WhenAddMaintenance_ThenIncrementMaintenanceIdPerAddedMaintenance()
        {
            Maintenance m0 = new MaintenanceViewModelBuilder()
                .WithId("0")
                .WithTruckNo("T1")
                .Build()
                .MakeMaintenance();

            Maintenance m1 = new MaintenanceViewModelBuilder()
                .WithId("1")
                .WithTruckNo("T2")
                .Build()
                .MakeMaintenance();

            maintenanceRepo.Add(m0);
            maintenanceRepo.Add(m1);

            assertEqualMaintenance((Maintenance)maintenanceRepo.Get(0), m0);
            assertEqualMaintenance((Maintenance)maintenanceRepo.Get(1), m1);
        }

        [Test]
        public void GivenNoStorageFile_WhenGetAllMaintenance_ThenThrowNoExistingStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<FileRepository.NoExistingStorageFileExcepition>(()
                => maintenanceRepo.GetAll());
        }

        [Test]
        public void WhenGetAllMaintenance_ThenReturnAllMaintenanceFromStorageFile()
        {
            Maintenance m0 = new MaintenanceViewModelBuilder()
                .WithId("0")
                .WithTruckNo("T1")
                .Build()
                .MakeMaintenance();

            Maintenance m1 = new MaintenanceViewModelBuilder()
                .WithId("1")
                .WithTruckNo("T2")
                .Build()
                .MakeMaintenance();

            maintenanceRepo.Add(m0);
            maintenanceRepo.Add(m1);

            IEnumerable<Maintenance> maintenances = maintenanceRepo.GetAll().OfType<Maintenance>();

            Assert.AreEqual(2, maintenances.Count());
            assertEqualMaintenance(maintenances.ElementAt(0), m0);
            assertEqualMaintenance(maintenances.ElementAt(1), m1);
        }

        [Test]
        public void GivenNoExistingStorageFile_WhenGetMaintenance_ThenThrowNoExistingStorageFileException()
        {
            FileHelper.DeleteFile(STORAGE_FILE);

            Assert.Throws<FileRepository.NoExistingStorageFileExcepition>(
                () => maintenanceRepo.Get(1));
        }

        [Test]
        public void GivenExistingMaintenance_WhenDeleteMaintenance_ThenDeleteMaintenanceFromStorageFile()
        {
            Maintenance m0 = new MaintenanceViewModelBuilder()
                .WithId("0")
                .Build()
                .MakeMaintenance();
            Maintenance m1 = new MaintenanceViewModelBuilder()
                .WithId("1")
                .Build()
                .MakeMaintenance();

            maintenanceRepo.Add(m0);
            maintenanceRepo.Add(m1);

            maintenanceRepo.Delete(0);

            Assert.IsNull(maintenanceRepo.Get(0));
            assertEqualMaintenance((Maintenance)maintenanceRepo.Get(1), m1);
        }

        [Test]
        public void GivenNonExistingMaintenance_WhenDeleteMaintenance_ThenThrowNoExistingMaintenanceException()
        {
            Assert.Throws<FileRepository.NoExistingEntityExcepition>(
                () => maintenanceRepo.Delete(0));
        }

        private void assertEqualMaintenance(Maintenance actual, Maintenance expected)
        {
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Date, actual.Date);
            Assert.AreEqual(expected.TruckNo, actual.TruckNo);
            Assert.AreEqual(expected.Type, actual.Type);
            Assert.AreEqual(expected.Cost, actual.Cost);
        }
    }
}
