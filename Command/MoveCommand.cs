public class MoveCommand : Command
{
    public MoveCommand(Argument argument) : base(argument) { }

    public override void ExecuteOnEntity(Entity entity, Map map)
    {
        Tile currentTile = entity.GetOccupiedTile();
        currentTile._entity = null;
        int mapSize = map.GetSize() - 1;
        entity.OccupiedTile = _argument switch

        {
            Argument.Up => map.Tiles[Math.Clamp(currentTile._x, 0, mapSize), Math.Clamp(currentTile._y - 1, 0, mapSize)],
            Argument.Down => map.Tiles[Math.Clamp(currentTile._x, 0, mapSize), Math.Clamp(currentTile._y + 1, 0, mapSize)],
            Argument.Right => map.Tiles[Math.Clamp(currentTile._x + 1, 0, mapSize), Math.Clamp(currentTile._y, 0, mapSize)],
            Argument.Left => map.Tiles[Math.Clamp(currentTile._x - 1, 0, mapSize), Math.Clamp(currentTile._y, 0, mapSize)],
            _ => throw new ArgumentException(),
        };

        entity.OccupiedTile._entity = entity;




    }
}

