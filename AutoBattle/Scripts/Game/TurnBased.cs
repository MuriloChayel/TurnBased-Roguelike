
using System.Collections.Generic;
using System;

namespace AutoBattle
{
    public class TurnBased
    {
        public int currentTurn;
        private Utils utils;
        public bool endGame = false;

        // Initializes game manager
        public TurnBased(ref Grid grid, ref List<Character> allPlayers)
        {
            utils = new Utils();
            StartTurn(ref grid, ref allPlayers);
        }

        // Starts turns for player
        public void StartTurn(ref Grid grid, ref List<Character> allPlayers)
        {
            // randomizes all players at start 
            if (currentTurn == 0)
                allPlayers.Sort((a, b) => utils.GetRandomInt(-1, 2));

            Console.WriteLine($"=================== TURN {currentTurn} ===================\n");
            foreach (Character character in allPlayers)
            {
                character.StartTurn(ref grid!);
            }

            currentTurn++;
            HandleTurn(ref grid, ref allPlayers);
        }

        // Wait player press a key to proceed to the next action while player have life.
        private void HandleTurn(ref Grid grid, ref List<Character> allPlayers)
        {
            // int id = 0;
            foreach (Character character in allPlayers)
            {
                if (!endGame)
                {
                    if (character.target.health <= 0 || character.health <= 0)
                    {
                        endGame = true;
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Press any key to start the next turn\n");
                        Console.ReadKey();
                        StartTurn(ref grid, ref allPlayers);
                    }
                }
            }
        }
    }
}