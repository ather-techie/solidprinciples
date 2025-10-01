using System;

// OCP Violation Example: Adding new formats requires modifying this class.
public class ReportGenerator
{
    // This method uses if-else for format selection, violating OCP.
    public void GenerateReport(string format)
    {
        if (format == "PDF")
        {
            Console.WriteLine("Generating PDF Report...");
            // PDF generation logic
        }
        else if (format == "Excel")
        {
            Console.WriteLine("Generating Excel Report...");
            // Excel generation logic
        }
        else if (format == "CSV")
        {
            Console.WriteLine("Generating CSV Report...");
            // CSV generation logic
        }
        else
        {
            throw new Exception("Invalid report format");
        }
    }
}

// Usage
class OcpBadExample
{
    static void Main()
    {
        ReportGenerator generator = new ReportGenerator();
        generator.GenerateReport("PDF");
    }
}
