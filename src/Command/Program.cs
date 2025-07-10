using Command.Classes.Commands;
using Command.Classes.Invokers;
using Command.Classes.Receiver;

namespace Command;

public class Program
{
    public static void Main(string[] args)
    {
        NoteBookApplication noteBook = new();

        FileReceiver fileToSave = new("example.txt");

        noteBook.SetCommand(new SaveCommand(fileToSave));
        noteBook.ExecuteCommand();
    }
}