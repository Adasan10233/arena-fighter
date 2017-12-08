using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_fighter
{
    class Round
    {

        static Random rng = new Random();

          int Result;
        public static bool menu;


        public Round (Character player, Character opponent )

        {
            while( player.Health > 0 && opponent.Health > 0)
            {
                int dicePlayer = rng.Next(1, 6);
                int diceOpponent = rng.Next(1, 6);

                int damagePlayermade = rng.Next(1, 5);
                int damageOpponentmade = rng.Next(1, 5);

                //Console.Write()
                Console.WriteLine("damage made on opponent" + damagePlayermade);
                Console.WriteLine("opponents damage on you:" + damageOpponentmade);


                if(player.Health !=0)
                {
                    
                    Console.WriteLine("you died:( wanna fight another?");
                    int.TryParse (Console.ReadLine(),out Result); 

                }
                else if(opponent.Health !=0)
                {
                    Console.Write("want mr.jingles to find a new opponent for you?");
                    int.TryParse(Console.ReadLine(), out Result);
                }
                
               
         
                
               
                
            }

           

        }



    }

}
