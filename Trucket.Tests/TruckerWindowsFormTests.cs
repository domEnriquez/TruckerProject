using NUnit.Extensions.Forms;
using NUnit.Framework;
using System.Collections.Generic;
using System.Windows.Forms;
using Trucker;
using Trucker.WindowsForm;
using static System.Windows.Forms.CheckedListBox;

namespace Trucket.Tests
{
    public class TruckerWindowsFormTests
    {
        private const string TRIP_STORAGE_FILE = @"C:\GitRepos\Trucker\Trucket.Tests\TestFiles\tripsStorage.txt";
        private const string MAINTENANCE_STORAGE_FILE = @"C:\GitRepos\Trucker\Trucket.Tests\TestFiles\maintenanceStorage.txt";
        private const string TRUCK_STORAGE_FILE = @"C:\GitRepos\Trucker\Trucket.Tests\TestFiles\truckStorage.txt";
        private Form1 form;
        private TripRepository tripRepo;
        private MaintenanceRepository maintRepo;
        private TruckRepository truckRepo;

        [SetUp]
        public void GeneralSetup()
        {
            setUpTripRepository();
            setUpMaintenanceRepository();
            setUpTruckRepository();
        }

        [TearDown]
        public void CloseForm()
        {
            FileHelper.DeleteFile(TRIP_STORAGE_FILE);
            FileHelper.DeleteFile(MAINTENANCE_STORAGE_FILE);
            FileHelper.DeleteFile(TRUCK_STORAGE_FILE);
            form.Close();
        }

        [TestFixture]
        public class OnFormLoadTests : TruckerWindowsFormTests
        {
            [Test]
            public void WhenFormLoads_ThenPopulateTruckNumComboBoxes()
            {
                truckRepo.Add(new TruckViewModelBuilder().WithTruckNo("T1").Build().MakeTruck());
                truckRepo.Add(new TruckViewModelBuilder().WithTruckNo("T2").Build().MakeTruck());

                form = new Form1(tripRepo, maintRepo, truckRepo);
                form.Show();

                assertComboBoxHasThreeItems(NameConstants.GET_TRUCK_TRUCK_NO_COMBO);
                assertComboBoxHasThreeItems(NameConstants.ADD_TRIP_TRUCK_NO_COMBO);
                assertComboBoxHasThreeItems(NameConstants.GET_TRIP_TRUCK_NO_COMBO);
                assertComboBoxHasThreeItems(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO);
                assertComboBoxHasThreeItems(NameConstants.GET_MAINTENANCE_TRUCK_NO_COMBO);
            }

            [Test]
            public void WhenFormLoads_ThenShowIncomeStatementOfAllTrucks()
            {
                truckRepo.Add(new TruckViewModelBuilder().WithTruckNo("T1").Build().MakeTruck());
                truckRepo.Add(new TruckViewModelBuilder().WithTruckNo("T2").Build().MakeTruck());
                tripRepo.Add(new TripViewModelDataBuilder()
                    .WithTruckNo("T1")
                    .WithRate("100")
                    .WithDirectCost("30")
                    .Build().MakeTrip());
                tripRepo.Add(new TripViewModelDataBuilder()
                    .WithTruckNo("T1")
                    .WithRate("250")
                    .WithDirectCost("150")
                    .Build().MakeTrip());
                tripRepo.Add(new TripViewModelDataBuilder()
                    .WithTruckNo("T2")
                    .WithRate("80")
                    .WithDirectCost("10")
                    .Build().MakeTrip());
                maintRepo.Add(new MaintenanceViewModelBuilder()
                    .WithTruckNo("T1")
                    .WithCost("30")
                    .Build()
                    .MakeMaintenance());

                form = new Form1(tripRepo, maintRepo, truckRepo);
                form.Show();

                ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);

                CheckedItemCollection checkedItems = ccb["CheckedItems"] as CheckedItemCollection;
                Assert.AreEqual(3, checkedItems.Count);
                Assert.AreEqual("430", new TextBoxTester(NameConstants.INCOME_STATEMENT_REVENUE).Text);
                Assert.AreEqual("190", new TextBoxTester(NameConstants.INCOME_STATEMENT_DIRECT_COST).Text);
                Assert.AreEqual("240", new TextBoxTester(NameConstants.INCOME_STATEMENT_GROSS_PROFIT).Text);
                Assert.AreEqual("30", new TextBoxTester(NameConstants.INCOME_STATEMENT_MAINT_FEE).Text);
                Assert.AreEqual("210", new TextBoxTester(NameConstants.INCOME_STATEMENT_NET_INCOME).Text);
            }

            [Test]
            public void WhenFormLoads_ThenPopulateTrucksTableWithAllTrucks()
            {
                truckRepo.Add(new TruckViewModelBuilder().Build().MakeTruck());
                truckRepo.Add(new TruckViewModelBuilder().Build().MakeTruck());

                form = new Form1(tripRepo, maintRepo, truckRepo);
                form.Show();

                Assert.AreEqual(2, getTableRows(NameConstants.GET_TRUCK_DATA_GRID).Count);
            }

            [Test]
            public void WhenFormLoads_ThenPopulateTripsTableWithAllTrips()
            {
                tripRepo.Add(new TripViewModelDataBuilder().Build().MakeTrip());
                tripRepo.Add(new TripViewModelDataBuilder().Build().MakeTrip());

                form = new Form1(tripRepo, maintRepo, truckRepo);
                form.Show();

                Assert.AreEqual(2, getTableRows(NameConstants.GET_TRIP_DATA_GRID).Count);
            }

            [Test]
            public void WhenFormLoads_ThenPopulateMaintenanceTableWithAllMaintenances()
            {
                maintRepo.Add(new MaintenanceViewModelBuilder().Build().MakeMaintenance());
                maintRepo.Add(new MaintenanceViewModelBuilder().Build().MakeMaintenance());

                form = new Form1(tripRepo, maintRepo, truckRepo);
                form.Show();

                Assert.AreEqual(2, getTableRows(NameConstants.GET_MAINTENANCE_DATA_GRID).Count);
            }
        }

        [TestFixture]
        public class FormOperationsTests : TruckerWindowsFormTests
        {
            [SetUp]
            public void GivenNewForm()
            {
                form = new Form1(tripRepo, maintRepo, truckRepo);
                form.Show();
            }

            [TestFixture]
            public class TruckOperationsTests : FormOperationsTests
            {
                [SetUp]
                public void SetUp()
                {
                }

                [Test]
                public void WhenAddTruckButtonIsClicked_ThenAddTrucDetailskToStorageFile()
                {
                    clickTab(NameConstants.ADD_TRUCK_TAB);

                    new ModalFormTester().ExpectModal("Notification", closeNotificationMessageBox);

                    TruckViewModel truckVm = new TruckViewModelBuilder().Build();

                    new TextBoxTester(NameConstants.ADD_TRUCK_TRUCK_NO).Enter(truckVm.TruckNo);
                    new TextBoxTester(NameConstants.ADD_TRUCK_PLATE_NO).Enter(truckVm.PlateNo);
                    new TextBoxTester(NameConstants.ADD_TRUCK_DRIVER_NAME).Enter(truckVm.DriverName);
                    new TextBoxTester(NameConstants.ADD_TRUCK_TRUCK_AGE).Enter(truckVm.Age);

                    new ButtonTester(NameConstants.ADD_TRUCK_BUTTON).Click();

                    assertEqualTruck(truckVm.MakeTruck(), (Truck)truckRepo.Get(0));
                }

                [Test]
                public void WhenANewTruckIsAdded_ThenUpdateItemsInTruckCheckedComboBox()
                {
                    addTruckByUi(new TruckViewModelBuilder().WithTruckNo("T1").Build());
                    addTruckByUi(new TruckViewModelBuilder().WithTruckNo("T2").Build());

                    clickTab(NameConstants.INCOME_STATEMENT_TAB);

                    ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);
                    CheckedListBox.ObjectCollection items = ccb["CcbItems"] as CheckedListBox.ObjectCollection;

                    Assert.AreEqual(3, items.Count);
                    Assert.AreEqual("All", ((CCBoxItem)items[0]).Name);
                    Assert.AreEqual("T1", ((CCBoxItem)items[1]).Name);
                    Assert.AreEqual("T2", ((CCBoxItem)items[2]).Name);
                }

                [Test]
                public void GivenAllTrucksInComboBox_WhenFilterButtonClicked_ThenShowAllTrucksInTruckTable()
                {
                    truckRepo.Add(new TruckViewModelBuilder()
                        .WithTruckNo("T1")
                        .Build()
                        .MakeTruck());
                    truckRepo.Add(new TruckViewModelBuilder()
                        .WithTruckNo("T2")
                        .Build()
                        .MakeTruck());

                    clickTab(NameConstants.GET_TRUCK_TAB);

                    new ControlTester(NameConstants.GET_TRUCK_TRUCK_NO_COMBO)["SelectedItem"] = "All";

                    new ButtonTester(NameConstants.GET_TRUCK_FILTER_BUTTON).Click();

                    Assert.AreEqual(2, getTableRows(NameConstants.GET_TRUCK_DATA_GRID).Count);
                }

                [Test]
                public void GivenATruckNoInComboBox_WhenFilterButtonClicked_ThenFilterTruckTableByTruckNo()
                {
                    populateComboBox(NameConstants.GET_TRUCK_TRUCK_NO_COMBO, new List<string> { "T1", "T2" });
                    truckRepo.Add(new TruckViewModelBuilder()
                        .WithTruckNo("T1")
                        .Build()
                        .MakeTruck());
                    truckRepo.Add(new TruckViewModelBuilder()
                        .WithTruckNo("T2")
                        .Build()
                        .MakeTruck());

                    clickTab(NameConstants.GET_TRUCK_TAB);

                    new ControlTester(NameConstants.GET_TRUCK_TRUCK_NO_COMBO)["SelectedItem"] = "T1";

                    new ButtonTester(NameConstants.GET_TRUCK_FILTER_BUTTON).Click();

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRUCK_DATA_GRID);
                    Assert.AreEqual(1, rows.Count);
                    Assert.AreEqual("T1", getValueInColumn(rows[0], NameConstants.GET_TRUCK_TRUCK_NO_DATA_GRID));
                }

                [Test]
                public void WhenANewTruckIsAdded_ThenUpdateItemsInTruckComboBoxes()
                {
                    addTruckByUi(new TruckViewModelBuilder().WithTruckNo("T1").Build());
                    addTruckByUi(new TruckViewModelBuilder().WithTruckNo("T2").Build());

                    assertComboBoxHasThreeItems(NameConstants.GET_TRUCK_TRUCK_NO_COMBO);
                    assertComboBoxHasThreeItems(NameConstants.ADD_TRIP_TRUCK_NO_COMBO);
                    assertComboBoxHasThreeItems(NameConstants.GET_TRIP_TRUCK_NO_COMBO);
                    assertComboBoxHasThreeItems(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO);
                    assertComboBoxHasThreeItems(NameConstants.GET_MAINTENANCE_TRUCK_NO_COMBO);
                }

                [Test]
                public void WhenDeleteTruck_ThenRemoveTruckFromTruckTableAndStorageFile()
                {
                    TruckViewModel vm1 = new TruckViewModelBuilder().WithTruckNo("T1").Build();
                    TruckViewModel vm2 = new TruckViewModelBuilder().WithTruckNo("T2").Build();

                    truckRepo.Add(vm1.MakeTruck());
                    truckRepo.Add(vm2.MakeTruck());

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRUCK_DATA_GRID);
                    rows.Add(makeDataGridRow(vm1));
                    rows.Add(makeDataGridRow(vm2));

                    form.GetTruck_DataGrid_CellContentClick(new ControlTester(NameConstants.GET_TRUCK_DATA_GRID),
                        new DataGridViewCellEventArgs(deleteColIndex(), firstRowIndex()));

                    Assert.AreEqual(1, rows.Count);
                    Assert.AreEqual("T2", getValueInColumn(rows[0], NameConstants.GET_TRUCK_TRUCK_NO_DATA_GRID));
                    Assert.IsNull(tripRepo.Get(0));
                }

                [Test]
                public void WhenDeleteTruck_ThenUpdateItemsInTruckCheckComboBox()
                {
                    TruckViewModel vm1 = new TruckViewModelBuilder().WithTruckNo("T1").Build();
                    TruckViewModel vm2 = new TruckViewModelBuilder().WithTruckNo("T2").Build();

                    truckRepo.Add(vm1.MakeTruck());
                    truckRepo.Add(vm2.MakeTruck());

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRUCK_DATA_GRID);
                    rows.Add(makeDataGridRow(vm1));
                    rows.Add(makeDataGridRow(vm2));

                    ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);
                    populateCheckComboBox(
                        ccb,
                        new List<CCBoxItem> { new CCBoxItem("T1", 1), new CCBoxItem("T2", 2) });

                    form.GetTruck_DataGrid_CellContentClick(new ControlTester(NameConstants.GET_TRUCK_DATA_GRID),
                        new DataGridViewCellEventArgs(deleteColIndex(), firstRowIndex()));

                    ObjectCollection items = ccb["CcbItems"] as ObjectCollection;

                    Assert.AreEqual(2, items.Count);
                    Assert.AreEqual("All", ((CCBoxItem)items[0]).Name);
                    Assert.AreEqual("T2", ((CCBoxItem)items[1]).Name);
                }

                [Test]
                public void WhenDeleteTruck_ThenUpdateItemsInTruckNoComboBoxes()
                {
                    TruckViewModel vm1 = new TruckViewModelBuilder().WithTruckNo("T1").Build();
                    TruckViewModel vm2 = new TruckViewModelBuilder().WithTruckNo("T2").Build();

                    truckRepo.Add(vm1.MakeTruck());
                    truckRepo.Add(vm2.MakeTruck());

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRUCK_DATA_GRID);
                    rows.Add(makeDataGridRow(vm1));
                    rows.Add(makeDataGridRow(vm2));

                    populateComboBox(NameConstants.ADD_TRIP_TRUCK_NO_COMBO, new List<string> { "T1", "T2" });
                    populateComboBox(NameConstants.GET_TRIP_TRUCK_NO_COMBO, new List<string> { "T1", "T2" });
                    populateComboBox(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO, new List<string> { "T1", "T2" });
                    populateComboBox(NameConstants.GET_MAINTENANCE_TRUCK_NO_COMBO, new List<string> { "T1", "T2" });

                    form.GetTruck_DataGrid_CellContentClick(new ControlTester(NameConstants.GET_TRUCK_DATA_GRID),
                        new DataGridViewCellEventArgs(deleteColIndex(), firstRowIndex()));

                    assertComboBoxHasTwoItems(NameConstants.ADD_TRIP_TRUCK_NO_COMBO);
                    assertComboBoxHasTwoItems(NameConstants.GET_TRIP_TRUCK_NO_COMBO);
                    assertComboBoxHasTwoItems(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO);
                    assertComboBoxHasTwoItems(NameConstants.GET_MAINTENANCE_TRUCK_NO_COMBO);
                }

                private int firstRowIndex()
                {
                    return 0;
                }

                private int deleteColIndex()
                {
                    return 5;
                }

                private string[] makeDataGridRow(TruckViewModel truck)
                {
                    string[] row = {
                        truck.Id,
                        truck.TruckNo,
                        truck.PlateNo,
                        truck.DriverName,
                        truck.Age
                    };

                    return row;
                }

                private void addTruckByUi(TruckViewModel truckVm)
                {
                    clickTab(NameConstants.ADD_TRUCK_TAB);

                    new ModalFormTester().ExpectModal("Notification", closeNotificationMessageBox);


                    new TextBoxTester(NameConstants.ADD_TRUCK_TRUCK_NO).Enter(truckVm.TruckNo);
                    new TextBoxTester(NameConstants.ADD_TRUCK_PLATE_NO).Enter(truckVm.PlateNo);
                    new TextBoxTester(NameConstants.ADD_TRUCK_DRIVER_NAME).Enter(truckVm.DriverName);
                    new TextBoxTester(NameConstants.ADD_TRUCK_TRUCK_AGE).Enter(truckVm.Age);

                    new ButtonTester(NameConstants.ADD_TRUCK_BUTTON).Click();
                }

                private void removeTruckByUi(int rowIndex)
                {
                    clickTab(NameConstants.GET_TRUCK_TAB);

                    form.GetTruck_DataGrid_CellContentClick(new ControlTester(NameConstants.GET_TRUCK_DATA_GRID),
                        new DataGridViewCellEventArgs(deleteColIndex(), rowIndex));
                }

                private void assertEqualTruck(Truck actual, Truck expected)
                {
                    Assert.AreEqual(expected.TruckNo, actual.TruckNo);
                    Assert.AreEqual(expected.PlateNo, actual.PlateNo);
                    Assert.AreEqual(expected.DriverName, actual.DriverName);
                    Assert.AreEqual(expected.Age, actual.Age);
                }

                private void assertComboBoxHasTwoItems(string comboBoxName)
                {
                    Assert.AreEqual(2, getComboBoxItems(comboBoxName).Count);
                    Assert.AreEqual("All", getComboBoxItems(comboBoxName)[0].ToString());
                    Assert.AreEqual("T2", getComboBoxItems(comboBoxName)[1].ToString());
                }
            }

            [TestFixture]
            public class TripOperationsTests : FormOperationsTests
            {
                [Test]
                public void WhenAddTripButtonClick_ThenCollectAndStoreTripDataFromTextBoxes()
                {
                    new ModalFormTester().ExpectModal("Notification", closeNotificationMessageBox);
                    TripViewModel trip = new TripViewModelDataBuilder().Build();
                    populateComboBox(NameConstants.ADD_TRIP_TRUCK_NO_COMBO, new List<string> { trip.TruckNo });

                    clickTab(NameConstants.ADD_TRIP_TAB);


                    new ControlTester(NameConstants.ADD_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = trip.TruckNo;
                    new TextBoxTester(NameConstants.ADD_TRIP_DATE).Enter(trip.Date);
                    new TextBoxTester(NameConstants.ADD_TRIP_SOURCE).Enter(trip.Source);
                    new TextBoxTester(NameConstants.ADD_TRIP_DESTINATION).Enter(trip.Destination);
                    new TextBoxTester(NameConstants.ADD_TRIP_CLIENT).Enter(trip.Client);
                    new TextBoxTester(NameConstants.ADD_TRIP_DIRECT_COST).Enter(trip.DirectCost);
                    new TextBoxTester(NameConstants.ADD_TRIP_RATE).Enter(trip.Rate);

                    ButtonTester addButton = new ButtonTester(NameConstants.ADD_TRIP_BUTTON);
                    addButton.Click();

                    assertEqualTrips(trip.MakeTrip(), (Trip)tripRepo.Get(0));
                }

                [Test]
                public void WhenAddTripButtonClicked_ThenClearTextBoxes()
                {
                    new ModalFormTester().ExpectModal("Notification", closeNotificationMessageBox);
                    TripViewModel trip = new TripViewModelDataBuilder().Build();
                    populateComboBox(NameConstants.ADD_TRIP_TRUCK_NO_COMBO, new List<string> { trip.TruckNo });
                    clickTab(NameConstants.ADD_TRIP_TAB);

                    new ControlTester(NameConstants.ADD_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = trip.TruckNo;
                    new TextBoxTester(NameConstants.ADD_TRIP_DATE).Enter(trip.Date);
                    new TextBoxTester(NameConstants.ADD_TRIP_SOURCE).Enter(trip.Source);
                    new TextBoxTester(NameConstants.ADD_TRIP_DESTINATION).Enter(trip.Destination);
                    new TextBoxTester(NameConstants.ADD_TRIP_CLIENT).Enter(trip.Client);
                    new TextBoxTester(NameConstants.ADD_TRIP_DIRECT_COST).Enter(trip.DirectCost);
                    new TextBoxTester(NameConstants.ADD_TRIP_RATE).Enter(trip.Rate);

                    ButtonTester addButton = new ButtonTester(NameConstants.ADD_TRIP_BUTTON);
                    addButton.Click();

                    assertEmptyTripTxtBoxes();
                }

                [Test]
                public void GivenNoTrips_WhenFilterButtonIsClicked_ThenTripTableShouldRemainEmpty()
                {
                    clickTab(NameConstants.GET_TRIP_TAB);
                    new ControlTester(NameConstants.GET_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = "All";

                    new ButtonTester(NameConstants.GET_TRIP_FILTER_BUTTON).Click();

                    Assert.AreEqual(0, getTableRows(NameConstants.GET_TRIP_DATA_GRID).Count);
                }

                [Test]
                public void GivenAllTruckNo_WhenFilterButtonClicked_ThenPopulateTripTableWithAllTrips()
                {
                    tripRepo.Add(new TripViewModelDataBuilder().WithTruckNo("T1").Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder().WithTruckNo("T2").Build().MakeTrip());
                    clickTab(NameConstants.GET_TRIP_TAB);
                    new ControlTester(NameConstants.GET_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = "All";

                    new ButtonTester(NameConstants.GET_TRIP_FILTER_BUTTON).Click();

                    Assert.AreEqual(2, getTableRows(NameConstants.GET_TRIP_DATA_GRID).Count);
                }

                [Test]
                public void GivenATruckNoInComboBox_WhenFilterButtonClicked_ThenFilterTripTableByChosenTruckNo()
                {
                    populateComboBox(NameConstants.GET_TRIP_TRUCK_NO_COMBO, new List<string> { "T1", "T2" });
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1").Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2").Build().MakeTrip());

                    clickTab(NameConstants.GET_TRIP_TAB);
                    new ControlTester(NameConstants.GET_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = "T1";

                    new ButtonTester(NameConstants.GET_TRIP_FILTER_BUTTON).Click();

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRIP_DATA_GRID);
                    Assert.AreEqual(1, rows.Count);
                    Assert.AreEqual("T1", getValueInColumn(rows[0], NameConstants.GET_TRIP_TRUCK_NO_DATA_GRID));
                }

                [Test]
                public void GivenAllTruckNoAndOneClient_WhenFilterButtonClicked_ThenFilterTripByChosenClient()
                {
                    populateComboBox(NameConstants.GET_TRIP_TRUCK_NO_COMBO, new List<string> { "All", "T1", "T2" });
                    populateComboBox(NameConstants.GET_TRIP_CLIENT_COMBO, new List<string> { "Jollibee" });
                    clickTab(NameConstants.ADD_TRIP_TAB);
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("McDo")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());

                    clickTab(NameConstants.GET_TRIP_TAB);

                    new ControlTester(NameConstants.GET_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = "All";
                    new ControlTester(NameConstants.GET_TRIP_CLIENT_COMBO)["SelectedItem"] = "Jollibee";

                    new ButtonTester(NameConstants.GET_TRIP_FILTER_BUTTON).Click();

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRIP_DATA_GRID);
                    Assert.AreEqual(2, rows.Count);
                    Assert.AreEqual("T1", getValueInColumn(rows[0], NameConstants.GET_TRIP_TRUCK_NO_DATA_GRID));
                    Assert.AreEqual("Jollibee", getValueInColumn(rows[0], NameConstants.GET_TRIP_CLIENT_DATA_GRID));
                    Assert.AreEqual("T2", getValueInColumn(rows[1], NameConstants.GET_TRIP_TRUCK_NO_DATA_GRID));
                    Assert.AreEqual("Jollibee", getValueInColumn(rows[1], NameConstants.GET_TRIP_CLIENT_DATA_GRID));
                }

                [Test]
                public void GivenAllTruckNoAndAllClient_WhenFilterButtonClicked_ThenDoNotFilterByTruckNoAndClient()
                {
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("McDo")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());

                    clickTab(NameConstants.GET_TRIP_TAB);

                    new ControlTester(NameConstants.GET_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = "All";
                    new ControlTester(NameConstants.GET_TRIP_CLIENT_COMBO)["SelectedItem"] = "All";

                    new ButtonTester(NameConstants.GET_TRIP_FILTER_BUTTON).Click();

                    Assert.AreEqual(3, getTableRows(NameConstants.GET_TRIP_DATA_GRID).Count);
                }

                [Test]
                public void GivenOneTruckNoAndAllClient_WhenFilterButtonClicked_ThenFilterTripsByTruckNoOnly()
                {
                    populateComboBox(NameConstants.GET_TRIP_TRUCK_NO_COMBO, new List<string> { "All", "T1", "T2" });
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("McDo")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());

                    clickTab(NameConstants.GET_TRIP_TAB);

                    new ControlTester(NameConstants.GET_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = "T1";
                    new ControlTester(NameConstants.GET_TRIP_CLIENT_COMBO)["SelectedItem"] = "All";

                    new ButtonTester(NameConstants.GET_TRIP_FILTER_BUTTON).Click();

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRIP_DATA_GRID);
                    Assert.AreEqual(2, rows.Count);
                    Assert.AreEqual("T1", getValueInColumn(rows[0], NameConstants.GET_TRIP_TRUCK_NO_DATA_GRID));
                    Assert.AreEqual("T1", getValueInColumn(rows[1], NameConstants.GET_TRIP_TRUCK_NO_DATA_GRID));
                }

                [Test]
                public void GivenOneTruckNoAndOneClient_WhenFilterButtonClicked_ThenFilterTripsByTruckNoAndClient()
                {
                    populateComboBox(NameConstants.GET_TRIP_TRUCK_NO_COMBO, new List<string> { "All", "T1", "T2" });
                    populateComboBox(NameConstants.GET_TRIP_CLIENT_COMBO, new List<string> { "McDo" });
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithClient("McDo")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2")
                        .WithClient("Jollibee")
                        .Build().MakeTrip());

                    clickTab(NameConstants.GET_TRIP_TAB);

                    new ControlTester(NameConstants.GET_TRIP_TRUCK_NO_COMBO)["SelectedItem"] = "T1";
                    new ControlTester(NameConstants.GET_TRIP_CLIENT_COMBO)["SelectedItem"] = "McDo";

                    new ButtonTester(NameConstants.GET_TRIP_FILTER_BUTTON).Click();

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRIP_DATA_GRID);
                    Assert.AreEqual(1, rows.Count);
                    Assert.AreEqual("T1", getValueInColumn(rows[0], NameConstants.GET_TRIP_TRUCK_NO_DATA_GRID));
                    Assert.AreEqual("McDo", getValueInColumn(rows[0], NameConstants.GET_TRIP_CLIENT_DATA_GRID));
                }

                [Test]
                public void WhenDeleteTripButtonClicked_ThenDeleteTripDataFromStorageFileAndRemovedFromTripTable()
                {
                    TripViewModel vm1 = new TripViewModelDataBuilder().WithId(0).WithTruckNo("T1").Build();
                    TripViewModel vm2 = new TripViewModelDataBuilder().WithId(1).WithTruckNo("T2").Build();

                    tripRepo.Add(vm1.MakeTrip());
                    tripRepo.Add(vm2.MakeTrip());

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_TRIP_DATA_GRID);
                    rows.Add(makeDataGridRow(vm1));
                    rows.Add(makeDataGridRow(vm2));

                    form.GetTrip_DataGrid_CellContentClick(new ControlTester(NameConstants.GET_TRIP_DATA_GRID),
                        new DataGridViewCellEventArgs(deleteColIndex(), firstRowIndex()));

                    Assert.AreEqual(1, rows.Count);
                    Assert.AreEqual("T2", getValueInColumn(rows[0], NameConstants.GET_TRIP_TRUCK_NO_DATA_GRID));
                    Assert.IsNull(tripRepo.Get(0));
                }

                private int deleteColIndex()
                {
                    return 8;
                }

                private int firstRowIndex()
                {
                    return 0;
                }

                private string[] makeDataGridRow(TripViewModel trip)
                {
                    string[] tripRow = {
                        trip.Id,
                        trip.TruckNo,
                        trip.Date,
                        trip.Client,
                        trip.Source,
                        trip.Destination,
                        trip.DirectCost,
                        trip.Rate
                    };

                    return tripRow;
                }

                private void assertEmptyTripTxtBoxes()
                {
                    Assert.IsEmpty(new ControlTester(NameConstants.ADD_TRIP_TRUCK_NO_COMBO)["Text"].ToString());
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_TRIP_DATE).Text);
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_TRIP_SOURCE).Text);
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_TRIP_DESTINATION).Text);
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_TRIP_CLIENT).Text);
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_TRIP_DIRECT_COST).Text);
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_TRIP_RATE).Text);
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

            [TestFixture]
            public class MaintenanceOperationsTests : FormOperationsTests
            {
                [Test]
                public void WhenAddMaintenanceButtonClicked_ThenAddMaintenanceToStorageFile()
                {
                    MaintenanceViewModel maintenance = new MaintenanceViewModelBuilder().Build();
                    populateComboBox(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO, new List<string> { maintenance.TruckNo });

                    clickTab(NameConstants.ADD_MAINTENANCE_TAB);

                    new ModalFormTester().ExpectModal("Notification", closeNotificationMessageBox);


                    new ControlTester(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO)["SelectedItem"] = maintenance.TruckNo;
                    new TextBoxTester(NameConstants.ADD_MAINTENANCE_DATE).Enter(maintenance.Date);
                    new TextBoxTester(NameConstants.ADD_MAINTENANCE_TYPE).Enter(maintenance.Type);
                    new TextBoxTester(NameConstants.ADD_MAINTENANCE_COST).Enter(maintenance.Cost);

                    new ButtonTester(NameConstants.ADD_MAINTENANCE_BUTTON).Click();

                    assertEqualMaintenance((Maintenance)maintRepo.Get(0), maintenance.MakeMaintenance());
                }

                [Test]
                public void WhenAddMaintenanceButtonClicked_ThenClearAllTxtBoxes()
                {
                    clickTab(NameConstants.ADD_MAINTENANCE_TAB);

                    new ModalFormTester().ExpectModal("Notification", closeNotificationMessageBox);

                    MaintenanceViewModel maintenance = new MaintenanceViewModelBuilder().Build();

                    new ControlTester(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO)["SelectedItem"] = maintenance.TruckNo;
                    new TextBoxTester(NameConstants.ADD_MAINTENANCE_DATE).Enter(maintenance.Date);
                    new TextBoxTester(NameConstants.ADD_MAINTENANCE_TYPE).Enter(maintenance.Type);
                    new TextBoxTester(NameConstants.ADD_MAINTENANCE_COST).Enter(maintenance.Cost);

                    new ButtonTester(NameConstants.ADD_MAINTENANCE_BUTTON).Click();

                    assertEmptyMaintenanceTxtBoxes();
                }

                [Test]
                public void GivenAllTruckNo_WhenFilterButtonClicked_ThenPopulateTripTableWithAllTrips()
                {
                    maintRepo.Add(new MaintenanceViewModelBuilder()
                        .WithTruckNo("T1")
                        .Build()
                        .MakeMaintenance());
                    maintRepo.Add(new MaintenanceViewModelBuilder()
                        .WithTruckNo("T2")
                        .Build()
                        .MakeMaintenance());

                    clickTab(NameConstants.GET_MAINTENANCE_TAB);

                    new ControlTester(NameConstants.GET_MAINTENANCE_TRUCK_NO_COMBO)["SelectedItem"] = "All";

                    new ButtonTester(NameConstants.GET_MAINTENANCE_FILTER_BUTTON).Click();

                    Assert.AreEqual(2, getTableRows(NameConstants.GET_MAINTENANCE_DATA_GRID).Count);
                }

                [Test]
                public void GivenATruckNoInComboBox_WhenFilterButtonClicked_ThenFilterMaintenanceTableByChosenTruckNo()
                {
                    populateComboBox(NameConstants.GET_MAINTENANCE_TRUCK_NO_COMBO, new List<string> { "T1" });
                    maintRepo.Add(new MaintenanceViewModelBuilder()
                        .WithTruckNo("T1")
                        .Build()
                        .MakeMaintenance());
                    maintRepo.Add(new MaintenanceViewModelBuilder()
                        .WithTruckNo("T2")
                        .Build()
                        .MakeMaintenance());

                    clickTab(NameConstants.GET_MAINTENANCE_TAB);

                    new ControlTester(NameConstants.GET_MAINTENANCE_TRUCK_NO_COMBO)["SelectedItem"] = "T1";

                    new ButtonTester(NameConstants.GET_MAINTENANCE_FILTER_BUTTON).Click();

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_MAINTENANCE_DATA_GRID);
                    Assert.AreEqual(1, rows.Count);
                    Assert.AreEqual("T1", getValueInColumn(rows[0], NameConstants.GET_MAINTENANCE_TRUCK_NO_DATA_GRID));
                }

                [Test]
                public void WhenDeleteTripButtonClicked_ThenDeleteMaintenanceDataInStorageFileAndRemoveFromMaintenanceTable()
                {
                    MaintenanceViewModel vm1 = new MaintenanceViewModelBuilder()
                        .WithTruckNo("T1")
                        .Build();
                    MaintenanceViewModel vm2 = new MaintenanceViewModelBuilder()
                        .WithTruckNo("T2")
                        .Build();

                    maintRepo.Add(vm1.MakeMaintenance());
                    maintRepo.Add(vm2.MakeMaintenance());

                    DataGridViewRowCollection rows = getTableRows(NameConstants.GET_MAINTENANCE_DATA_GRID);
                    rows.Add(makeDataGridRow(vm1));
                    rows.Add(makeDataGridRow(vm2));


                    form.GetMaintenance_DataGrid_CellContentClick(new ControlTester(NameConstants.GET_MAINTENANCE_DATA_GRID),
                        new DataGridViewCellEventArgs(deleteColIndex(), firstRowIndex()));

                    Assert.AreEqual(1, getTableRows(NameConstants.GET_MAINTENANCE_DATA_GRID).Count);
                    Assert.AreEqual("T2", getValueInColumn(getTableRows(NameConstants.GET_MAINTENANCE_DATA_GRID)[0], NameConstants.GET_MAINTENANCE_TRUCK_NO_DATA_GRID));
                    Assert.IsNull(maintRepo.Get(0));
                }

                private int deleteColIndex()
                {
                    return 5;
                }

                private int firstRowIndex()
                {
                    return 0;
                }

                private string[] makeDataGridRow(MaintenanceViewModel maintenance)
                {
                    string[] row = {
                        maintenance.Id,
                        maintenance.TruckNo,
                        maintenance.Date,
                        maintenance.Type,
                        maintenance.Cost
                    };

                    return row;
                }

                private void assertEqualMaintenance(Maintenance actual, Maintenance expected)
                {
                    Assert.AreEqual(expected.Id, actual.Id);
                    Assert.AreEqual(expected.TruckNo, actual.TruckNo);
                    Assert.AreEqual(expected.Type, actual.Type);
                    Assert.AreEqual(expected.Cost, actual.Cost);
                }

                private void assertEmptyMaintenanceTxtBoxes()
                {
                    Assert.IsEmpty(new ControlTester(NameConstants.ADD_MAINTENANCE_TRUCK_NO_COMBO)["Text"].ToString());
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_MAINTENANCE_DATE).Text);
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_MAINTENANCE_TYPE).Text);
                    Assert.IsEmpty(new TextBoxTester(NameConstants.ADD_MAINTENANCE_COST).Text);
                }
            }

            [TestFixture]
            public class IncomeStatementTests : FormOperationsTests
            {
                [Test]
                public void WhenAllInCheckComboBoxIsClicked_ThenSelectAllItemsInCheckComboBox()
                {
                    ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);
                    populateCheckComboBox(
                        ccb,
                        new List<CCBoxItem> { new CCBoxItem("T1", 1), new CCBoxItem("T2", 2) });
                    uncheckAllItemsIn(ccb);

                    ccb.Invoke("SetItemChecked", 0, true);

                    CheckedItemCollection checkedItems = ccb["CheckedItems"] as CheckedItemCollection;
                    Assert.AreEqual(3, checkedItems.Count);
                    Assert.AreEqual("All", ((CCBoxItem)checkedItems[0]).Name);
                    Assert.AreEqual("T1", ((CCBoxItem)checkedItems[1]).Name);
                    Assert.AreEqual("T2", ((CCBoxItem)checkedItems[2]).Name);
                }

                [Test]
                public void WhenAllInCheckComboBoxIsUnChecked_ThenDeselectAllItemsInCheckComboBox()
                {
                    ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);
                    populateCheckComboBox(
                        ccb,
                        new List<CCBoxItem> { new CCBoxItem("T1", 1), new CCBoxItem("T2", 2) });

                    ccb.Invoke("SetItemChecked", 0, true);
                    ccb.Invoke("SetItemChecked", 0, false);

                    CheckedItemCollection checkedItems = ccb["CheckedItems"] as CheckedItemCollection;
                    Assert.AreEqual(0, checkedItems.Count);
                }

                [Test]
                public void GivenAllIsCheckedInCheckComboBox_WhenFilterButtonClicked_ThenShowIncomeStatementOfAllTrucks()
                {
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithRate("100")
                        .WithDirectCost("30")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithRate("250")
                        .WithDirectCost("150")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2")
                        .WithRate("80")
                        .WithDirectCost("10")
                        .Build().MakeTrip());
                    maintRepo.Add(new MaintenanceViewModelBuilder()
                        .WithTruckNo("T1")
                        .WithCost("30")
                        .Build()
                        .MakeMaintenance());

                    ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);
                    uncheckAllItemsIn(ccb);

                    populateCheckComboBox(
                        ccb,
                        new List<CCBoxItem> { new CCBoxItem("T1", 1), new CCBoxItem("T2", 2) });

                    checkAllItemsIn(ccb);
                    clickTab(NameConstants.INCOME_STATEMENT_TAB);

                    new ButtonTester(NameConstants.INCOME_STATEMENT_FILTER_BUTTON).Click();

                    CheckedItemCollection checkedItems = ccb["CheckedItems"] as CheckedItemCollection;
                    Assert.AreEqual(3, checkedItems.Count);
                    Assert.AreEqual("430", new TextBoxTester(NameConstants.INCOME_STATEMENT_REVENUE).Text);
                    Assert.AreEqual("190", new TextBoxTester(NameConstants.INCOME_STATEMENT_DIRECT_COST).Text);
                    Assert.AreEqual("240", new TextBoxTester(NameConstants.INCOME_STATEMENT_GROSS_PROFIT).Text);
                    Assert.AreEqual("30", new TextBoxTester(NameConstants.INCOME_STATEMENT_MAINT_FEE).Text);
                    Assert.AreEqual("210", new TextBoxTester(NameConstants.INCOME_STATEMENT_NET_INCOME).Text);
                }

                [Test]
                public void GivenNoneIsCheckedInCheckComboBox_WhenFilterButtonClicked_ThenIncomeStatementFieldsShouldBeZero()
                {
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithRate("100")
                        .WithDirectCost("30")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithRate("250")
                        .WithDirectCost("150")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2")
                        .WithRate("80")
                        .WithDirectCost("10")
                        .Build().MakeTrip());
                    maintRepo.Add(new MaintenanceViewModelBuilder()
                        .WithTruckNo("T1")
                        .WithCost("30")
                        .Build()
                        .MakeMaintenance());

                    ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);
                    uncheckAllItemsIn(ccb);

                    populateCheckComboBox(
                        ccb,
                        new List<CCBoxItem> { new CCBoxItem("T1", 1), new CCBoxItem("T2", 2) });

                    uncheckAllItemsIn(ccb);
                    clickTab(NameConstants.INCOME_STATEMENT_TAB);

                    new ButtonTester(NameConstants.INCOME_STATEMENT_FILTER_BUTTON).Click();

                    CheckedItemCollection checkedItems = ccb["CheckedItems"] as CheckedItemCollection;
                    Assert.AreEqual(0, checkedItems.Count);
                    Assert.AreEqual("0", new TextBoxTester(NameConstants.INCOME_STATEMENT_REVENUE).Text);
                    Assert.AreEqual("0", new TextBoxTester(NameConstants.INCOME_STATEMENT_DIRECT_COST).Text);
                    Assert.AreEqual("0", new TextBoxTester(NameConstants.INCOME_STATEMENT_GROSS_PROFIT).Text);
                    Assert.AreEqual("0", new TextBoxTester(NameConstants.INCOME_STATEMENT_MAINT_FEE).Text);
                    Assert.AreEqual("0", new TextBoxTester(NameConstants.INCOME_STATEMENT_NET_INCOME).Text);
                }

                [Test]
                public void GivenCheckedItemsInCheckComboBox_WhenFilterButtonClicked_ThenShowIncomeStatementOfCheckedItemsOnly()
                {
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithRate("100")
                        .WithDirectCost("30")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T1")
                        .WithRate("250")
                        .WithDirectCost("150")
                        .Build().MakeTrip());
                    tripRepo.Add(new TripViewModelDataBuilder()
                        .WithTruckNo("T2")
                        .WithRate("80")
                        .WithDirectCost("10")
                        .Build().MakeTrip());
                    maintRepo.Add(new MaintenanceViewModelBuilder()
                        .WithTruckNo("T1")
                        .WithCost("30")
                        .Build()
                        .MakeMaintenance());

                    ControlTester ccb = new ControlTester(NameConstants.INCOME_STATEMENT_TRUCK_NO_CCBOX);
                    uncheckAllItemsIn(ccb);

                    populateCheckComboBox(
                        ccb,
                        new List<CCBoxItem> { new CCBoxItem("T1", 1), new CCBoxItem("T2", 2) });

                    ccb.Invoke("SetItemChecked", 1, true);
                    clickTab(NameConstants.INCOME_STATEMENT_TAB);

                    new ButtonTester(NameConstants.INCOME_STATEMENT_FILTER_BUTTON).Click();

                    CheckedItemCollection checkedItems = ccb["CheckedItems"] as CheckedItemCollection;
                    Assert.AreEqual(1, checkedItems.Count);
                    Assert.AreEqual("350", new TextBoxTester(NameConstants.INCOME_STATEMENT_REVENUE).Text);
                    Assert.AreEqual("180", new TextBoxTester(NameConstants.INCOME_STATEMENT_DIRECT_COST).Text);
                    Assert.AreEqual("170", new TextBoxTester(NameConstants.INCOME_STATEMENT_GROSS_PROFIT).Text);
                    Assert.AreEqual("30", new TextBoxTester(NameConstants.INCOME_STATEMENT_MAINT_FEE).Text);
                    Assert.AreEqual("140", new TextBoxTester(NameConstants.INCOME_STATEMENT_NET_INCOME).Text);
                }

                private void uncheckAllItemsIn(ControlTester ccb)
                {
                    ccb.Invoke("SetItemChecked", 0, false);
                }

                private void checkAllItemsIn(ControlTester ccb)
                {
                    ccb.Invoke("SetItemChecked", 0, true);
                }
            }
        }

        private void setUpTruckRepository()
        {
            truckRepo = new TruckRepository(TRUCK_STORAGE_FILE);
            FileHelper.CreateFile(TRUCK_STORAGE_FILE, string.Empty);
        }

        private void setUpMaintenanceRepository()
        {
            maintRepo = new MaintenanceRepository(MAINTENANCE_STORAGE_FILE);
            FileHelper.CreateFile(MAINTENANCE_STORAGE_FILE, string.Empty);
        }

        private void setUpTripRepository()
        {
            tripRepo = new TripRepository(TRIP_STORAGE_FILE);
            FileHelper.CreateFile(TRIP_STORAGE_FILE, string.Empty);
        }

        private void populateComboBox(string comboBox, List<string> itemsToAdd)
        {
            ControlTester addTripTruckNoComboBox = new ControlTester(comboBox);
            ComboBox.ObjectCollection items = addTripTruckNoComboBox["Items"] as ComboBox.ObjectCollection;

            for (int i = 0; i < itemsToAdd.Count; i++)
                items.Add(itemsToAdd[i]);
        }

        private void populateCheckComboBox(ControlTester ccb, List<CCBoxItem> itemsToAdd)
        {
            ObjectCollection items = ccb["CcbItems"] as ObjectCollection;

            for (int i = 0; i < itemsToAdd.Count; i++)
                items.Add(itemsToAdd[i]);
        }

        private void clickTab(string tabName)
        {
            ControlTester tabControl = new ControlTester(NameConstants.TRUCKER_TAB);
            tabControl.Invoke("SelectTab", tabName);
        }

        private DataGridViewRowCollection getTableRows(string tableName)
        {
            ControlTester tripDataGrid = new ControlTester(tableName);
            return ((DataGridViewRowCollection)tripDataGrid["Rows"]);
        }

        private string getValueInColumn(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value.ToString();
        }

        public void closeNotificationMessageBox()
        {
            MessageBoxTester messageBox = new MessageBoxTester("Notification");
            messageBox.ClickOk();
        }

        private void assertComboBoxHasThreeItems(string comboBoxName)
        {
            Assert.AreEqual(3, getComboBoxItems(comboBoxName).Count);
            Assert.AreEqual("All", getComboBoxItems(comboBoxName)[0].ToString());
            Assert.AreEqual("T1", getComboBoxItems(comboBoxName)[1].ToString());
            Assert.AreEqual("T2", getComboBoxItems(comboBoxName)[2].ToString());
        }

        private ComboBox.ObjectCollection getComboBoxItems(string comboBoxName)
        {
            ControlTester comboBox = new ControlTester(comboBoxName);
            ComboBox.ObjectCollection items = comboBox["Items"] as ComboBox.ObjectCollection;
            return items;
        }
    }
}
