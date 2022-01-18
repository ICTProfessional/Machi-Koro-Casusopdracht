using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class AI : Speler
    {
        public Kaart CalculeerKaartKopen(List<Kaart> _kaartenPot)
        {
            Random random = new Random();
            int randNumber = random.Next(0, _kaartenPot.Count - 1);
            return _kaartenPot[randNumber];
        }

        public Speler CalculeerSpelerKiezen(List<Speler> _spelers)
        {
            Random random = new Random();
            int randNumber = random.Next(0, _spelers.Count - 1);
            return _spelers[randNumber];
        }
    }
}
