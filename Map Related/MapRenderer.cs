public class MapRenderer
{
    private char _player = '@';
    private char _empty = '.';

    
    public void DisplayPlayerOccupiedTile(Map map)
    {
        foreach (Tile tile in map.Tiles)
        {
            if (tile._entity is Player) Console.WriteLine(tile._description);
        }
    }
    
    
    public void Render(Map map)
    {
        int rows = map.GetSize();
        for (int row = 0; row < rows; row++)
        {
            RenderRow(row);
            Console.WriteLine();
        }

        void RenderRow(int row)
        {
            for (int column = 0; column < rows; column++)
            {
                Tile tile = map.Tiles[column, row];
                
                if (tile.GetEntity() is Player)
                {
                    Console.Write(_player);
                }
                else Console.Write(_empty);
            }
            
        }
    }
}