using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    public class Speler
    {
        public string Naam { get; set; }
        public int Geld { get; set; }
        public List<Kaart> Gebouwen { get; set; } = new List<Kaart>();
        public List<Kaart> Bezienswaardigheden { get; set; } = new List<Kaart>();

        public Speler(string _naam)
        {
            Naam = _naam;

            Bezienswaardigheden.Add(new Bezienswaardigheid("Viva la Vida", 4, Iconen.Leeuw)); // 4
            Bezienswaardigheden.Add(new Bezienswaardigheid("Continium", 10, Iconen.Leeuw)); // 10
            Bezienswaardigheden.Add(new Bezienswaardigheid("Drielandenpunt", 16, Iconen.Leeuw)); // 16
            Bezienswaardigheden.Add(new Bezienswaardigheid("Roda JC Stadion", 22, Iconen.Leeuw)); // 22
            ResetStats();
        }

        /*
        public void KaartKopen(Kaart _kaart)
        {
            
        } */

        public void ResetStats()
        {
            Geld = 3;
            foreach (Bezienswaardigheid bezienswaardigheidskaart in Bezienswaardigheden)
            {
                bezienswaardigheidskaart.IsActief = false;
            }
            Gebouwen.Clear();
            Gebouwen.Add(new IedereenKrijgtMunt("Frituur", 1, Iconen.Worst, new List<int> { 1 }, 1));
            Gebouwen.Add(new RollerKrijgtMunt("Mosaqua", 1, Iconen.Vis, new List<int> { 2, 3 }, 1, null));
        }
        /// <summary>
        /// Checkt of een speler een winkelcentrum heeft
        /// </summary>
        public bool HeeftWinkelCentrum()
        {
            
            foreach (Bezienswaardigheid bezienswaardigheidkaart in Bezienswaardigheden)
            {
                if (bezienswaardigheidkaart.Naam.ToLower() == "continium")
                {
                    return bezienswaardigheidkaart.IsActief;
                }
            }
            return false;
        }
        /// <summary>
        /// Checkt of de speler een Station heeft.
        /// </summary>
        public bool HeeftStation()
        {
            foreach (Bezienswaardigheid bezienswaardigheidkaart in Bezienswaardigheden)
            {
                if (bezienswaardigheidkaart.Naam.ToLower() == "viva la vida")
                {
                    return bezienswaardigheidkaart.IsActief;
                }
            }
            return false;
        }

        /// <summary>
        /// Checkt of een speler een pretpark heeft
        /// </summary>
        public bool HeeftPretpark()
        {
            foreach (Bezienswaardigheid bezienswaardigheidkaart in Bezienswaardigheden)
            {
                if (bezienswaardigheidkaart.Naam.ToLower() == "drielandenpunt")
                {
                    return bezienswaardigheidkaart.IsActief;
                }
            }
            return false;
        }

        /// <summary>
        /// Checkt of een spelere een radiotoren
        /// </summary>
        public bool HeeftRadioToren()
        {
            foreach (Bezienswaardigheid bezienswaardigheidkaart in Bezienswaardigheden)
            {
                if (bezienswaardigheidkaart.Naam.ToLower() == "roda jc stadion")
                {
                    return bezienswaardigheidkaart.IsActief;
                }
            }
            return false;
        }
    }
}
