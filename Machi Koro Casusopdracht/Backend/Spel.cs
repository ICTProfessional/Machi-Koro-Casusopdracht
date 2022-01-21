using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    class Spel
    {
        public List<Speler> Spelers { get; set; }
        public int HuidigeSpelerIndex { get; set; } = 0;
        public List<Kaart> KaartenPot { get; set; }
        public RolSysteem RolSysteemObject { get; set; }

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
                KaartenPot.Add(new IedereenKrijgtMunt("Graanveld", 1, Iconen.Graan, new List<int> { 1 }, 1));
                KaartenPot.Add(new IedereenKrijgtMunt("Appelboomgaard", ));
                KaartenPot.Add(new IedereenKrijgtMunt("Veehouderij", 1, Iconen.Koe, new List<int> { 1 }, 1));
                KaartenPot.Add(new IedereenKrijgtMunt("Mijn"));
                KaartenPot.Add(new IedereenKrijgtMunt("Bos"));

                KaartenPot.Add(new RollerKrijgtMunt("Bakkerij", 1, Iconen.Winkel, new List<int> { 2, 3 }, 1));
                KaartenPot.Add(new RollerKrijgtMunt("Supermarkt", 2, Iconen.Winkel, new List<int> { 4 }, 3));
                KaartenPot.Add(new RollerKrijgtMunt("Kaasfabriek", 5, Iconen.Fabriek, new List<int> { 7 }, 0)); //NOG AANPASSEN
                KaartenPot.Add(new RollerKrijgtMunt("Meubelfabriek", 3, Iconen.Fabriek, new List<int> { 8 }, 0)); // NOG AANPASSEN
                KaartenPot.Add(new RollerKrijgtMunt("Groenten en Fruitmarkt", 2, Iconen./*NOG AANPASSEN*/, new List<int> { 11, 12 }, 0)); //NOG AANPASSEN

                KaartenPot.Add(new NeemMuntSpeler("Café", 2, Iconen.Mok, new List<int> { 3 }, 1));
                KaartenPot.Add(new NeemMuntSpeler("Restaurant", 3, Iconen.Mok, new List<int> { 9, 10 }, 2));
            }
            for (int i = 0; i < 3; i++)
            {
                KaartenPot.Add(new WisselKaartKiezen("Bedrijfs Complex", 8, Iconen./*NOG AANPASSEN*/, new List<int> { 6 }, 0));
                KaartenPot.Add(new NeemMuntIedereen("Stadion", 6, Iconen./*NOG AANPASSEN*/, new List<int> { 6 }, 2));
                KaartenPot.Add(new NeemMuntKiezen("TV Station", 7, Iconen./*NOG AANPASSEN*/, new List<int> { 6 }, 5));
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
            List<Kaart> actieveKaarten = _speler.Gebouwen;
            List<Kaart> kaartClone = actieveKaarten;
            foreach (Kaart _kaart in kaartClone)
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
            kaartClone = actieveKaarten;
            foreach (Kaart _kaart in kaartClone)
            {
                if (_kaart.Equals(typeof(Gebouw))) {
                    Gebouw gb = (Gebouw)_kaart;
                    if (!gb.Rolwaarden.Contains(RolSysteem.GetDobbelWaarde()))
                    {
                        actieveKaarten.Remove(_kaart);
                    }
                }
                if (!_kaart.Rolwaarden.Contains(RolSysteem.GetDobbelWaarde()))
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
                int a = _gekozenSpeler.Geld;
                _gekozenSpeler.Geld = 0;
                _eigenaarKaart.Geld += a;
            }
        }
        public void KaartKopen(Kaart _kaart)
        {
            GetHuidigeSpeler().Gebouwen.Add(_kaart);
            KaartenPot.Remove(_kaart);
        }
    }
}
