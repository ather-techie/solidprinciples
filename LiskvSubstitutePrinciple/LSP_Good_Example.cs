namespace SolidPrinciples;

// LSP Improvement Example: Separating Read and Write Capabilities
// Each class only implements the capabilities it supports.

public interface IReadableFile
{
    string Read();
}

public interface IWritableFile
{
    void Write(string text);
}

public class TextFileHandlerImproved : IReadableFile, IWritableFile
{
    private string filePath;

    public TextFileHandlerImproved(string filePath)
    {
        this.filePath = filePath;
    }

    public void Write(string text)
    {
        System.IO.File.WriteAllText(filePath, text);
    }

    public string Read()
    {
        return System.IO.File.ReadAllText(filePath);
    }
}

public class ReadOnlyFileHandlerImproved : IReadableFile
{
    private string filePath;

    public ReadOnlyFileHandlerImproved(string filePath)
    {
        this.filePath = filePath;
    }

    public string Read()
    {
        return System.IO.File.ReadAllText(filePath);
    }
}

public class LspImprovedFileExample
{
    // Accepts only readable files.
    public static void ProcessReadFile(IReadableFile reader)
    {
        Console.WriteLine(reader.Read());
    }

    // Accepts only writable files.
    public static void ProcessWriteFile(IWritableFile writer, string data)
    {
        writer.Write(data);
    }

    public static void MainImprovedFile(string[] args)
    {
        TextFileHandlerImproved textHandler = new TextFileHandlerImproved("test2.txt");
        ReadOnlyFileHandlerImproved readOnlyHandler = new ReadOnlyFileHandlerImproved("readonly2.txt");

        ProcessWriteFile(textHandler, "Improved Hello, World!");
        ProcessReadFile(textHandler);

        ProcessReadFile(readOnlyHandler);

        // ProcessWriteFile(readOnlyHandler, "This will not compile, because readOnlyHandler does not implement IWritableFile");
    }
}

