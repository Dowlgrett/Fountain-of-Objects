public abstract class Tile
{
    private readonly int _x;
    private readonly int _y;
    public Entity _entity; //how to make it private?
    protected string _description = String.Empty;

    public Entity GetEntity()
    {
        return _entity;
    }

    public Tile(int x, int y)
    {
        _x = x;
        _y = y;
    }
}

public class EmptyTile : Tile
{
    public EmptyTile(int x, int y) : base(x, y)
    {
        _description = "Just an empty room.";
    }
}
