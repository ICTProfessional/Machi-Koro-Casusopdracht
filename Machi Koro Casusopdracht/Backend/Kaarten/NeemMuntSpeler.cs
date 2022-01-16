using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class NeemMuntSpeler : Gebouw
    {
        // Neemt een munt van de persoon die heeft gerolt en geeft het aan de eigenaar van de kaart
        public override void DoeEffect(Spel _spel)
        {
            // Geeft een extra muntje als speler het winkelcentrum heeft gekocht
            if (_spel.GetHuidigeSpeler().HeeftWinkelCentrum())
            {
                BetrokkenMunten++;
            }
            // Een kale kip kan niet meer geplukt worden, toch? ;)
            if (_spel.GetHuidigeSpeler().Geld - BetrokkenMunten < 0)
            {
                BetrokkenMunten = _spel.GetHuidigeSpeler().Geld;
            }
            // Haalt munten weg van de huidige speler
            _spel.GetHuidigeSpeler().Geld -= BetrokkenMunten;
            foreach (Speler _speler in _spel.Spelers)
            {
                // Checkt welke speler deze kaart bezit en geeft de munten aan hem
                if (_speler.Gebouwen.Contains(this))
                {
                    _speler.Geld -= BetrokkenMunten;
                }
            }
        }
    }
}
