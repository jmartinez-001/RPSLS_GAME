using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_PROJECT_CADMIUM
{
    class Human : Player
    {
        //member variable (Has A)


        //constructor
        public Human()
        {

        }


        //member methods (Can Do)
        public override void PickGesture()
        {
            Console.WriteLine("Choose Gesture");
            gesture = Console.ReadLine();

        }


    }
}
