using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMySetup
{
    public class RatingGenerator
    {
        public string Rate(int stars, int maximum, char symbol)
        {
            // De methode Rate() dient een string te bouwen die een rating (beoordeling) kan genereren volgens
            // onderstaand formaat:
            // - Voorbeeld output (beoordeling is hier 2/5): "<**___>"
            // - Methode call was hierbij: Rate(2, 5, '*')

            // - stars = het aantal "sterren" dat we geven
            // - maximum = het maximum aantal "sterren" dat er kan worden gegeven
            // - symbol = het symbool dat als "ster" dient gebruikt te worden

            // TODO [1]: Maak een string variabel waarin je het resultaat gaat plaatsen
            // TODO [2]: Bouw de string op volgens het opgegeven formaat (hint: maak gebruik van een loop-structuur)
            // TODO [3]: Geef de resulterende string terug (geen Console.WriteLine hier!)
            // TODO [4]: Uitzondering - Indien maximum 0 is of stars groter is dan maximum dien je als resultaat "<>" terug te geven

            return "";
        }
    }
}
