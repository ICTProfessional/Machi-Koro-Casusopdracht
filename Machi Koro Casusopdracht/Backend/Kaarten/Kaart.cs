using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    abstract class Kaart
    {
        public Kaart(string _naam, int _prijs, int _icoon)
        {
            Naam = _naam;
            Prijs = _prijs;
            Icoon = _icoon;
        }
        public int Prijs { get; set; }
        public string Naam { get; set; }
        public int Icoon { get; set; }
        abstract public int BetrokkenMunten { get; set; };
        abstract public bool IsActief { get; set; }

        abstract public void DoeEffect(Spel _spel);
    }
}
