public static class Game
{
    private static Map _map = MapBuilder.BuildMap(MapType.Default);
    private static MapRenderer _mapRenderer = new();
    private static List<Entity> _entities;

    public static void Run()
    {
        while (true)
        {
            _mapRenderer.Render(_map);
            Console.ReadLine();
        }
    }
}