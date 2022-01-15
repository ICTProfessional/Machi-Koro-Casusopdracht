using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Gebouw : Kaart
    {
        public List<int> Rolwaarden { get; set; }
        public override int BetrokkenMunten { get; set; }
    }
}
