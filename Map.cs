namespace TreehouseDefense
{
  class Map
  {
    public readonly int Width;
    public readonly int Height;
    
    public Map(int width, int height)
    {
      Width = width;
      Height = height;
    }
    
    public bool OnMap(Point point)
    {
      return inBounds = point.X >=0 && < Width && point.Y >=0 && < Height;
   
    }
  }
}