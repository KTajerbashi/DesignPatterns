namespace DesignPatterns.Behavioral.TemplateMethod;

public abstract class ReportTemplate
{
    // Template Method (defines the skeleton)
    public string GenerateReport()
    {
        string report = string.Empty;
        report += $"Step 1: {FetchData()}\n";
        report += $"Step 2: {ProcessData()}\n";
        report += $"Step 3: {FormatReport()}\n";
        report += $"Step 4: {ExportReport()}\n";
        return report;
    }

    // Common steps (implemented)
    protected virtual string FetchData() => "Data fetched from database.";

    // Steps to be overridden
    protected abstract string ProcessData();
    protected abstract string FormatReport();
    protected abstract string ExportReport();
}

public class PdfReport : ReportTemplate
{
    protected override string ProcessData() => "Processed data for PDF layout.";
    protected override string FormatReport() => "Formatted report in PDF structure.";
    protected override string ExportReport() => "📄 Exported as PDF file.";
}
public class ExcelReport : ReportTemplate
{
    protected override string ProcessData() => "Processed data for tabular Excel layout.";
    protected override string FormatReport() => "Formatted report into spreadsheet cells.";
    protected override string ExportReport() => "📊 Exported as Excel file.";
}

public class HtmlReport : ReportTemplate
{
    protected override string ProcessData() => "Processed data for web layout.";
    protected override string FormatReport() => "Formatted report into HTML elements.";
    protected override string ExportReport() => "🌐 Exported as HTML file.";
}