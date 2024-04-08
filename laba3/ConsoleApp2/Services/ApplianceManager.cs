using System;
using System.Collections.Generic;
using System.Linq;
using Models;
namespace Services
{
    public class ApplianceManager
    {
        private Apartment _apartment;
        public ApplianceManager(Apartment apartment)
        {
            _apartment = apartment;
        }
        public void AddAppliance(ElectricalAppliance appliance)
        {
            _apartment.AddAppliance(appliance);
        }
        public void PlugInAppliance(string name)
        {
            ElectricalAppliance appliance = _apartment.FindApplianceByName(name);
            if (appliance != null)
            {
                appliance.PlugIn();
            }
        }
        public void UnplugAppliance(string name)
        {
            ElectricalAppliance appliance = _apartment.FindApplianceByName(name);
            if (appliance != null)
            {
                appliance.Unplug();
            }
        }
    }
}