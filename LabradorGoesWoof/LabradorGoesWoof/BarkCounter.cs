using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabradorGoesWoof
{
    public class BarkCounter
    {
        public int CountBarks(string input)
        {
            // De methode CountBarks() telt hoe dikwijls een hond heeft geblaft in een uur.
            //
            // @input = string die een geluidsmeting voorstelt over een tijdspanne van 60 minuten. Elke minuut wordt voorgesteld door een
            // karakter 'x' of een karakter 'B'. Een 'x' betekend dat de hond niet heeft geblaft, terwijl het karakter 'B' voorstelt dat de
            // hond wel heeft geblaft.
            //
            // Voorbeeld: 
            //      "xxBxxBxxxxBxxxxxxBBBxxxxxBxxBxxxxBBxxxxxBxxxxxxBxxxxxxBxxxxB"
            //
            // Resultaat: 14

            // TODO [1]: Overloop de `input` string en tel hoe dikwijls je een `B` karakter tegen komt
            


            // TODO [2]: Laat de methode het resultaat returnen(aantal keer dat er `B` in `input` voorkomt)

            // TODO [3]: Uitzondering - Indien de string niet bestaat uit `60` karakters dien je `-1` terug te geven om aan te geven dat het fout liep.


            if (input.Length < 60)
            {
                return -1;
            }
            else if (input.Length == 60)
            {
                //int barkindex = input.IndexOf('B');

                //int silinceindex = input.IndexOf('x');

                //int bark = (silinceindex + barkindex);

                //return bark;
                int bark = 0;
                for(int i = 0; i < input.Length; i++)
                {
                    if(input[i] == 'B')
                    {
                        bark = bark + 1;
                    }
                }
                return bark;
            }
            
            
            


                //return (Convert.ToInt32(output));
                
                
            else if (input.Length > 60)
                {
                 return -1;
                }
            
            






            return 0;
        }
    }
}
