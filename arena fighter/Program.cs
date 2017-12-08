using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_fighter
{
    class Program
    {
        public static bool menu;




        static void Main(string[] args)
        {
            Menu();
            

        }

        //meny
        //1. setup for fights
        //2. exit
        private static void Menu()
        {


            //get =>  Menu;
            // set => menu && NewGame;



            //GameMenu start&exit;


            //int NewGame = 1;
            //int ExitGame = 0;
            int Menu = -1;

            //double Startgame = 0;
            while(Menu != 0 && Menu != 1)
            {
                Console.WriteLine("Press 1 for NewGame to start fightning ");
                Console.WriteLine("press 0 to exit if you had enough beating for now :");
                int.TryParse(Console.ReadLine(), out Menu);

            }

            if (Menu == 1)
            {
                NewGame();
            }
            else if(Menu == 0)
            {
                ExitGame();
                
            }





                Console.ReadKey();
            //}






        }


        private static void NewGame()
        {
            //me
            Console.Write("choose your name: ");
            string name = Console.ReadLine();
            Character player = new Character(name);


            //enemy
            Character opponent = new Character();
            
            // me
            Console.WriteLine(player.UserName);
            Console.WriteLine("player health:" + player.Health);
            Console.WriteLine("player damage:" + player.Damage);
            Console.WriteLine("player strength:"+ player.strength);

            //enemy
            Console.WriteLine(opponent.UserName);
            Console.WriteLine("opponent health:" + opponent.Health);
            Console.WriteLine("opponent damage:" + opponent.Damage);
            Console.WriteLine("opponent strength:" + opponent.strength);
        }
        private static void ExitGame()
        {
            Console.WriteLine("i hope you enjoyed this fighting game! cya next time :)");
        }

    }
   
}







// 1. player
// 2. enemy
//3.dice fight
// gamemeny