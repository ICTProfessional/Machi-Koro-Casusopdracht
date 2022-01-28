using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    public class Spel
    {
        public List<Speler> Spelers { get; set; } = new List<Speler>();
        public int HuidigeSpelerIndex { get; set; } = 0;
        public List<Kaart> KaartenPot { get; set; } = new List<Kaart>();
        public RolSysteem RolSysteemObject { get; set; } = new RolSysteem();

        public Spel()
        {
            VervangKaartenStapel();
        }
        /// Bepaalt huidige speler
        public Speler GetHuidigeSpeler()
        {
            return Spelers[HuidigeSpelerIndex];
        }
        /// Verandert huidige speler
        public void WisselBeurt()
        {
            HuidigeSpelerIndex++;
            if (HuidigeSpelerIndex > Spelers.Count - 1)
            {
                HuidigeSpelerIndex = 0;
            }
        }
        /// Vervangt de huidige kaartenstapel met een nieuwe kaartenstapel
        public void VervangKaartenStapel()
        {
            KaartenPot = new List<Kaart>();
            for (int i = 0; i < 6; i++)
            {
                //Naam, Prijs, Icoon,Rolwaarden, betrokken munten
                KaartenPot.Add(new IedereenKrijgtMunt("Frituur", 1, Iconen.Worst, new List<int> { 1 }, 1));
                KaartenPot.Add(new IedereenKrijgtMunt("Broodje Bufkes", 3, Iconen.Worst, new List<int> { 10 }, 3));
                KaartenPot.Add(new IedereenKrijgtMunt("GaiaZoo Speeltuin", 1, Iconen.Gaiazoo, new List<int> { 2 }, 1));
                KaartenPot.Add(new IedereenKrijgtMunt("Brand Bierbrouwerij", 6, Iconen.Fles, new List<int> { 9 }, 5));
                KaartenPot.Add(new IedereenKrijgtMunt("Parkstad Theater", 3, Iconen.Fles, new List<int> { 5 }, 1));

                KaartenPot.Add(new RollerKrijgtMunt("Mosaqua", 1, Iconen.Vis, new List<int> { 2, 3 }, 1, null));
                KaartenPot.Add(new RollerKrijgtMunt("D'r Pool", 2, Iconen.Vis, new List<int> { 4 }, 3, null));
                KaartenPot.Add(new RollerKrijgtMunt("Hof van Gaia", 5, Iconen.Anders, new List<int> { 7 }, 3, Iconen.Gaiazoo));
                KaartenPot.Add(new RollerKrijgtMunt("Event Design Parkstad", 3, Iconen.Anders, new List<int> { 8 }, 3, Iconen.Fles));
                KaartenPot.Add(new RollerKrijgtMunt("Stadscentrum", 2, Iconen.Anders, new List<int> { 11, 12 }, 2, Iconen.Worst));

                KaartenPot.Add(new NeemMuntSpeler("UMC Festival", 2, Iconen.Noot, new List<int> { 3 }, 1));
                KaartenPot.Add(new NeemMuntSpeler("Pinkpop Podium", 3, Iconen.Noot, new List<int> { 9, 10 }, 2));
            }
            for (int i = 0; i < 4; i++)
            {
                KaartenPot.Add(new WisselKaartKiezen("D'r Joep Standbeeld", 8, Iconen.Leeuw, new List<int> { 6 }, 0));
                KaartenPot.Add(new NeemMuntIedereen("L1 TV Station", 6, Iconen.Leeuw, new List<int> { 6 }, 2));
                KaartenPot.Add(new NeemMuntKiezen("Omroep Landgraaf", 7, Iconen.Leeuw, new List<int> { 6 }, 5));
            }
        }
        public void WisselKaarten(Kaart _kaart1, Kaart _kaart2)
        {
            Speler eigenaar1 = GetEigenaarKaart(_kaart1);
            Speler eigenaar2 = GetEigenaarKaart(_kaart2);

            eigenaar1.Gebouwen.Add(_kaart2);
            eigenaar2.Gebouwen.Add(_kaart1);
            eigenaar1.Gebouwen.Remove(_kaart1);
            eigenaar2.Gebouwen.Remove(_kaart2);
        }
        /// Geeft terug welke speler de eigenaar is van een kaart
        public Speler GetEigenaarKaart(Kaart _kaart)
        {
            foreach (Speler _speler in Spelers)
            {
                foreach (Kaart __kaart in _speler.Gebouwen)
                {
                    if (__kaart == _kaart)
                    {
                        return _speler;
                    }
                }
            }
            return null;
        }
        /// Haalt kaarten van spelers die een effect doen
        public List<Kaart> GetActieveKaartenVanSpeler(Speler _speler)
        {
            List<Kaart> actieveKaarten = _speler.Gebouwen.ToList();
            foreach (Kaart _kaart in actieveKaarten.ToList())
            {
                switch (_kaart.GetType().Name)
                {
                    case "NeemMuntSpeler":
                        if (_speler == GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                        break;
                    case "RollerKrijgtMunt":
                        if (_speler != GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                        break;
                    case "WisselKaartKiezen":
                        if (_speler != GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                        break;
                    case "NeemMuntIedereen":
                        if (_speler != GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                        break;
                    case "NeemMuntKiezen":
                        if (_speler != GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (Kaart _kaart in actieveKaarten.ToList())
            {
                Gebouw gb = (Gebouw)_kaart;
                if (!gb.Rolwaarden.Contains(RolSysteemObject.GetDobbelWaarde()))
                {
                   actieveKaarten.Remove(_kaart);
                }
            }
            return actieveKaarten;
        }
        public void NeemMuntKiezenEffect(Speler _gekozenSpeler, Speler _eigenaarKaart)
        {
            if (_gekozenSpeler.Geld >= 5)
            {
                _gekozenSpeler.Geld -= 5;
                _eigenaarKaart.Geld += 5;
            }
            else
            {
                int a = 5 - _gekozenSpeler.Geld;
                _gekozenSpeler.Geld = 0;
                _eigenaarKaart.Geld += a;
            }
        }
        public bool KaartKopen(string _naam)
        {
            Kaart geselecteerdeKaart = null;
            foreach (Kaart _kaart in KaartenPot)
            {
                if (_kaart.Naam == _naam)
                {
                    geselecteerdeKaart = _kaart;
                    break;
                }
            }
            foreach (Bezienswaardigheid bezienswaardigheid in GetHuidigeSpeler().Bezienswaardigheden)
            {
                if (bezienswaardigheid.Naam == _naam)
                {
                    geselecteerdeKaart = bezienswaardigheid;
                    break;
                }
            }
            if (geselecteerdeKaart == null)
            {
                return false;
            }
            if (geselecteerdeKaart.Prijs > GetHuidigeSpeler().Geld)
            {
                return false;
            }

            if (geselecteerdeKaart is Gebouw)
            {
                GetHuidigeSpeler().Gebouwen.Add(geselecteerdeKaart);
                KaartenPot.Remove(geselecteerdeKaart);
            }
            else if (geselecteerdeKaart is Bezienswaardigheid)
            {
                Bezienswaardigheid geselecteerdeBezienswaardigheid = (Bezienswaardigheid)geselecteerdeKaart;
                if (geselecteerdeBezienswaardigheid.IsActief)
                {
                    return false;
                }
                geselecteerdeBezienswaardigheid.IsActief = true;
            }
            GetHuidigeSpeler().Geld -= geselecteerdeKaart.Prijs;
            return true;
        }
    }
}
