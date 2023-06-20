# Roguelike
Roguelike C# 

# Character

The `Character` script contains the definition of the `Character` class, representing characters in the game.

## Methods

| Method                    | Description                                                   |
|---------------------------|---------------------------------------------------------------|
| `Character()` | Constructor for the `Character` class. Initializes a character with the given `type`. |
| `StartTurn()`          | Starts this character's turn to take action. |
| `CheckCloseTargets()`        | Scans neighboring cells for target enemies.                  |
| `WalkTO()`        | Checks neighboring cells and checks if they can move to them.                  |
| `Attack()`        | Check neighboring cells and attack if the cell is occupied.                  |
| `TakeDamage()`        | Takes damage applied by your enemy.                  |
| `Die()`        | Actions performed at the moment the player dies.                  |

The `Character` class represents a character in the game and provides methods to manipulate their attributes such as health and perform actions like attacking other characters.

By utilizing the `Character` class, you can create and manage characters, and track their health, or interactions between them.

The `Character` script contains the definition of the `Character` class, representing characters in the game.


# SetupCharacters

The `SetupCharacters` script contains the character's creation and allocation logic.

## Methods

| Method                    | Description                                                   |
|---------------------------|---------------------------------------------------------------|
| `SetupCharacters()` | Constructor for the `SetupCharacters` class. Initializes character's properties. |
| `SetupCharactersProperties()`          | Setup characters's properties. |
| `CreateCharacter()`        | Create new characters by with a given `type`.                  |
| `SetupTargets()`        | Set targets for the given character.                  |
| `AllocateCharacter()`        | Allocate characters on the game map.                  |

The `SetupCharacters` class represents a manager to manipulate the character's attributes such as actions and behaviors.

By utilizing the `SetupCharacters` class, you can create and manage characters on the map.


# TurnBased

The `TurnBased` script contains the game's logic creation.

## Methods

| Method                    | Description                                                   |
|---------------------------|---------------------------------------------------------------|
| `TurnBased()` | Constructor for the `TurnBased` class. Initializes the game's logic. |
| `StartTurn()`          | Starts turns for each player in the global player list order. |
| `HandleTurn()`        | Wait for the player to press a key to proceed to the next action while the players have life.                  |
| `SetupTargets()`        | Set targets for the given character.                  |
| `AllocateCharacter()`        | Allocate characters on the game map.                  |

The `TurnBased` class represents a manager to manipulate the game logic and how the turns will work.

By utilizing the `TurnBased` class, manage the game's logic and turns for each player on the map.


# WorldMap

The `WorldMap` script contains the game's world logic creation.

## Methods

| Method                    | Description                                                   |
|---------------------------|---------------------------------------------------------------|
| `WorldMap()` | Constructor for the `WorldMap` class. Initializes the game's world. |
| `CreateMap()`          | Creates the world matrix. |

The `WorldMap` class represents a manager manipulating the world's game logic and how big the world will be. Also, the proportion can be set.

By utilizing the `WorldMap` class, you can manage the game's world and set width, and height, and implements many other properties.


# Grid

The `Grid` script contains the game's world matrix logic.

## Methods

| Method                    | Description                                                   |
|---------------------------|---------------------------------------------------------------|
| `Grid()` | Builds a matrix of cells that the player and enemies can navigate through during gameplay. |
| `drawBattlefield()`          | Draw the world's matrix. |

The `Grid` class represents a manager. You can manipulate the world's matrix logic by rows and columns. Also, the proportion can be set using different values for each property.


# Types

The `Types` script contains structs that define important types for the game.

## Methods

| Method                    | Description                                                   |
|---------------------------|---------------------------------------------------------------|
| `GridBox()` | Builds a cell that the player and enemies can navigate through during gameplay. |
| `CharacterClass()`          | Has a numerical representation that defines the class of each character in the game. |

The `Types` class represents a bunch of useful types.


# Utils

The `Utils` script contains publicly accessible useful generic methods.

## Methods

| Method                    | Description                                                   |
|---------------------------|---------------------------------------------------------------|
| `GetRandomInt()` | Returns a random integer between (x,(inclusive) y(exclusive)). |
| `CheckNeighborhood()` | Checks cells based on a given position and search range. |
| `GetGridBoxByOffset()` | Returns a GridBox based on a given offset. |

The `Types` class provides a bunch of useful generic methods.



