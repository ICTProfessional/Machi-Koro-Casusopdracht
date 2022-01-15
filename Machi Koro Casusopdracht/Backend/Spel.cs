using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Spel
    {
        public List<Speler> Spelers { get; set; }
        public int HuidigeSpelerIndex { get; set; }
        public List<Kaart> KaartenPot { get; set; }
        public RolSysteem RolSysteemObject { get; set; }
    }
}
