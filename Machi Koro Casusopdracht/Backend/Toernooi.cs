using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Toernooi
    {
               
        public List<Speler> BeschikbareSpelers { get; set; }
        public List<List<Speler>> SpelerGroepen { get; set; }
        public Spel HuidigSpel { get; set; }

        public void VervangSpel(List<Speler> _spelers)
        {         
            HuidigSpel = new Spel();
            HuidigSpel.Spelers = BeschikbareSpelers;
        }
            
        public void SplitSpelers(List<Speler> _spelers)
        {
            if(_spelers.Count % 2 != 0)
            {
                _spelers.Add(new AI("Jacques"));
            }
            for (int i = 0; i < _spelers.Count / 2; i++)
            {
                {
                    List<Speler> groepje = new List<Speler>();
                    groepje.Add(_spelers[0]);
                    groepje.Add(_spelers[1]);
                    SpelerGroepen.Add(groepje);
                    _spelers.Remove(_spelers[0]);
                    _spelers.Remove(_spelers[1]);

                }
            }
        }  
    }
}
