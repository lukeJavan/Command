using Command.Classes.Commands;
using Command.Classes.Invokers;
using Command.Classes.Receiver;

namespace Command;

public class Program
{
    public static void Main(string[] args)
    {
        // Invoker
        // The invoker is the object that calls the command to execute
        NoteBookApplication noteBook = new();

        // Receiver
        // The receiver is the object that contains the business logic to be executed
        CurrentFile file = new("example.txt");

        // Command
        // The command is the object that encapsulates the action to be performed
        SaveCommand saveCommand = new(file);

        // Set the command in the invoker
        noteBook.SetCommand(saveCommand);

        // Execute the command
        // The invoker executes the command, which in turn calls the receiver to perform the action
        noteBook.ExecuteOperation();
    }
}