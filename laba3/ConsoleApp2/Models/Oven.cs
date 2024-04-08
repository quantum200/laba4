namespace Models
{
    public class Oven : ElectricalAppliance
    {
        public Oven(string name, double power) : base(name, power) { }

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