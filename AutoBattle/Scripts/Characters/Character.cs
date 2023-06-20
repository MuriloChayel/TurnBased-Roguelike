using static AutoBattle.Types;
using System;


namespace AutoBattle
{
    public class Character
    {
        public GridBox currentBox;
        public Character target;
        public string name;
        public float health;
        public float baseDamage;
        public float damageMultiplier;
        public int playerIndex;
        public bool isDead;

        Utils utils = new Utils();

        public Character(CharacterClass characterClass)
        {
            this.name = characterClass.ToString();
            this.isDead = false;

            Console.WriteLine($"Name: {this.name}");
        }

        public void StartTurn(ref Grid battlefield)
        {
            if (this.health > 0)
            {
                if (CheckCloseTargets(battlefield))
                {
                    Attack(target);
                    return;
                }
                else
                {
                    bool leftBorder = battlefield.grids.Find(x => x.Index == currentBox.Index - 1).ocupied;
                    bool left = this.currentBox.xIndex > target.currentBox.xIndex && !leftBorder;

                    bool rightBorder = battlefield.grids.Find(x => x.Index == currentBox.Index + 1).ocupied;
                    bool right = this.currentBox.xIndex < target.currentBox.xIndex && !rightBorder;

                    bool up = this.currentBox.yIndex > target.currentBox.yIndex;
                    bool down = this.currentBox.yIndex < target.currentBox.yIndex;

                    if (left)      // moves character left
                        WalkTO(ref battlefield, -1, true);
                    else if (right) // moves character right
                        WalkTO(ref battlefield, 1, true);
                    else if (up)    // moves character up
                        WalkTO(ref battlefield, -battlefield.yLength, true);
                    else if (down)  // moves character down
                        WalkTO(ref battlefield, battlefield.yLength, true);
                }
            }
            else
            {
                isDead = true;
                return;
            }
        }
        // Check in x and y directions if there is any character close enough to attack.
        bool CheckCloseTargets(Grid battlefield)
        {
            // limits check inside the matrix
            bool lb = battlefield.grids[this.playerIndex].xIndex == 0;
            bool left;
            bool rb = battlefield.grids[this.playerIndex].xIndex == battlefield.xLength - 1;
            bool right;

            if (lb)
                left = false;
            else
                left = battlefield.grids[this.playerIndex - 1].ocupied;

            if (rb)
                right = false;
            else
                right = battlefield.grids[this.playerIndex + 1].ocupied;

            bool up = battlefield.grids.Find(x => x.Index == currentBox.Index - battlefield.yLength).ocupied;
            bool down = battlefield.grids.Find(x => x.Index == currentBox.Index + battlefield.yLength).ocupied;

            if (left || right || up || down)
                return true;

            return false;
        }
        //walks to offset position
        public void WalkTO(ref Grid battlefield, int offset, bool CanWalk)
        {
            //if there is no target close enough, calculates in which direction this character should move to be closer to a possible target
            if (utils.CheckNeighborhood(ref battlefield, this.currentBox.Index, offset))
            {
                currentBox.ocupied = false;
                battlefield.grids[currentBox.Index] = currentBox;
                currentBox = utils.GetGridBoxByOffset(ref battlefield, this.currentBox.Index, offset);
                currentBox.ocupied = true;
                battlefield.grids[currentBox.Index] = currentBox;
                Console.WriteLine($"{this.name} walked\n");
                this.playerIndex += offset;
                battlefield.drawBattlefield();
            }
        }
        private bool GetBorder()
        {
            return false;
        }
        public void Attack(Character target)
        {
            int randDamage = utils.GetRandomInt(0, (int)baseDamage);

            Console.WriteLine($"{this.name} is attacking {this.target.name}");
            Console.WriteLine($"{this.target.name} HP: ({target.health}HP)");
            Console.WriteLine($"{this.target.name} Took: (-{randDamage}HP)");
            target.TakeDamage(randDamage);
            Console.WriteLine($"-----------------------------------------------");

        }
        public void TakeDamage(float amount)
        {
            this.health -= amount;
            Console.WriteLine($"{this.name} HP: {this.health}\n");
            Die();
        }
        public void Die()
        {
            if (this.health <= 0)
                this.isDead = true;
            if (isDead)
            {
                Console.WriteLine($"|================END GAME===================|");
                Console.WriteLine($"\t\t!! {this.target.name} WINS !!");
                Console.WriteLine($"|===========================================|");
            }
            return;
        }
    }
}