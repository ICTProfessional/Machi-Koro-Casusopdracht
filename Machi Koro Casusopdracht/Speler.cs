using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Speler
    {
        public string Naam { get; set; }
        public int Geld { get; set; }
        public int AantalToernooiWins { get; set; }
        public List<Kaart> Gebouwen { get; set; }
        public List<Kaart> Bezienswaardigheden { get; set; }
    }
}
