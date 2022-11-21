using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        public string GenerateComputerHand()
        {
            // TODO [1]: Genereer een random getal tussen 0 en 2
            // TODO [2]: Kies op basis van dit random getal 1 van de mogelijke handen (rock, paper, scissors)
            // TODO [3]: Return het resultaat als string




            return "";
        }

        public bool IsValidHand(string playerHand)
        {
            // TODO [4]: Controleer of playerHand een geldige hand bevat (rock, paper of scissors)




            return true;
        }

        public bool DidPlayerWin(string playerHand, string computerHand)
        {
            // Je mag er hier vanuit gaan dat zowel playerHand als computerHand een geldige waarde bevatten !

            // TODO [5]: Indien beide handen gelijk zijn, dien je 'false' te returnen
            // TODO [6]: Als de hand van de speler sterker is, return je 'true', anders 'false'




            return false;
        }
    }
}
