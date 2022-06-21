public class Player : Entity
{
    private Sense[] _senses;
    public Map map;


    public override Command GetCommand()
    {
        Command? command = null;

        while (command == null)
        {
            Console.Write("Enter command: ");
            string input = Console.ReadLine() ?? String.Empty;

            if (CommandParser.TryParseCommand(input, out ValidCommand cmd, out Argument arg))
            {
                command = CommandFactory.CreateCommand(cmd, arg);
                return command;
            }
            else
            {
                Console.WriteLine("Invalid command, try again.");
            }
        }
        return null;
    }




    public Player(Tile occupiedTile) : base(occupiedTile) { }
}

public abstract class Sense
{

}

public class Hearing : Sense
{

}

public class LightSense : Sense
{

}