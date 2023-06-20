using static AutoBattle.Types;
using System;

namespace AutoBattle
{
    public class Utils
    {
        // UTILS - Generic 
        // Returns a random integer between(x, (inclusive) y(exclusive)).
        public int GetRandomInt(int min, int max)
        {
            var rand = new Random();
            int index = rand.Next(min, max);
            return index;
        }

        // UTILS - Character 
        // Checks cells based on a given position and search range
        public bool CheckNeighborhood(ref Grid battlefield, int index, int offset)
        {
            return (battlefield.grids.Exists(x => x.Index == index + offset));
        }

        // Returns a GridBox based on a given offset
        public GridBox GetGridBoxByOffset(ref Grid battlefield, int index, int offset)
        {
            return battlefield.grids.Find(x => x.Index == index + offset);
        }
    }
}