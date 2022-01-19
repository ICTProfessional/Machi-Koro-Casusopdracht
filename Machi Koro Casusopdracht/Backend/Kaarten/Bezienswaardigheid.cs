using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Bezienswaardigheid : Kaart
    {
        public override bool IsActief { get; set; }
        public override int BetrokkenMunten { get; set; }
        public override void DoeEffect(Spel _spel)
        {
            return;
        }
    }
}
