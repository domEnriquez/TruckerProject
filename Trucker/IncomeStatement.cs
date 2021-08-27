using System.Collections.Generic;
using System.Linq;

namespace Trucker
{
    public class IncomeStatement
    {
        private IEnumerable<Trip> trips;
        private IEnumerable<Maintenance> maintenances;

        public IncomeStatement(IEnumerable<Trip> trips, IEnumerable<Maintenance> maintenances)
        {
            this.trips = trips;
            this.maintenances = maintenances;
        }

        public double CalculateRevenue()
        {
            return trips.Sum(t => t.Rate);
        }

        public double CalculateDirectCost()
        {
            return trips.Sum(t => t.DirectCost);
        }

        public double CalculateGrossProfit()
        {
            return CalculateRevenue() - CalculateDirectCost();
        }

        public double CalculateTotalMaintenanceCost()
        {
            return maintenances.Sum(m => m.Cost);
        }

        public double CalculateNetIncome()
        {
            return CalculateGrossProfit() - CalculateTotalMaintenanceCost();
        }
    }
}
