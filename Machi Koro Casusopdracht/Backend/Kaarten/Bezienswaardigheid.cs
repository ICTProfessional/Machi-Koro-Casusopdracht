using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Bezienswaardigheid : Kaart
    {
        public Bezienswaardigheid(string _naam, int _prijs, Iconen _icoon) : base(_naam, _prijs, _icoon)
        {

        }
        public bool IsActief { get; set; }
    }
}
