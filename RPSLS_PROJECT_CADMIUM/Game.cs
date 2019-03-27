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
        Player COM;
        string NumPlayers;

        //constructor (Build This)
        public Game()
        {

        }


        //member methods (Can Do)
        public void StartGame()
        {
            Console.WriteLine("ENTER '1' FOR 'HUMAN VS COM' OR ENTER '2' FOR 'HUMAN VS HUMAN'");
            NumPlayers = Console.ReadLine();
            switch (NumPlayers) {
                case: "1";
                    Console.WriteLine("ENTER PLAYER NAME");


                    break;
                case: "2";

                    break;
                default;
            }


        }

    }
}
