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
            Random hand = new Random();
            int choice = hand.Next(0,3);
            // TODO [2]: Kies op basis van dit random getal 1 van de mogelijke handen (rock, paper, scissors)
            if(choice == 0)
            {
                string keuze = ("rock");
                return keuze;
            }
            else if(choice == 1)
            {
                string keuze = ("paper");
                return keuze;
            }
            else if(choice == 2)
            {
                string keuze = ("scissors");
                return keuze;
            }
                    
            
            // TODO [3]: Return het resultaat als string




            return "";
        }

        public bool IsValidHand(string playerHand)
        {
            // TODO [4]: Controleer of playerHand een geldige hand bevat (rock, paper of scissors)


           if(playerHand == "rock" || playerHand == "paper" || playerHand == "scissors")
            {
                return true;
            }
           else
            {
                return false;
            }


            
        }

        public bool DidPlayerWin(string playerHand, string computerHand)
        {
            // Je mag er hier vanuit gaan dat zowel playerHand als computerHand een geldige waarde bevatten !

            // TODO [5]: Indien beide handen gelijk zijn, dien je 'false' te returnen
            if(playerHand == computerHand)
            {
                return false;
            }


            // TODO [6]: Als de hand van de speler sterker is, return je 'true', anders 'false'
            else if (playerHand == "rock" && computerHand == "paper")
            {
                return false;
            }
            else if (playerHand == "rock" && computerHand == "scissors")
            {
                return true;
            }
            else if (playerHand == "scissors" && computerHand == "paper")
            {
                return true;
            }
           else if (playerHand == "scissors" && computerHand == "rock")
            {
                return false;
            }
            else if (playerHand == "paper" && computerHand == "rock")
            {
                return true;
            }
            else if (playerHand == "paper" && computerHand == "scissors")
            {
                return false;
            }
            else
            {
                return false;
            }





            
        }
    }
}
