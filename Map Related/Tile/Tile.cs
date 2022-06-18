public abstract class Tile
{
    private readonly int _x;
    private readonly int _y;
    protected string _description = String.Empty;

    public Tile(int x, int y)
    {
        _x = x;
        _y = y;
    }
}
