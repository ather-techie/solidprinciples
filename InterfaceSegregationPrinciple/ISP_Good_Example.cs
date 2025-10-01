public class IspGoodExample{

    // public static void Main(string[] args)
    // {
    //     //ViolationExample();
    //     Console.WriteLine("\n----------------------\n");
    //     ImprovementExample();
    // }

    // SECTION 2: Simple ISP Improvement Example (Devices)
    public static void ImprovementExample()
    {
        Console.WriteLine("ISP Improvement (Devices):");

        // Segregated interfaces for each capability.
        public interface IPrinter
        {
            void Print();
        }

        public interface IScanner
        {
            void Scan();
        }

        public interface IFax
        {
            void Fax();
        }

        // Implements only required interfaces.
        public class MultiFunctionPrinterImproved : IPrinter, IScanner, IFax
        {
            public void Print() { Console.WriteLine("Printing (improved)..."); }
            public void Scan() { Console.WriteLine("Scanning (improved)..."); }
            public void Fax() { Console.WriteLine("Faxing (improved)..."); }
        }

        public class SimplePrinterImproved : IPrinter
        {
            public void Print() { Console.WriteLine("Printing (improved)..."); }
        }

        IPrinter multiImprovedPrinter = new MultiFunctionPrinterImproved();
        IScanner multiImprovedScanner = new MultiFunctionPrinterImproved();
        IFax multiImprovedFax = new MultiFunctionPrinterImproved();

        IPrinter simpleImprovedPrinter = new SimplePrinterImproved();

        multiImprovedPrinter.Print();
        multiImprovedScanner.Scan();
        multiImprovedFax.Fax();

        simpleImprovedPrinter.Print();
    }
}