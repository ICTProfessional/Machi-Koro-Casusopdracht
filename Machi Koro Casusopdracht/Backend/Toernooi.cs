using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    public class Toernooi
    {

        private Random random = new Random();
        public List<Speler> BeschikbareSpelers { get; set; } = new List<Speler>();
        public List<List<Speler>> SpelerGroepen { get; set; } = new List<List<Speler>>();
        public Spel HuidigSpel { get; set; }

        public void VervangSpel(List<Speler> _spelers)
        {         
            HuidigSpel = new Spel();
            HuidigSpel.Spelers = BeschikbareSpelers;
        }
            
        public void SplitSpelers(List<Speler> _spelers)
        {
            if (_spelers.Count % 2 != 0)
            {
                AI nieuweAI = new AI("Robot#" + random.Next(1,1000000).ToString());
                _spelers.Add(nieuweAI);
            }
            SpelerGroepen = new List<List<Speler>>();
            _spelers = _spelers.ToList();
            int aantalSpelers = _spelers.Count;
            for (int i = 0; i < aantalSpelers / 2; i++)
            {
                {
                    List<Speler> groepje = new List<Speler>();
                    groepje.Add(_spelers[0]);
                    groepje.Add(_spelers[1]);
                    SpelerGroepen.Add(groepje);
                    for (int i2 = 0; i2 < 2; i2++)
                    {
                        _spelers.Remove(_spelers[0]);
                    }

                }
            }
        }  
    }
}
