using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class RollerKrijgtMunt : Gebouw 
    {
        public RollerKrijgtMunt(string _naam, int _prijs, Iconen _icoon, List<int> _rolwaarden, int _betrokkenMunten, Iconen ?_betrokkenIcoon) : base(_naam, _prijs, _icoon, _rolwaarden, _betrokkenMunten)
        {

            BetrokkenIcoon = _betrokkenIcoon;
        }
        // Geeft een aantal munten aan de speler als hij aan de beurt is
        public Iconen ?BetrokkenIcoon { get; set; }

        public override void DoeEffect(Spel _spel)
        {
            // Geeft een extra muntje voor het winkelcentrum
            if (_spel.GetHuidigeSpeler().HeeftWinkelCentrum())
            {
                BetrokkenMunten++;
            }
            // Geeft eenmalig geld aan de speler als er geen icoon bij betrokken is
            if (BetrokkenIcoon == null)
            {
                _spel.GetHuidigeSpeler().Geld += BetrokkenMunten;
            }
            else
            {
                // Controlleert hoeveel keer de speler een bepaald icoon heeft
                int AantalVanIcoon = 0;
                foreach (Kaart _kaart in _spel.GetHuidigeSpeler().Gebouwen)
                {
                    if (_kaart.Icoon == BetrokkenIcoon)
                    {
                        AantalVanIcoon++;
                    }
                }
            }
        }
    }
}
