public static class CommandFactory
{
    public static ICommand CreateCommand(ICommand command, CommandArgument arg)
    {
        return (command, arg) switch
        {
            (MoveCommand, CommandArgument.Up) => new MoveCommand(CommandArgument.Up),
            (MoveCommand, CommandArgument.Down) => new MoveCommand(CommandArgument.Down),
            (MoveCommand, CommandArgument.Left) => new MoveCommand(CommandArgument.Left),
            (MoveCommand, CommandArgument.Right) => new MoveCommand(CommandArgument.Right),
            (ActivateCommand, CommandArgument.Fountain) => new ActivateCommand(CommandArgument.Fountain),
            _ => throw new ArgumentException(),
        };
    }
}

