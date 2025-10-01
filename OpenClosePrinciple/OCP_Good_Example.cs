using System;
using System.Collections.Generic;

// OCP Good Example: Open for extension, closed for modification.

// Step 1: Create an Interface for Report Generation
public interface IReport
{
    void Generate();
}

// Step 2: Implement Different Report Formats Without If-Else
public class PdfReport : IReport
{
    public void Generate() => Console.WriteLine("Generating PDF Report...");
}

public class ExcelReport : IReport
{
    public void Generate() => Console.WriteLine("Generating Excel Report...");
}

public class CsvReport : IReport
{
    public void Generate() => Console.WriteLine("Generating CSV Report...");
}

// Step 3: Use a Factory with Dictionary for Report Selection
public class ReportFactory
{
    // Easily extendable without modifying existing code.
    private static readonly Dictionary<string, IReport> ReportStrategies = new()
    {
        { "PDF", new PdfReport() },
        { "Excel", new ExcelReport() },
        { "CSV", new CsvReport() }
    };

    public static IReport GetReportGenerator(string format)
    {
        return ReportStrategies.ContainsKey(format) ? ReportStrategies[format] : throw new Exception("Invalid report format");
    }
}

// Step 4: Report Generator Class Uses Dependency Injection
public class ReportGenerator
{
    private readonly IReport _report;

    public ReportGenerator(IReport report)
    {
        _report = report;
    }

    public void GenerateReport()
    {
        _report.Generate();
    }
}

// Step 5: Usage Example (No If-Else)
class OcpGoodExample
{
    static void Main()
    {
        string format = "Excel"; // Can be dynamically set
        IReport report = ReportFactory.GetReportGenerator(format);
        ReportGenerator generator = new ReportGenerator(report);

        generator.GenerateReport();
    }
}
