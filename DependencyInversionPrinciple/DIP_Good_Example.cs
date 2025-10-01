// DIP Improvement Example
public class DIPImprovement
{
    // Abstraction (interface) for switchable devices.
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }

    // Low-level module implementing the abstraction.
    public class LightBulb : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("LightBulb: Bulb turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("LightBulb: Bulb turned off");
        }
    }

    public class Fan : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan: Fan turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Fan: Fan turned off");
        }
    }

    // High-level module depends on abstraction, not concrete classes.
    public class Switch
    {
        private ISwitchable device;

        public Switch(ISwitchable device)
        {
            this.device = device;
        }

        public void Toggle()
        {
            device.TurnOn();
            device.TurnOff();
        }
    }

    public static void Main(string[] args)
    {
        ISwitchable bulb = new LightBulb();
        ISwitchable fan = new Fan();
        Switch switchObjBulb = new Switch(bulb);
        Switch switchObjFan = new Switch(fan);

        switchObjBulb.Toggle(); // Works with LightBulb.
        switchObjFan.Toggle(); // Works with Fan.
    }
}