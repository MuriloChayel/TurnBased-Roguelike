using static AutoBattle.Types;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AutoBattle
{
    public class SetupCharacters
    {
        public Character playerCharacter;
        public Character enemyCharacter;
        public List<Character> allPlayers = new List<Character>();
        private Utils utils = new Utils();

        // Initializes character's properties
        public SetupCharacters()
        {
            SetupCharactersProperties();
        }

        // Setup characters's properties
        public void SetupCharactersProperties()
        {
            //asks for the player to choose between for possible classes via console.
            Console.WriteLine("Choose Your Class:\n");
            Console.WriteLine("[1] Paladin, [2] Warrior, [3] Cleric, [4] Archer");

            string choice = Console.ReadLine()!;
            int choiceId = Int32.Parse(choice);

            if (choiceId > 4 || choiceId < 0)
            {
                SetupCharactersProperties();
                return;
            }

            playerCharacter = CreateCharacter(choiceId);
            enemyCharacter = CreateCharacter(utils.GetRandomInt(1, 5));
            SetupTargets();
        }

        // Create new characters with a given type
        public Character CreateCharacter(int classIndex)
        {
            CharacterClass characterClass = (CharacterClass)classIndex;

            Console.WriteLine($"-------------------------------");
            Character character = new Character(characterClass);
            Console.WriteLine($"Class: {characterClass}");
            Console.WriteLine($"-------------------------------");

            character.health = 100;
            character.baseDamage = 20;
            character.playerIndex = 0;

            allPlayers.Add(character);
            return character;
        }

        // Set targets for the given character
        private void SetupTargets()
        {
            this.playerCharacter.target = this.enemyCharacter;
            this.enemyCharacter.target = this.playerCharacter;
        }

        // Allocate characters on the map
        public void AllocateCharacter(ref Grid grid)
        {
            foreach (Character character in allPlayers)
            {
                int randElementId = utils.GetRandomInt(0, grid.grids.Count);
                GridBox randLocation = grid.grids.ElementAt(randElementId);

                if (!randLocation.ocupied)
                {
                    randLocation.ocupied = true;
                    grid.grids[randElementId] = randLocation;
                    character.currentBox = grid.grids[randElementId];
                    character.playerIndex = grid.grids[randElementId].Index;
                }
                else
                {
                    GridBox emptyCell = grid.grids.ElementAt(0);
                    
                    for (int a = 0; a < grid.grids.Count; a++)
                    {
                        emptyCell.ocupied = false;
                        grid.grids[a] = emptyCell;
                    }
                }
            }
            grid.drawBattlefield();
            return;
        }
    }
}