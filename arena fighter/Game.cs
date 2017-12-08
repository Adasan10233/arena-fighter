using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_fighter
{
    class Game
    {
        public string Name { get; set; }
        public int MyHealth { get; set; }
        public int EnemyHealth { get; set; }
        public int Dice { get; set; }
        //public int Fight { get; set; }
        public int Damage { get; set; }
        public int Bonus { get; set; }
        public int Strength { get; set; }
        public int Result { get; set; }

        public Game(string name, int myHealth, int dice,int enemyhealth, /*int fight,*/ int damage, int bonus, int strength, int result)
        {
            this.Name = name;
            this.MyHealth = myHealth;
            this.EnemyHealth = enemyhealth;
            this.Dice = dice;
            //Fight = fight;
            this.Damage = damage;
            this.Bonus = bonus;
            this.Strength = Strength;
            this.Result = result;
        }

    }
}



