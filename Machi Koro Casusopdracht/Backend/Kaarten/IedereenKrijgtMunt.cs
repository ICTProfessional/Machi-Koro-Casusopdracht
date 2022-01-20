using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class IedereenKrijgtMunt : Gebouw
    {
        public override void DoeEffect(Spel _spel)
        {
            
           _spel.GetEigenaarKaart(this).Geld += BetrokkenMunten;

        }

    }
}
