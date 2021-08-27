using System.Windows.Forms;

namespace Trucker.WindowsForm
{
    public class MaintenanceDataGridManager : DataGridManager
    {
        public MaintenanceDataGridManager(DataGridView dataGrid)
            : base(dataGrid)
        {

        }

        protected override string[] MakeDataGridRow(ViewModel viewModel)
        {
            MaintenanceViewModel maintenance = (MaintenanceViewModel)viewModel;

            string[] row = {
                maintenance.Id,
                maintenance.TruckNo,
                maintenance.Date,
                maintenance.Type,
                maintenance.Cost
            };

            return row;
        }
    }
}
