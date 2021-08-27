using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace Trucker.WindowsForm
{
    public partial class Form1 : Form
    {
        private TripRepository tripRepo;
        private MaintenanceRepository maintRepo;
        private TruckRepository truckRepo;
        private TripDataGridManager tripDataGridManager;
        private MaintenanceDataGridManager maintDataGridManager;
        private TruckDataGridManager truckDataGridManager;

        public Form1(TripRepository tripRepo, MaintenanceRepository maintRepo, TruckRepository truckRepo)
        {
            InitializeComponent();
            this.tripRepo = tripRepo;
            this.maintRepo = maintRepo;
            this.truckRepo = truckRepo;
            tripDataGridManager = new TripDataGridManager(getTrip_dataGrid);
            maintDataGridManager = new MaintenanceDataGridManager(getMaintenance_dataGrid);
            truckDataGridManager = new TruckDataGridManager(getTruck_dataGrid);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateTruckNoComboBoxes();
            populateComboBox(getTrip_clientComboBox, tripRepo.GetAll().OfType<Trip>().Select(t => t.Client));
            populateDataGrid(truckDataGridManager, truckRepo.GetAll().OfType<Truck>());
            populateDataGrid(tripDataGridManager, tripRepo.GetAll().OfType<Trip>());
            populateDataGrid(maintDataGridManager, maintRepo.GetAll().OfType<Maintenance>());
            setUpIncomeStatementPage();
        }

        private void populateDataGrid(DataGridManager dataGridManager, IEnumerable<Entity> entities)
        {
            dataGridManager.PopulateDataGrid(makeViewModelsFrom(entities));
        }

        private void setUpIncomeStatementPage()
        {
            incomeStatement_checkedComboBox.SetItemChecked(0, true);

            IncomeStatement statement =
                new IncomeStatement(tripRepo.GetAll().OfType<Trip>(), maintRepo.GetAll().OfType<Maintenance>());

            incomeStatement_revenueTxtBox.Text = statement.CalculateRevenue().ToString();
            incomeStatement_netIncomeTxtBox.Text = statement.CalculateNetIncome().ToString();
            incomeStatement_grossProfitTxtBox.Text = statement.CalculateGrossProfit().ToString();
            incomeStatement_maintFeeTxtBox.Text = statement.CalculateTotalMaintenanceCost().ToString();
            incomeStatement_directCostTxtBox.Text = statement.CalculateDirectCost().ToString();
        }

        private void populateCheckedComboBox(CheckedComboBox checkedComboBox, IEnumerable<string> items)
        {
            checkedComboBox.Items.Clear();
            checkedComboBox.Items.Add(new CCBoxItem("All", 0));

            for (int i = 0; i < items.Count(); i++)
            {
                CCBoxItem item = new CCBoxItem(items.ElementAt(i), i+1);
                checkedComboBox.Items.Add(item);
            }
        }

        private void addTrip_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                TripViewModel tripViewModel = new TripViewModel
                {
                    TruckNo = addTrip_tuckNoComboBox.SelectedItem.ToString(),
                    Date = addTrip_dateTxtBox.Text,
                    Source = addTrip_sourceTxtBox.Text,
                    Destination = addTrip_destTxtBox.Text,
                    Client = addTrip_clientTxtBox.Text,
                    DirectCost = addTrip_directCostTxtBox.Text,
                    Rate = addTrip_rateTxtBox.Text
                };

                tripRepo.Add(tripViewModel.MakeTrip());

                MessageBox.Show("Trip added", "Notification");

                clearTripTextBoxes();
                populateComboBox(getTrip_clientComboBox, tripRepo.GetAll().OfType<Trip>().Select(t => t.Client));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }

        private void clearTripTextBoxes()
        {
            addTrip_tuckNoComboBox.SelectedItem = null;
            addTrip_dateTxtBox.Clear();
            addTrip_sourceTxtBox.Clear();
            addTrip_destTxtBox.Clear();
            addTrip_clientTxtBox.Clear();
            addTrip_directCostTxtBox.Clear();
            addTrip_rateTxtBox.Clear();
        }

        private IEnumerable<string> getAllTruckNos()
        {
            return truckRepo
                .GetAll()
                .OfType<Truck>()
                .Select(t => t.TruckNo);
        }

        private void getTrip_filterButtonClicked(object sender, EventArgs e)
        {
            tripDataGridManager.PopulateDataGrid(makeViewModelsFrom(filterTrips()));
        }

        public void GetTrip_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tripDataGridManager.GetColName(e.ColumnIndex) == NameConstants.GET_TRIP_DELETE_DATA_GRID)
            {
                tripRepo.Delete(
                    tripDataGridManager.GetEntityIdFromGrid(e.RowIndex, NameConstants.GET_TRIP_TRIP_ID_DATA_GRID)
                );
                tripDataGridManager.RemoveRow(e.RowIndex);
            }
        }

        public void GetMaintenance_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maintDataGridManager.GetColName(e.ColumnIndex) == NameConstants.GET_MAINTENANCE_DELETE_DATA_GRID)
            {
                maintRepo.Delete(
                    maintDataGridManager.GetEntityIdFromGrid(e.RowIndex, NameConstants.GET_MAINTENANCE_MAINTENANCE_ID_DATA_GRID)
                );

                maintDataGridManager.RemoveRow(e.RowIndex);
            }
        }

        public void GetTruck_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (truckDataGridManager.GetColName(e.ColumnIndex) == NameConstants.GET_TRUCK_DELETE_DATA_GRID)
            {
                truckRepo.Delete(
                    truckDataGridManager.GetEntityIdFromGrid(e.RowIndex, NameConstants.GET_TRUCK_TRUCK_ID_DATA_GRID)
                );

                truckDataGridManager.RemoveRow(e.RowIndex);
                populateTruckNoComboBoxes();
            }
        }

        private void addMaintenance_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                MaintenanceViewModel maintViewModel = new MaintenanceViewModel
                {
                    TruckNo = addMaintenance_truckNoComboBox.SelectedItem.ToString(),
                    Date = addMaintenance_dateTxtBox.Text,
                    Type = addMaintenance_typeTxtBox.Text,
                    Cost = addMaintenance_costTxtBox.Text
                };

                maintRepo.Add(maintViewModel.MakeMaintenance());

                MessageBox.Show("Maintenance added", "Notification");

                clearMaintenanceTxtBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }

        private void clearMaintenanceTxtBoxes()
        {
            addMaintenance_truckNoComboBox.SelectedItem = null;
            addMaintenance_dateTxtBox.Clear();
            addMaintenance_typeTxtBox.Clear();
            addMaintenance_costTxtBox.Clear();
        }

        private void getMaintenance_FilterButtonClick(object sender, EventArgs e)
        {
            string truckNo = getMaintenance_truckNoComboBox.SelectedItem.ToString();

            maintDataGridManager.PopulateDataGrid(
                makeViewModelsFrom(
                    filterMaintenanceByTruckNo(maintRepo.GetAll().OfType<Maintenance>(), truckNo)));
        }

        public IEnumerable<ViewModel> makeViewModelsFrom(IEnumerable<Entity> entities)
        {
            List<ViewModel> viewModels = new List<ViewModel>();

            for (int i = 0; i < entities.Count(); i++)
                viewModels.Add(convertToViewModel(entities.ElementAt(i)));

            return viewModels;
        }

        private ViewModel convertToViewModel(Entity entity)
        {
            if (entity is Trip)
                return new TripViewModel((Trip)entity);
            else if (entity is Maintenance)
                return new MaintenanceViewModel((Maintenance)entity);
            else
                return new TruckViewModel((Truck)entity);
        }

        private void incomeStatement_FilterButtonClick(object sender, EventArgs e)
        {
            CheckedItemCollection checkedItems = incomeStatement_checkedComboBox.CheckedItems;

            List<string> truckNos = new List<string>();

            for(int i = 0; i < checkedItems.Count; i++)
            {
                CCBoxItem item = checkedItems[i] as CCBoxItem;
                truckNos.Add(item.Name);
            }

            IncomeStatement statement =
                new IncomeStatement(
                    filterTripsByTruckNos(tripRepo.GetAll().OfType<Trip>(), truckNos),
                    filterMaintenanceByTruckNos(maintRepo.GetAll().OfType<Maintenance>(), truckNos));

            incomeStatement_revenueTxtBox.Text = statement.CalculateRevenue().ToString();
            incomeStatement_directCostTxtBox.Text = statement.CalculateDirectCost().ToString();
            incomeStatement_grossProfitTxtBox.Text = statement.CalculateGrossProfit().ToString();
            incomeStatement_maintFeeTxtBox.Text = statement.CalculateTotalMaintenanceCost().ToString();
            incomeStatement_netIncomeTxtBox.Text = statement.CalculateNetIncome().ToString();
        }

        private IEnumerable<Trip> filterTrips()
        {
            IEnumerable<Trip> trips = filterTripsByTruckNo(tripRepo.GetAll().OfType<Trip>(), getTrip_truckNoComboBox.SelectedItem.ToString());
            trips = filterTripsByClient(trips, getTrip_clientComboBox.SelectedItem.ToString());

            return trips;
        }

        private IEnumerable<Trip> filterTripsByTruckNo(IEnumerable<Trip> trips, string truckNo)
        {
            if (truckNo != "All")
                trips = trips.Where(t => t.TruckNo == truckNo).ToList();

            return trips;
        }

        private IEnumerable<Trip> filterTripsByTruckNos(IEnumerable<Trip> trips, IEnumerable<string> truckNos)
        {
            List<Trip> listTrips = new List<Trip>();

            for (int i = 0; i < truckNos.Count(); i++)
                listTrips.AddRange(trips.Where(t => t.TruckNo == truckNos.ElementAt(i)));

            return listTrips;
        }

        private static IEnumerable<Trip> filterTripsByClient(IEnumerable<Trip> trips, string selectedClient)
        {
            if (selectedClient != "All")
                trips = trips.Where(t => t.Client == selectedClient).ToList();

            return trips;
        }

        private IEnumerable<Maintenance> filterMaintenanceByTruckNo(IEnumerable<Maintenance> maintenances, string truckNo)
        {
            if (truckNo != "All")
                maintenances = maintenances.Where(t => t.TruckNo == truckNo).ToList();

            return maintenances;
        }

        private IEnumerable<Truck> filterTrucksByTruckNo(IEnumerable<Truck> trucks, string truckNo)
        {
            if (truckNo != "All")
                trucks = trucks.Where(t => t.TruckNo == truckNo).ToList();

            return trucks;
        }

        private IEnumerable<Maintenance> filterMaintenanceByTruckNos(IEnumerable<Maintenance> maintenances, IEnumerable<string> truckNos)
        {
            List<Maintenance> listMaints = new List<Maintenance>();

            for (int i = 0; i < truckNos.Count(); i++)
                listMaints.AddRange(maintenances.Where(m => m.TruckNo == truckNos.ElementAt(i)));

            return listMaints;
        }

        private void addTruck_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                TruckViewModel viewModel = new TruckViewModel
                {
                    TruckNo = addTruck_truckNoTxtBox.Text,
                    PlateNo = addTruck_plateNoTxtBox.Text,
                    DriverName = addTruck_driverNameTxtBox.Text,
                    Age = addTruck_truckAgeTxtBox.Text
                };

                truckRepo.Add(viewModel.MakeTruck());

                MessageBox.Show("Truck Added", "Notification");

                clearTruckTextBoxes();
                populateTruckNoComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }

        private void checkComboBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CCBoxItem item = incomeStatement_checkedComboBox.Items[e.Index] as CCBoxItem;

            if (item == null)
                return;

            if (item.Name == "All")
            {
                if(!incomeStatement_checkedComboBox.GetItemChecked(e.Index))
                    for(int i = 1; i < incomeStatement_checkedComboBox.Items.Count; i++)
                        incomeStatement_checkedComboBox.SetItemChecked(i, true);
                else
                    for (int i = 1; i < incomeStatement_checkedComboBox.Items.Count; i++)
                        incomeStatement_checkedComboBox.SetItemChecked(i, false);
            }

        }

        private void populateTruckNoComboBoxes()
        {
            populateComboBox(getTruck_truckNoComboBox, getAllTruckNos());
            populateComboBox(addTrip_tuckNoComboBox, getAllTruckNos());
            populateComboBox(addMaintenance_truckNoComboBox, getAllTruckNos());
            populateComboBox(getTrip_truckNoComboBox, getAllTruckNos());
            populateCheckedComboBox(incomeStatement_checkedComboBox, getAllTruckNos());
            populateComboBox(getMaintenance_truckNoComboBox, getAllTruckNos());
        }

        public void populateComboBox(ComboBox comboBox, IEnumerable<string> items)
        {
            comboBox.BeginUpdate();

            comboBox.Items.Clear();
            comboBox.Items.Add("All");

            for (int i = 0; i < items.Count(); i++)
            {
                if (!comboBox.Items.Contains(items.ElementAt(i)))
                    comboBox.Items.Add(items.ElementAt(i));
            }

            comboBox.Text = "All";
            comboBox.EndUpdate();
        }

        private void clearTruckTextBoxes()
        {
            addTruck_truckNoTxtBox.Clear();
            addTruck_plateNoTxtBox.Clear();
            addTruck_driverNameTxtBox.Clear();
            addTruck_truckAgeTxtBox.Clear();
        }

        private void getTruck_filterButton_Click(object sender, EventArgs e)
        {
            string truckNo = getTruck_truckNoComboBox.SelectedItem.ToString();

            truckDataGridManager.PopulateDataGrid(
                makeViewModelsFrom(
                    filterTrucksByTruckNo(truckRepo.GetAll().OfType<Truck>(), truckNo)));
        }
    }
}
