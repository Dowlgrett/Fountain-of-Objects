public static class Game
{
    private static Map _map = MapBuilder.BuildMap(MapType.Default);
    private static MapRenderer _mapRenderer = new();
    private static List<Entity> _entities = new();

    public static void Run()
    {
        FountainTile? fountain = null;
        EntranceTile? entrance = null;

        foreach (var tile in _map.Tiles)
        {
            if (tile is FountainTile) fountain = (FountainTile)tile;
        }

        foreach (var tile in _map.Tiles)
        {
            if (tile is EntranceTile) entrance = (EntranceTile)tile;
        }


        bool isWin()
        {
            if (fountain.isActivated && entrance._entity is Player) return true;
            else return false;
        }

        foreach (var tile in _map.Tiles)
        {
            if (tile._entity != null) _entities.Add(tile._entity);
        }

        foreach (var entity in _entities)
        {
            entity.Map = _map;
        }


        while (!isWin())
        {

            _mapRenderer.DisplayPlayerOccupiedTile(_map);
            _mapRenderer.Render(_map);

            foreach (var entity in _entities)
            {
                var command = entity.GetCommand();
                command.ExecuteOnEntity(entity, _map);
            }

            Console.Clear();


        }

        Console.WriteLine("You won! Congrats!");
    }
}