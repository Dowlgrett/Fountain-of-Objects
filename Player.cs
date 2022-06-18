public class Player : Entity
{
    public override Command GetCommand()
    {
        throw new NotImplementedException();
    }

    public Player(Tile occupiedTile) : base(occupiedTile) { }
}