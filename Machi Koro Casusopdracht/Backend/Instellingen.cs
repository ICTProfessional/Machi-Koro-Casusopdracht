using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    internal class Instellingen
    {

        // Constructor voor de test
        public Instellingen()
        {
            for (int i = 0; i < 5; i++)
            {
                VoegAIToe("Jan" + i.ToString());
            }
        }
        public List<Speler> BeschikbareSpelers { get; set; } = new List<Speler>();

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

        public void VoegSpelerToe(string _naam)
        {
            {
                Speler speler = new Speler(_naam);
                BeschikbareSpelers.Add(speler);
            }
        }

        public void VoegAIToe(string _naam)
        {
            {
                AI speler = new AI(_naam);
                BeschikbareSpelers.Add(speler);
            }
        }
    }
}
