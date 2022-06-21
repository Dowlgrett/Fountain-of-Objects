public static class CommandFactory
{
    public static Command CreateCommand(ValidCommand command, Argument argument)
    {
        return (command, argument) switch
        {
            (ValidCommand.Move, Argument.Up) => new MoveCommand(Argument.Up),
            (ValidCommand.Move, Argument.Down) => new MoveCommand(Argument.Down),
            (ValidCommand.Move, Argument.Left) => new MoveCommand(Argument.Left),
            (ValidCommand.Move, Argument.Right) => new MoveCommand(Argument.Right),
            (ValidCommand.Activate, Argument.Fountain) => new ActivateCommand(Argument.Fountain),
            _ => throw new ArgumentException(),
        };
    }
}

