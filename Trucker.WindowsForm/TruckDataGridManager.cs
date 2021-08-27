using System.Windows.Forms;

namespace Trucker.WindowsForm
{
    public class TruckDataGridManager : DataGridManager
    {
        public TruckDataGridManager(DataGridView dataGrid) 
            : base(dataGrid)
        {
        }

        protected override string[] MakeDataGridRow(ViewModel viewModel)
        {
            TruckViewModel truck = (TruckViewModel)viewModel;

            string[] tripRow = {
                truck.Id,
                truck.TruckNo,
                truck.PlateNo,
                truck.DriverName,
                truck.Age
            };

            return tripRow;
        }
    }
}
