namespace Models
{
    public class Fridge : ElectricalAppliance
    {
        public Fridge(string name, double power) : base(name, power) { }

        public override void PlugIn()
        {
            IsPluggedIn = true;
        }
        public override void Unplug()
        {
            IsPluggedIn = false;
        }
    }
}