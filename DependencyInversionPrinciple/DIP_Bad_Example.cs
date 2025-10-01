using System;
using System.Collections.Generic;

// DIP Violation Example
public class DIPViolation
{
    // High-level module tightly coupled to low-level module.
    public class LightBulb
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

    public class Switch
    {
        // Direct dependency on concrete class, violates DIP.
        private LightBulb bulb;

        public Switch(LightBulb bulb)
        {
            this.bulb = bulb;
        }

        public void Toggle()
        {
            // Direct dependency on LightBulb.
            bulb.TurnOn();
            bulb.TurnOff();
        }
    }

    public static void Main(string[] args)
    {
        var bulb = new LightBulb();
        var switchObj = new Switch(bulb);

        switchObj.Toggle(); // Demonstrates direct coupling.
    }
}
