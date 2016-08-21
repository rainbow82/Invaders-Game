using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          //Tower tower = new Tower();
          Map map = new Map(8, 5);
          
          try{
              Path path = new Path(
              new [] { 
                new MapLocation(0, 2, map),
                new MapLocation(1, 2, map),
                new MapLocation(2, 2, map),
                new MapLocation(3, 2, map),
                new MapLocation(4, 2, map),
                new MapLocation(5, 2, map),
                new MapLocation(6, 2, map),
                new MapLocation(7,2, map)
               } 
             );
            
          Invader[] invaders = 
          {
            new Invaders(path);
            new Invaders(path);
            new Invaders(path);
            new Invaders(path)
          };
            
          Tower[] towers =
          {
            new Tower(new MapLocation(1, 3, map));
            new Tower(new MapLocation(3, 3, map));
            new Tower(new MapLocation(5, 3, map))
          }
            
          Level level1 = new Level(invaders)
          {
            Towers = towers
          };
            
          bool playerWon = level.Play();
                                            
          Console.WriteLine("Player " + (playerWon? "won" : "lost")); //playerwon? = if player won  : = else 

           
        }// end try
          catch(OutOfBoundsException ex)
          {
             Console.WriteLine(ex.Message);
          }
           catch(TreehouseDefenseException)
          {
             Console.WriteLine("Unhandled TreehouseDefense Exception");
          }
          catch(Exception ex )
          {
            Console.WriteLine("Unhandled Exception: " + ex);
          }
          
    }
  }
}