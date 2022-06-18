public abstract class Command
{
    protected Argument _argument;
    public abstract void Execute();
    public Command(Argument argument)
    {
        _argument = argument;
    }
}

