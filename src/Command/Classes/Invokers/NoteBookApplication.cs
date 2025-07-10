using Command.Abstractions;

namespace Command.Classes.Invokers;

public class NoteBookApplication
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        if (_command is ICommand)
            _command.Execute();
        else
            Console.WriteLine("No command set to execute.");
    }
}