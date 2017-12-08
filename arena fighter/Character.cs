using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_fighter
{
    class Character
    {
        static InfoGenerator infoGen = new InfoGenerator(new Random().Next());
        public string UserName;
        public int Health = 0;
        public int Damage = 0;
        public int strength = 0;
       


        public Character(string Username)
        {
            this.UserName = Username;
            Health = infoGen.Next(10, 20);
            Damage = infoGen.Next(1, 5);
            strength = infoGen.Next(2, 10);

        }

        public Character()
        {
            UserName = infoGen.NextFullName();
            Health = infoGen.Next(10, 20);
            Damage = infoGen.Next(1, 5);
            strength = infoGen.Next(2, 10);
            
        }
        
        //public void Player(string username, int myhealth, int damage, int strength)
        //{
        //    this.UserName = username;
        //    this.Health = myhealth;
        //    this.strength = strength;
        //    this.Damage = damage;

        //} 
        //public void Player()
        //{
        //    UserName = infoGen.NextFullName();
        //    Health = infoGen.Next(10, 20);
        //    Damage = infoGen.Next(1, 5);
        //    strength = infoGen.Next(2, 10);
        //}

 

    }


}  
   

