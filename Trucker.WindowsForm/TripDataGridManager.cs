using System.Windows.Forms;

namespace Trucker.WindowsForm
{
    public class TripDataGridManager : DataGridManager
    {
        public TripDataGridManager(DataGridView dataGrid) 
            : base(dataGrid)
        {

        }
        protected override string[] MakeDataGridRow(ViewModel viewModel)
        {
            TripViewModel trip = (TripViewModel)viewModel;

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
    }
}
