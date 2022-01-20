using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Toernooi
    {
        public List<Speler> BeschikbareSpelers { get; set; }
        public List<List<Speler>> SpelerGroepen { get; set; }
        public Spel HuidigSpel { get; set; }
    }
}
