public class FountainTile : Tile, IActivatable
{
    public bool isActivated = false;

    public void Activate()
    {
        isActivated = true;
    }

    public FountainTile(int x, int y) : base(x, y)
    {
        _description = "You can sense fountain here.";
    }
}
