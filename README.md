# Roguelike
Roguelike C# 

Claro! Aqui está uma versão simplificada do markdown utilizando tabelas:

# Documentação dos Scripts

| Script        | Descrição                                                             |
|---------------|----------------------------------------------------------------------|
| Character     | Contém a definição da classe Character, que representa um personagem no jogo.              |
| SetupCharacter| Contém funções auxiliares para configurar os personagens no jogo.                  |
| TurnBased     | Implementa a lógica do sistema de jogo baseado em turnos.                                      |
| WorldMap      | Contém a definição da classe WorldMap, que representa o mapa do mundo do jogo.              |
| Grid          | Contém a definição da classe Grid, que representa uma grade no jogo.                       |
| Types         | Contém definições de tipos de dados utilizados no jogo.                                   |
| Utils         | Contém funções utilitárias para o jogo.                                                    |
| Program       | Ponto de entrada do programa principal.                                                    |

## Character

O script `Character` contém a definição da classe Character, que representa um personagem no jogo.

Métodos:

| Método                 | Descrição                                             |
|------------------------|-------------------------------------------------------|
| `__init__(name, health, attack)` | Construtor da classe Character.                       |
| `take_damage(damage)`         | Reduz a quantidade de pontos de vida do personagem.   |
| `attack_target(target)`       | Realiza um ataque ao alvo especificado.                |

## SetupCharacter

O script `SetupCharacter` contém funções auxiliares para configurar os personagens no jogo.

Funções:

| Função                   | Descrição                                          |
|--------------------------|----------------------------------------------------|
| `create_character(name)` | Cria e retorna um objeto Character com o nome dado. |

## TurnBased

O script `TurnBased` implementa a lógica do sistema de jogo baseado em turnos.

Classes:

| Classe              | Descrição                                            |
|---------------------|------------------------------------------------------|
| `TurnBasedGame` | Representa um jogo baseado em turnos.               |

Métodos:

| Método           | Descrição                                   |
|------------------|---------------------------------------------|
| `__init__()`     | Construtor da classe TurnBasedGame.         |
| `start_game()`   | Inicia o jogo.                              |
| `next_turn()`    | Avança para o próximo turno.                |
| `game_over()`    | Verifica se o jogo acabou.                   |

## WorldMap

O script `WorldMap` contém a definição da classe WorldMap, que representa o mapa do mundo do jogo.

Classes:

| Classe           | Descrição                                     |
|------------------|-----------------------------------------------|
| `WorldMap` | Representa o mapa do mundo do jogo.          |

Métodos:

| Método            | Descrição                                      |
|-------------------|------------------------------------------------|
| `__init__(width, height)` | Construtor da classe WorldMap.                 |
| `generate_map()`          | Gera o mapa do mundo.                           |
| `get_tile(x, y)`          | Retorna o tipo de terreno nas coordenadas dadas. |

## Grid

O script `Grid` contém a definição da classe Grid, que representa uma grade no jogo.

Classes:

| Classe     | Descrição                              |
|------------|----------------------------------------|
| `Grid` | Representa uma grade no jogo.        |

Métodos:

| Método                | Descrição                                       |
|-----------------------|-------------------------------------------------|
| `__init__(rows, columns)` | Construtor da classe Grid.

                      |
| `get_cell(row, column)`   | Retorna o valor da célula nas coordenadas dadas. |
| `set_cell(row, column, value)` | Define o valor da célula nas coordenadas dadas. |

## Types

O script `Types` contém definições de tipos de dados utilizados no jogo.

Tipos:

| Tipo     | Descrição                                     |
|----------|-----------------------------------------------|
| `Position` | Representa uma posição no jogo, com coordenadas x e y. |

## Utils

O script `Utils` contém funções utilitárias para o jogo.

Funções:

| Função                                  | Descrição                                           |
|-----------------------------------------|-----------------------------------------------------|
| `calculate_distance(position1, position2)` | Calcula a distância entre duas posições no jogo.    |
| `is_valid_position(position)`              | Verifica se uma posição é válida no jogo.            |

## Program

O script `Program` é o ponto de entrada do programa principal.

Funções:

| Função    | Descrição                                          |
|-----------|----------------------------------------------------|
| `main()` | Função principal que inicia o programa.              |

Espero que essa versão simplificada utilizando tabelas seja útil para documentar seus scripts!
