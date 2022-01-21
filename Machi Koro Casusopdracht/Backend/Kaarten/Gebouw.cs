using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    abstract public class Gebouw : Kaart
    {
        public Gebouw(string _naam, int _prijs, Iconen _icoon, List<int> _rolwaarden, int _betrokkenMunten) : base(_naam, _prijs, _icoon)
        {
            Rolwaarden = _rolwaarden;
            BetrokkenMunten = _betrokkenMunten;
        }
        public List<int> Rolwaarden { get; set; }
        public int BetrokkenMunten { get; set; }

        public override abstract void DoeEffect(Spel _spel);
    }
}
