public static class CommandFactory
{
    public static Command CreateCommand(Command command, Argument argument)
    {
        return (command, argument) switch
        {
            (MoveCommand, Argument.Up) => new MoveCommand(Argument.Up),
            (MoveCommand, Argument.Down) => new MoveCommand(Argument.Down),
            (MoveCommand, Argument.Left) => new MoveCommand(Argument.Left),
            (MoveCommand, Argument.Right) => new MoveCommand(Argument.Right),
            (ActivateCommand, Argument.Fountain) => new ActivateCommand(Argument.Fountain),
            _ => throw new ArgumentException(),
        };
    }
}

