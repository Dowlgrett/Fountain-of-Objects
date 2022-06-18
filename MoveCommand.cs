public class MoveCommand : ICommand
{
    private readonly CommandArgument _argument;
    public MoveCommand(CommandArgument argument)
    {
        _argument = argument;
    }
    public void Execute(CommandArgument arg)
    {

    }

}