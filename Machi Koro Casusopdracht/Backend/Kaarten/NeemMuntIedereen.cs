using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class NeemMuntIedereen : Gebouw
    {
        public NeemMuntIedereen(string _naam, int _prijs, Iconen _icoon, List<int> _rolwaarden, int _betrokkenMunten) : base(_naam, _prijs, _icoon, _rolwaarden, _betrokkenMunten)
        {

        }

        // Neemt een aantal munten van alle spelers behalve degene die deze kaart bezit
        public override void DoeEffect(Spel _spel)
        {
            Speler kaartEigenaar = null;
            // Eerst kijkt de kaart wie de eigenaar is
            foreach (Speler _speler in _spel.Spelers)
            {
                if (_speler.Gebouwen.Contains(this))
                {
                    kaartEigenaar = _speler;
                }
            }
            // De kaart gaat van elke speler die niet de eigenaar is munten eraf halen en geven aan de eigenaar
            foreach (Speler _speler in _spel.Spelers)
            {
                if (_speler != kaartEigenaar)
                {
                    kaartEigenaar.Geld += _speler.Geld;
                    if (_speler.Geld < BetrokkenMunten)
                    {
                        _speler.Geld = 0;
                    }
                    else
                    {
                        _speler.Geld -= 4;
                    }
                }
            }

        }
    }
}
