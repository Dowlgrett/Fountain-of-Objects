public abstract class Entity
{
    public Tile OccupiedTile { get; set; }
    public Map Map { get; set; }

    public Tile GetOccupiedTile()
    {
        return OccupiedTile;
    }

    public Entity(Tile occupiedTile)
    {
        OccupiedTile = occupiedTile;
    }

    public abstract Command GetCommand();
}



