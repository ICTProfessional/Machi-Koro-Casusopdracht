using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Speler
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
            /*Bezienswaardigheden.Clear();*/
            Gebouwen.Clear();
            Gebouwen.Add("Graanveld");
        }
        /// <summary>
        /// Checkt of een speler een winkelcentrum heeft
        /// </summary>
        public bool HeeftWinkelCentrum()
        {
            
            foreach (var bezienswaardigheidkaart in Bezienswaardigheden)
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
            foreach (var bezienswaardigheidkaart in Bezienswaardigheden)
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
            foreach (var bezienswaardigheidkaart in Bezienswaardigheden)
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
            foreach (var bezienswaardigheidkaart in Bezienswaardigheden)
            {
                if (bezienswaardigheidkaart.Naam.ToLower() == "radiotoren")
                {
                    return bezienswaardigheidkaart.IsActief;
                }
            }
            return false;
        }



    }
}
