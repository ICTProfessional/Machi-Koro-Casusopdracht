using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    abstract class Kaart
    {
        public int Prijs { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        /* afbeelding moet nog als file variabele*/
        public int Icoon { get; set; }
        abstract public int BetrokkenMunten { get; set; }
        abstract public bool IsActief { get; set; }

        abstract public void DoeEffect(Spel _spel);
    }
}
