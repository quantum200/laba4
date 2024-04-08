namespace Models
{
    public abstract class ElectricalAppliance
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public bool IsPluggedIn { get; set; }

        public ElectricalAppliance(string name, double power)
        {
            Name = name;
            Power = power;
            IsPluggedIn = false;
        }

        public abstract void PlugIn();
        public abstract void Unplug();
    }
}