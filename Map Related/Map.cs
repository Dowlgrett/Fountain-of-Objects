public class Map
{
    public Tile[,] Tiles { get; set; } //Question: how to make it private while permitting MapBuilder to change it?

    public Map(int size) //makes a map filled with empty tiles.
    {
        Tiles = new Tile[size, size];

         for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                Tiles[x, y] = new EmptyTile(x, y);
            }
        }
    }

    public int GetSize()
    {
        return Tiles.GetLength(0);
    }  
}
