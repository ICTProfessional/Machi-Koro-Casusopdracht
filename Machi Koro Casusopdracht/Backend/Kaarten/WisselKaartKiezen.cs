using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class WisselKaartKiezen : Gebouw 
    {
        public WisselKaartKiezen(string _naam, int _prijs, Iconen _icoon, List<int> _rolwaarden, int _betrokkenMunten) : base(_naam, _prijs, _icoon, _rolwaarden, _betrokkenMunten)
        {

        }
        public override void DoeEffect(Spel _spel)
        {
            // Vraagt aan houder kaart welke speler hij kiest
            
            // Vraagt aan houder kaart welke kaart hij kiest

            // Vraagt aan houder kaart welke kaart hij ervoor wilt ruilen
        }
    }
}
