using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class IedereenKrijgtMunt : Gebouw
    {
        public IedereenKrijgtMunt(string _naam, int _prijs, Iconen _icoon, List<int> _rolwaarden, int _betrokkenMunten) : base(_naam, _prijs, _icoon, _rolwaarden, _betrokkenMunten)
        {

        }

        public override bool IsActief { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void DoeEffect(Spel _spel)
        {
            throw new NotImplementedException();
        }
    }
}
