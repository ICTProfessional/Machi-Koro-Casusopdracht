using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    // Door: Job
    public class AI : Speler
    {
        public AI(string _naam) : base(_naam)
        {
            Naam = _naam;
        }

        internal Kaart CalculeerKaartKopen(List<Kaart> _kaartenPot, bool heeftPrijsNodig)
        {
            Random random = new Random();
            for (int i = 0; i < 1500; i++)
            {
                int randNumber = random.Next(0, _kaartenPot.Count);
                if (_kaartenPot[randNumber].Prijs < Geld || !heeftPrijsNodig)
                {
                    if (_kaartenPot[randNumber] is Bezienswaardigheid)
                    {
                        Bezienswaardigheid kaart = (Bezienswaardigheid)_kaartenPot[randNumber];
                        if (!kaart.IsActief)
                        {
                            return _kaartenPot[randNumber];
                        }
                    }
                    else
                    {
                        return _kaartenPot[randNumber];
                    }
                }
            }
            return null;
        }

        public Speler CalculeerSpelerKiezen(List<Speler> _spelers)
        {
            Random random = new Random();
            int randNumber = random.Next(0, _spelers.Count - 1);
            return _spelers[randNumber];
        }
    }
}
