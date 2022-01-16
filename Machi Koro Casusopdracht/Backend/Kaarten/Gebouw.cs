using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    abstract class Gebouw : Kaart
    {
        public List<int> Rolwaarden { get; set; }
        public override int BetrokkenMunten { get; set; }

        public override abstract void DoeEffect(Spel _spel);
    }
}
