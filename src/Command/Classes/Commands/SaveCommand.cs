using Command.Abstractions;
using Command.Classes.Receiver;

namespace Command.Classes.Commands;

// Concrete command class that implements the ICommand interface
// A concrete command isn’t supposed to perform the work on its own, 
// but rather to pass the call to one of the business logic objects
public class SaveCommand : ICommand
{
    private FileReceiver _fileToSave;

    public SaveCommand(FileReceiver fileToSave)
    {
        _fileToSave = fileToSave;
    }

    public void Execute()
    {
        _fileToSave.Save();
    }
}