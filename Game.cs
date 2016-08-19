using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          Tower tower = new Tower();
          Map map = new Map(8, 5);
          
          Point point = new Point(4,2);
          
          bool isOnMap = map.OnMap(point);
    }
}