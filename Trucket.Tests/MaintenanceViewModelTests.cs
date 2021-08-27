using NUnit.Framework;
using Trucker;

namespace Trucket.Tests
{
    [TestFixture]
    public class MaintenanceViewModelTests
    {
        [Test]
        public void CanCreateMaintenanceViewModel()
        {
            MaintenanceViewModel viewModel = new MaintenanceViewModel();

            Assert.IsNotNull(viewModel);

        }

        [Test]
        public void GivenEmptyTruckNo_WhenCreateMaintenanceViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<MaintenanceViewModel.EmptyArgument>(() => 
                new MaintenanceViewModelBuilder().WithTruckNo(string.Empty).Build());
        }


        [Test]
        public void GivenEmptyDate_WhenCreateMaintenanceViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<MaintenanceViewModel.EmptyArgument>(() => 
                new MaintenanceViewModelBuilder().WithDate(string.Empty).Build());
        }

        [Test]
        public void GivenDateNotFollowingMMDDYYYY_WhenCreateMaintenanceViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<MaintenanceViewModel.InvalidDateFormat>(() =>
                new MaintenanceViewModelBuilder().WithDate("2019/11/20").Build());
        }

        [Test]
        public void GivenEmptyMaintenanceType_WhenCreateMaintenanceViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<MaintenanceViewModel.EmptyArgument>(() =>
                new MaintenanceViewModelBuilder().WithType(string.Empty).Build());
        }

        [Test]
        public void GivenEmptyMaintenanceCost_WhenCreateMaintenanceViewModel_ThenThrowEmptyArgumentException()
        {
            Assert.Throws<MaintenanceViewModel.EmptyArgument>(() =>
                new MaintenanceViewModelBuilder().WithCost(string.Empty).Build());
        }

        [Test]
        public void GivenCostIsNotANumber_WhenCreateMaintenanceViewModel_ThenThrowInvalidArgumentFormatException()
        {
            Assert.Throws<MaintenanceViewModel.InvalidArgumentFormat>(() =>
                new MaintenanceViewModelBuilder().WithCost("abcd").Build());
        }
    }   
}
