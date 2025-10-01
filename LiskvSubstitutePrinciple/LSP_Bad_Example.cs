namespace SolidPrinciples;

using System;
using System.Collections.Generic;

// LSP Violation Example: Incorrect File Handling
// ReadOnlyFileHandler throws exception for Write, violating LSP.

public abstract class FileHandler
{
    public abstract void Write(string text);
    public abstract string Read();
}

public class TextFileHandler : FileHandler
{
    private string filePath;

    public TextFileHandler(string filePath)
    {
        this.filePath = filePath;
    }

    public override void Write(string text)
    {
        System.IO.File.WriteAllText(filePath, text);
    }

    public override string Read()
    {
        return System.IO.File.ReadAllText(filePath);
    }
}

public class ReadOnlyFileHandler : FileHandler
{
    private string filePath;

    public ReadOnlyFileHandler(string filePath)
    {
        this.filePath = filePath;
    }

    // Throws exception, breaking substitutability.
    public override void Write(string text)
    {
        throw new NotSupportedException("Read-only files cannot be written to.");
    }

    public override string Read()
    {
        return System.IO.File.ReadAllText(filePath);
    }
}

public class LspViolationFileExample
{
    // Assumes all FileHandler can write, but ReadOnlyFileHandler cannot.
    public static void ProcessFile(FileHandler handler, string data)
    {
        handler.Write(data); // Problem: This might throw an exception for ReadOnlyFileHandler
        Console.WriteLine(handler.Read());
    }

    public static void Main(string[] args)
    {
        TextFileHandler textHandler = new TextFileHandler("test.txt");
        ReadOnlyFileHandler readOnlyHandler = new ReadOnlyFileHandler("readonly.txt");

        ProcessFile(textHandler, "Hello, World!"); // Works fine
        try
        {
            ProcessFile(readOnlyHandler, "This will fail."); // Throws NotSupportedException
        }
        catch(NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

