using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Challenge_Library;

namespace Week4Challenges_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            XBoxGame xBoxGame = new XBoxGame(false, "Tomb Raider", "T", "Adventure");

            //XBoxGame xBox = new XBoxGame();
            //xBox. = "Tomb Raider";
            //xBox.GameType = "Adventure";
            //xBox.MaturityRating = "T";
            //xBox.WorksWithKinect = false;
            string output = xBoxGame.PrePlayed();
            Console.WriteLine(output);
            Console.ReadKey();

            PS5Game pS5Game = new PS5Game(true, "Star Wars", "E10+", "Action");
           
            //pS5Game.GameName = "Star Wars";
            //pS5Game.GameType = "Action";
            //pS5Game.MaturityRating = "E10+";
            //pS5Game.BackwardsCompatiblePS4 = true;
            string output2 = pS5Game.PrePlayed();
            Console.WriteLine(output2);
            Console.ReadKey();
        }
    }
}




