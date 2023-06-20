namespace AutoBattle
{
    public class Types
    {
        // Builds a cell to character's navigate through during gameplay
        public struct GridBox
        {
            public int xIndex;
            public int yIndex;
            public bool ocupied;
            public int Index;

            public GridBox(int x, int y, bool ocupied, int index)
            {
                xIndex = x;
                yIndex = y;
                this.ocupied = ocupied;
                this.Index = index;
            }
        }

        // Numerical representation that defines the class of each character in the game
        public enum CharacterClass : uint
        {
            Paladin = 1,
            Warrior = 2,
            Cleric = 3,
            Archer = 4
        }
    }
}
