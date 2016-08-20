namespace TreehouseDefense
{
  class Invader
  {
    private readonly Path _path;
    private int _pathStep = 0;
    
    //using auto property for getter and setter
    public MapLocation Location{ get; private set;}
    
    public Invader(Path path)
    {
      _path = path;
      Location = _path.GetPathAtLocation(_pathStep);
    }
    
    public void Move()
    {
      _pathStep ++;
      Location = _path.GetLocationAt(_pathStep);
    }
  }
  
}