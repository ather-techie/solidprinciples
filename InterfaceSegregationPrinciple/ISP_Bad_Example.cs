using System;

// ISP Violation Example: Interface forces clients to implement unused methods.
public class IspBadExample
{
    // public static void Main(string[] args)
    // {
    //     ViolationExample();
    //     Console.WriteLine("\n----------------------\n");
    //     //ImprovementExample();
    // }

    // SECTION 1: Simple ISP Violation Example (Devices)
    public static void ViolationExample()
    {
        Console.WriteLine("ISP Violation (Devices):");

        // Interface forces all devices to implement all methods.
        public interface IDevice
        {
            void Print();  // All devices can print
            void Scan();   // Only some devices can scan
            void Fax();    // Only some devices can fax
        }

        public class MultiFunctionPrinter : IDevice
        {
            public void Print() { Console.WriteLine("Printing..."); }
            public void Scan() { Console.WriteLine("Scanning..."); }
            public void Fax() { Console.WriteLine("Faxing..."); }
        }

        public class SimplePrinter : IDevice
        {
            public void Print() { Console.WriteLine("Printing..."); }
            // Violates ISP: must implement unused methods.
            public void Scan() { throw new NotImplementedException("Simple printers don't scan."); } // Violation!
            public void Fax() { throw new NotImplementedException("Simple printers don't fax."); }  // Violation!
        }

        IDevice multi = new MultiFunctionPrinter();
        IDevice simple = new SimplePrinter();

        multi.Print();
        multi.Scan();
        multi.Fax();

        simple.Print();
        try { simple.Scan(); } catch (NotImplementedException ex) { Console.WriteLine(ex.Message); }
        try { simple.Fax(); } catch (NotImplementedException ex) { Console.WriteLine(ex.Message); }
    }

}