public abstract class Command
{
    protected Argument _argument;
    
    public Command(Argument argument)
    {
        _argument = argument;
    }

    abstract public void ExecuteOnEntity(Entity entity, Map map);

}

