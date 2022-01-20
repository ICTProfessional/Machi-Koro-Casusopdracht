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
        public int AantalToernooiWins { get; set; }
        public List<Kaart> Gebouwen { get; set; }
        public List<Kaart> Bezienswaardigheden { get; set; }

        public Speler(string _naam)
        {
            Naam = _naam;
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
            IedereenKrijgtMunt graanVeld = new IedereenKrijgtMunt("Graanveld", 1, Iconen.Graan, new List<int> { 1 }, 1);
            RollerKrijgtMunt bakkerij = new RollerKrijgtMunt("Bakkerij", 1, Iconen.Winkel, new List<int> { 2, 3 }, 1);
            Gebouwen.Add(graanVeld);
            Gebouwen.Add(bakkerij);
        }
        /// <summary>
        /// Checkt of een speler een winkelcentrum heeft
        /// </summary>
        public bool HeeftWinkelCentrum()
        {
            
            foreach (Bezienswaardigheid bezienswaardigheidkaart in Bezienswaardigheden)
            {
                if (bezienswaardigheidkaart.Naam.ToLower() == "winkelcentrum")
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
                if (bezienswaardigheidkaart.Naam.ToLower() == "station")
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
                if (bezienswaardigheidkaart.Naam.ToLower() == "pretpark")
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
                if (bezienswaardigheidkaart.Naam.ToLower() == "radiotoren")
                {
                    return bezienswaardigheidkaart.IsActief;
                }
            }
            return false;
        }

        public virtual void CalculeerKaartenKopen(List<Kaart> _kaartenPot)
        {

        }

        public abstract void CalculeerSpelerKiezen(List<Speler> _spelers);
        

    }
}
