namespace AutoBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupCharacters characters;
            WorldMap worldMap;
            TurnBased turnBased;
            Setup();

            // Entry point
            void Setup()
            {
                worldMap = new WorldMap();
                characters = new SetupCharacters();
                characters.AllocateCharacter(ref worldMap.grid!);

                StartGame();
            }

            void StartGame()
            {
                turnBased = new TurnBased(ref worldMap.grid!, ref characters.allPlayers);
                turnBased.StartTurn(ref worldMap.grid, ref characters.allPlayers);
            }
        }
    }
}
