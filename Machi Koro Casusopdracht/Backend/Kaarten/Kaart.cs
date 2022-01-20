using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    abstract public class Kaart
    {
        public Kaart(string _naam, int _prijs, Iconen _icoon)
        {
            Naam = _naam;
            Prijs = _prijs;
            Icoon = _icoon;
        }
        public int Prijs { get; set; }
        public string Naam { get; set; }
        public Iconen Icoon { get; set; }

        abstract public void DoeEffect(Spel _spel);
    }
}
