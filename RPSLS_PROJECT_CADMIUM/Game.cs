using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_PROJECT_CADMIUM
{
    class Game
    {
        //member variable (Has A)
        Player Player1;
        Player Player2;
        int NumPlayers;

        //constructor (Build This)
        public Game()
        {

        }


        //member methods (Can Do)
        public void GameSetup()
        {
            Console.WriteLine("HOW MANY PLAYERS? ENTER '1' FOR 'HUMAN VS COM' OR ENTER '2' FOR 'HUMAN VS HUMAN'");
            NumPlayers = parse.int(Console.ReadLine());
            switch (NumPlayers) {
                case: 1;
                    Player1 = new Human();
                    Player2 = new Computer();
                    Console.WriteLine("ENTER PLAYER NAME");
                    Player1.name = (Console.ReadLine());
                    Player2.name = "COMPUTER";
                    break;
                case: 2;
                    Player1 = new Human();
                    Player2 = new Human();
                    Console.WriteLine("ENTER PLAYER 1 NAME");
                    Player1.name = (Console.ReadLine());
                    Console.WriteLine("ENTER PLAYER 2 NAME");
                    Player2.name = (Console.ReadLine());
                    break;
                default;
                    GameSetup();
                    break;
            }


        }
        public void PlayGame()
        {
            Player1.
        }
        {
            

        }

    }
}
