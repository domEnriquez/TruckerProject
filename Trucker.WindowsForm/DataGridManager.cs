using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Trucker.WindowsForm
{
    public abstract class DataGridManager
    {
        protected DataGridView dataGrid;

        public DataGridManager(DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;
        }

        public void PopulateDataGrid(IEnumerable<ViewModel> viewModels)
        {
            dataGrid.Rows.Clear();

            for (int i = 0; i < viewModels.Count(); i++)
                dataGrid.Rows.Add(MakeDataGridRow(viewModels.ElementAt(i)));
        }

        public void RemoveRow(int rowIndex)
        {
            dataGrid.Rows.RemoveAt(rowIndex);
        }

        public int GetEntityIdFromGrid(int rowIndex, string colName)
        {
            return Convert.ToInt32(dataGrid.Rows[rowIndex].Cells[colName].Value.ToString());
        }

        public string GetColName(int colIndex)
        {
            return dataGrid.Columns[colIndex].Name;
        }

        protected abstract string[] MakeDataGridRow(ViewModel viewModel);
    }
}
