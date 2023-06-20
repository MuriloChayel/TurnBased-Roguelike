using static AutoBattle.Types;
using System;

namespace AutoBattle
{
    public class Utils
    {
        //UTILS - Generic 
        public int GetRandomInt(int min, int max)
        {
            var rand = new Random();
            int index = rand.Next(min, max);
            return index;
        }

        //UTILS - Character 
        public bool CheckNeighborhood(ref Grid battlefield, int index, int offset)
        {
            return (battlefield.grids.Exists(x => x.Index == index + offset));
        }
        public GridBox GetGridBoxByOffset(ref Grid battlefield, int index, int offset)
        {
            return battlefield.grids.Find(x => x.Index == index + offset);
        }
    }
}