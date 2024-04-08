using System;
using System.Collections.Generic;
using System.Linq;
using Models;
namespace Services
{
    public class Apartment
    {
        private List<ElectricalAppliance> appliances = new List<ElectricalAppliance>();

        public void AddAppliance(ElectricalAppliance appliance)
        {
            appliances.Add(appliance);
        }

        public double CalculateTotalPower()
        {
            return appliances.Where(a => a.IsPluggedIn).Sum(a => a.Power);
        }

        public List<ElectricalAppliance> SortAppliancesByPower()
        {
            return appliances.OrderBy(a => a.Power).ToList();
        }

        public List<ElectricalAppliance> FindAppliancesByPowerRange(double minPower, double maxPower)
        {
            return appliances.Where(a => a.Power >= minPower && a.Power <= maxPower).ToList();
        }

        public ElectricalAppliance FindApplianceByName(string name)
        {
            return appliances.FirstOrDefault(a => a.Name == name);
        }
    }
}