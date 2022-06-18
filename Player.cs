public class Player : Entity
{
    private Sense[] _senses;


    public override Command GetCommand()
    {
        throw new NotImplementedException();
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