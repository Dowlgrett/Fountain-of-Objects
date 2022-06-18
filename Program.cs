public enum Command
{

}

public enum CommandArgument
{
    Fountain,
    Up,
    Down,
    Left,
    Right,
}

public class Player
{
    public ICommand CurrentCommand;


}

// Player.CurrentCommand.Execute(arg);