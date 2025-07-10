namespace Command.Classes.Receiver;

// The Receiver class contains some business logic. 
// The receiver does the actual work deferred by the command.
// In this case, it simulates saving a file.
public class FileReceiver
{
    private string Name { get; set; }

    public FileReceiver(string name)
    {
        Name = name;
    }

    public void Save()
    {
        // Logic to save the file
        Console.WriteLine($"File '{Name}'");

        Console.WriteLine("File saved successfully.");
    }
}