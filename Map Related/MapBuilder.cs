public static class MapBuilder
{
    public static Map BuildMap(MapType type)
    {
        int size = type switch
        {
            MapType.Default => 4,
            _ => throw new ArgumentException(),
        };

        Map map = new(4);

        int FountainX = 2;
        int FountainY = 0;

        int EntranceX = 0;
        int EntranceY = 0;


        map.Tiles[FountainX, FountainY] = new FountainTile(FountainX, FountainY);
        map.Tiles[EntranceX, EntranceY] = new EntranceTile(EntranceX, EntranceY);

        //I don't like repeating [EntranceX, EntranceY] here, how do I fix it?
        map.Tiles[EntranceX, EntranceY]._entity = new Player(map.Tiles[EntranceX, EntranceY]); 
        

        return map;
    }
}
