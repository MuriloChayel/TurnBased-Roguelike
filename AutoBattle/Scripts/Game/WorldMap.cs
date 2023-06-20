using System;

namespace AutoBattle
{
    public class WorldMap
    {
        public Grid? grid;
        private int width;
        private int height;

        // Initializes world map
        public WorldMap()
        {
            CreateMap();
        }

        // Creates world matrix
        void CreateMap()
        {
            Console.WriteLine("Map width: (At least 2)");
            string widthInpt = Console.ReadLine()!;
            Console.WriteLine("Map height: (At least 2)");
            string heightInpt = Console.ReadLine()!;

            width = Int32.Parse(widthInpt);
            height = Int32.Parse(heightInpt);

            width = (width<2)? 2 : width;
            height = (height<2)? 2 : height;
            
            grid = new Grid(width, height);
            grid.drawBattlefield();
        }
    }
}