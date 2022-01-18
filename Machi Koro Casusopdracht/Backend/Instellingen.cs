using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    internal class Instellingen
    {
        public List<Speler> BeschikbareSpelers { get; set; }

        public void VerwijderSpeler(string _naam)
        {
            foreach (Speler _speler in BeschikbareSpelers)
            {
                if (_speler.Naam == _naam)
                {
                    BeschikbareSpelers.Remove(_speler);
                    return;
                }
            }
        }

        public void VoegSelerToe(string _naam)
        {
            {
                Speler speler = new Speler();
                speler.Naam = _naam;
                BeschikbareSpelers.Add(speler);
            }
        }
    }
}
