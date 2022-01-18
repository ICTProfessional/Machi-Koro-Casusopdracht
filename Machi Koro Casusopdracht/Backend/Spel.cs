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
            HuidigeSpelerIndex ++;
            if(HuidigeSpelerIndex > Spelers.Count - 1)
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
                IedereenKrijgtMunt graanveld = new IedereenKrijgtMunt();
                IedereenKrijgtMunt appelboomgaard = new IedereenKrijgtMunt();
                IedereenKrijgtMunt veehouderij = new IedereenKrijgtMunt();
                IedereenKrijgtMunt mijn = new IedereenKrijgtMunt();
                IedereenKrijgtMunt bos = new IedereenKrijgtMunt();

                RollerKrijgtMunt bakkerij = new RollerKrijgtMunt();
                RollerKrijgtMunt supermarkt = new RollerKrijgtMunt();
                RollerKrijgtMunt Kaasfabriek = new RollerKrijgtMunt();
                RollerKrijgtMunt meubelfabriek = new RollerKrijgtMunt();
                RollerKrijgtMunt groentenEnFruitmarkt = new RollerKrijgtMunt();

                NeemMuntSpeler café = new NeemMuntSpeler();
                NeemMuntSpeler restaurant = new NeemMuntSpeler();

                KaartenPot.add(graanveld,appelboomgaard,veehouderij,mijn,bos,bakkerij,supermarkt,Kaasfabriek,meubelfabriek,groentenEnFruitmarkt,café,restaurant);
            }
            for (int i = 0; i < 3; i++)
			{
                WisselKaartKiezen bedrijfsComplex = new WisselKaartKiezen();
                NeemMuntIedereen stadion = new NeemMuntIedereen();
                NeemMuntKiezen tvStation = new NeemMuntKiezen();
                KaartenPot.add(bedrijfsComplex, stadion, tvStation);
			}
        }
        public void WisselKaarten(Kaart _kaart1, Kaart _kaart2)
        {
            
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
                        if(_speler == GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                        break;
                    case "RollerKrijgtMunt":
                        if(_speler != GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                    case "WisselKaartKiezen":
                        if(_speler != GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                    case "NeemMuntIedereen":
                        if(_speler != GetHuidigeSpeler())
                        {
                            actieveKaarten.Remove(_kaart);
                        }
                    case "NeemMuntKiezen":
                        if(_speler != GetHuidigeSpeler())
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
                if(!_kaart.Rolwaarden.Contains(RolSysteem.GetDobbelWaarde()))
                {
                    actieveKaarten.Remove(_kaart);
                }
            }
            return actieveKaarten;
        }

        public void NeemMuntKiezenEffect(Speler _gekozenSpeler)
        {

        }
    }
}
