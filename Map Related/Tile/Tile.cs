public abstract class Tile
{
    public readonly int _x;
    public readonly int _y;
    public Entity _entity; //how to make it private?
    public string _description = String.Empty;

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
