using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machi_Koro_Casusopdracht
{
    public partial class Spelscherm : Form
    {
        public Spel HuidigSpel;
        public Spelscherm(List<Speler> _meespelers, bool _isToernooiSpel)
        {
            InitializeComponent();
            HuidigSpel = new Spel();
            HuidigSpel.Spelers = _meespelers;
            BeurtBegin();
        }

        private void Dobbel()
        {
            HuidigSpel.RolSysteemObject.RolWaarden();
            switch (HuidigSpel.RolSysteemObject.TweeStenen)
            {
                case true:
                    VoegEventToe(String.Format("{0} heeft een {1} en een {2} gerold! Totaal: {3}.", HuidigSpel.GetHuidigeSpeler().Naam, HuidigSpel.RolSysteemObject.DobbelsteenWaarde1, HuidigSpel.RolSysteemObject.DobbelsteenWaarde2, HuidigSpel.RolSysteemObject.GetDobbelWaarde().ToString()));
                    break;
                case false:
                    VoegEventToe(String.Format("{0} heeft een {1} gerold!", HuidigSpel.GetHuidigeSpeler().Naam, HuidigSpel.RolSysteemObject.GetDobbelWaarde().ToString()));
                    break;

            }
        }

        private string GetHuidigeSpelerNaam()
        {
            return HuidigSpel.GetHuidigeSpeler().Naam;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Spelscherm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Beurteinde_Click(object sender, EventArgs e)
        {
            if (HuidigSpel.GetHuidigeSpeler().HeeftPretpark() && HuidigSpel.RolSysteemObject.GetZijnDobbelsteenGelijk())
            {
                VoegEventToe(String.Format("{0} heeft twee keer hetzelfde gegooid! Je mag opnieuw dobbelen.", GetHuidigeSpelerNaam()));
            }
            else
            {
                HuidigSpel.WisselBeurt();
            }
            BeurtBegin();
        }

        private void btn_Dobbel_Click(object sender, EventArgs e)
        {
            Dobbel();
            if (HuidigSpel.GetHuidigeSpeler().HeeftRadioToren())
            {
                if (MessageBox.Show(String.Format("Je hebt een {0} gerold. Wil je opnieuw rollen?", HuidigSpel.RolSysteemObject.GetDobbelWaarde()), "Roda JC Stadion melding", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (HuidigSpel.GetHuidigeSpeler().HeeftStation())
                    {
                        if (MessageBox.Show(String.Format("Je gaat opnieuw rollen. Wil je met twee dobbelstenen rollen?", GetHuidigeSpelerNaam()), "Roda JC Stadion melding", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            HuidigSpel.RolSysteemObject.TweeStenen = true;
                        }
                        else
                        {
                            HuidigSpel.RolSysteemObject.TweeStenen = false;
                        }
                    }
                    VoegEventToe(String.Format("{0} gooit opnieuw!", GetHuidigeSpelerNaam()));
                    Dobbel();
                }
            }
            ActiveerKaarten();
            btn_Dobbel.Enabled = false;
            btn_Beurteinde.Enabled = true;
            btn_Kopen.Enabled = true;
        }

        private string GetAantalVanKaartInTekst(string _naam, bool _isSpeler)
        {
            var target = new List<Kaart>();
            var TargetPlayer = HuidigSpel.GetHuidigeSpeler();
            int aantal = 0;
            if (_isSpeler)
            {
                target = HuidigSpel.GetHuidigeSpeler().Gebouwen.ToList();
            }
            else
            {
                target = HuidigSpel.KaartenPot.ToList();
            }
            foreach (var _kaart in target)
            {
                if (_kaart.Naam == _naam)
                {
                    aantal++;
                }
            }
            return aantal.ToString() + "x";
        }

        private void ActiveerKaarten()
        {
            foreach (var _speler in HuidigSpel.Spelers)
            {
                List<Kaart> actieveKaarten = HuidigSpel.GetActieveKaartenVanSpeler(_speler);
                foreach (Gebouw _kaart in actieveKaarten)
                {
                    _kaart.DoeEffect(HuidigSpel);
                    // Jezus, nu moet dit arme spel deze hele kutzooi doen.
                    VoegEventToe(String.Format("{0} heeft een {1}.", HuidigSpel.GetEigenaarKaart(_kaart).Naam, _kaart.Naam));
                    if (_kaart is IedereenKrijgtMunt)
                    {
                        VoegEventToe(String.Format("{0} krijgt {1} ticket(s) van de bank!", HuidigSpel.GetEigenaarKaart(_kaart).Naam, _kaart.BetrokkenMunten.ToString()));                    }
                    else if (_kaart is RollerKrijgtMunt)
                    {
                        VoegEventToe(String.Format("{0} krijgt {1} ticket(s) van de bank!", HuidigSpel.GetEigenaarKaart(_kaart).Naam, _kaart.BetrokkenMunten.ToString()));
                    }
                    else if (_kaart is NeemMuntSpeler)
                    {
                        VoegEventToe(String.Format("{0} krijgt {1} ticket(s) van {2}!", HuidigSpel.GetEigenaarKaart(_kaart).Naam, _kaart.BetrokkenMunten.ToString(), HuidigSpel.GetHuidigeSpeler()));
                    }
                    else if (_kaart is NeemMuntIedereen)
                    {
                        VoegEventToe(String.Format("{0} krijgt {1} ticket(s) van iedereen!", HuidigSpel.GetEigenaarKaart(_kaart).Naam, _kaart.BetrokkenMunten.ToString()));
                    }
                    else if (_kaart is NeemMuntKiezen)
                    {
                        VoegEventToe(String.Format("{0} mag een speler kiezen om {1} tickets van te pakken!", HuidigSpel.GetEigenaarKaart(_kaart).Naam, _kaart.BetrokkenMunten.ToString()));
                        SpelerChecken spelerChecken = new SpelerChecken(HuidigSpel.Spelers);
                        if (spelerChecken.ShowDialog() == DialogResult.OK)
                        {
                            HuidigSpel.NeemMuntKiezenEffect(spelerChecken.GetGeselecteerdeSpeler(), HuidigSpel.GetHuidigeSpeler());
                        }
                        else
                        {
                            VoegEventToe(String.Format("{0} heeft besloten om geen geld af te pakken!", HuidigSpel.GetEigenaarKaart(_kaart).Naam));
                        }
                    }
                    UpdateUI();
                }
            }
        }

        private void VoegEventToe(string _tekst, string _scheider)
        {
            string huidigeTekst = textbox_Events.Text;
            textbox_Events.Text = string.Empty;
            textbox_Events.Text += _tekst;
            textbox_Events.Text += "\n" + _scheider + "\n";
            textbox_Events.Text += huidigeTekst;
        }

        private void VoegEventToe(string _tekst)
        {
            VoegEventToe(_tekst, "-------------");
        }

        private void UpdateKaartenAantal(bool isSpeler)
        {
            lbl_FrituurAantal.Text = GetAantalVanKaartInTekst("Frituur", isSpeler);
            lbl_GaiaSpeeltuinAantal.Text = GetAantalVanKaartInTekst("GaiaZoo Speeltuin", isSpeler);
            lbl_ParkstadTheaterAantal.Text = GetAantalVanKaartInTekst("Parkstad Theater", isSpeler);
            lbl_BrandAantal.Text = GetAantalVanKaartInTekst("Brand Bierbrouwerij", isSpeler);
            lbl_BufkesAantal.Text = GetAantalVanKaartInTekst("Broodje Bufkes", isSpeler);
            lbl_MosaquaAantal.Text = GetAantalVanKaartInTekst("Mosaqua", isSpeler);
            lbl_DrPoolAantal.Text = GetAantalVanKaartInTekst("D'r Pool", isSpeler);
            lbl_EventDesignParkstadAantal.Text = GetAantalVanKaartInTekst("Event Design Parkstad", isSpeler);
            lbl_StadscentrumAantal.Text = GetAantalVanKaartInTekst("Stadscentrum", isSpeler);
            lbl_HofVanGaiaAantal.Text = GetAantalVanKaartInTekst("Hof van Gaia", isSpeler);
            lbl_UmcFestivalAantal.Text = GetAantalVanKaartInTekst("UMC Festival", isSpeler);
            lbl_PinkpopPodiumAantal.Text = GetAantalVanKaartInTekst("Pinkpop Podium", isSpeler);
            lbl_DrJoepAantal.Text = GetAantalVanKaartInTekst("D'r Joep Standbeeld", isSpeler);
            lbl_L1TvStationAantal.Text = GetAantalVanKaartInTekst("L1 TV Station", isSpeler);
            lbl_OmroepLandgraafAantal.Text = GetAantalVanKaartInTekst("Omroep Landgraaf", isSpeler);
        }

        private void UpdateUI()
        {
            lbl_Beurt.Text = String.Format("{0} is aan de beurt!", HuidigSpel.GetHuidigeSpeler().Naam);
            lbl_Tickets.Text = HuidigSpel.GetHuidigeSpeler().Geld.ToString();
            lbl_GeenBezienswaardigheid1.Visible = true;
            lbl_GeenBezienswaardigheid2.Visible = true;
            lbl_GeenBezienswaardigheid3.Visible = true;
            lbl_GeenBezienswaardigheid4.Visible = true;

            if (HuidigSpel.GetHuidigeSpeler().HeeftStation())
            {
                lbl_GeenBezienswaardigheid1.Visible = false;
            }
            if (HuidigSpel.GetHuidigeSpeler().HeeftWinkelCentrum())
            {
                lbl_GeenBezienswaardigheid2.Visible = false;
            }
            if (HuidigSpel.GetHuidigeSpeler().HeeftPretpark())
            {
                lbl_GeenBezienswaardigheid3.Visible = false;
            }
            if (HuidigSpel.GetHuidigeSpeler().HeeftRadioToren())
            {
                lbl_GeenBezienswaardigheid4.Visible = false;
            }
            UpdateKaartenAantal(true);
        }

        /// <summary>
        /// Zet het spel klaar om een nieuwe beurt te doen
        /// </summary>
        private void BeurtBegin()
        {
            UpdateUI();
            lbl_KaartKopen.Visible = false;
            VoegEventToe(String.Format("{0} is aan de beurt!", GetHuidigeSpelerNaam()), "===========================");
            btn_Beurteinde.Enabled = false;
            btn_Kopen.Enabled = false;
            btn_Dobbel.Enabled = true;
            check_TweeDobbelstenen.Checked = false;
            check_TweeDobbelstenen.Enabled = HuidigSpel.GetHuidigeSpeler().HeeftStation();
        }

        private void check_TweeDobbelstenen_CheckedChanged(object sender, EventArgs e)
        {
            HuidigSpel.RolSysteemObject.TweeStenen = check_TweeDobbelstenen.Checked;
        }

        private void btn_Kopen_Click(object sender, EventArgs e)
        {
            btn_Kopen.Enabled = false;
            lbl_KaartKopen.Visible = true;
            UpdateKaartenAantal(false);
        }

        private void img_Bezienswaardigheid1_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Viva la Vida", img_Bezienswaardigheid1);
        }

        private void img_Bezienswaardigheid2_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Continium", img_Bezienswaardigheid2);
        }



        /// <summary>
        /// Voert bepaalde functies uit op basis van de kaartknop die gedrukt is.
        /// </summary>
        /// <param name="_naam"></param>
        /// <param name="picBox"></param>
        private void KaartKnopActivatie(string _naam, PictureBox picBox)
        {
            // Wanneer er een kaart gekopen wordt
            if (lbl_KaartKopen.Visible)
            {
                KaartKopen kaartKopen = new KaartKopen(picBox.Image);
                if (kaartKopen.ShowDialog(this) == DialogResult.Yes)
                {
                    if (!HuidigSpel.KaartKopen(_naam))
                    {
                        MessageBox.Show("Je hebt te weinig tickets of deze kaarten zijn op!", "Kan kaart niet kopen", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    UpdateUI();
                    btn_Kopen.Enabled = false;
                    lbl_KaartKopen.Visible = false;
                    VoegEventToe(String.Format("{0} heeft een \"{1}\" kaart gekocht!", GetHuidigeSpelerNaam(), _naam));
                    foreach (var speler in HuidigSpel.Spelers)
                    {
                        if (speler.HeeftPretpark() && speler.HeeftStation() && speler.HeeftWinkelCentrum() && speler.HeeftRadioToren())
                        {
                            // Speler heeft gewonnen!
                            EindeSpel eindeSpel = new EindeSpel(speler.Naam);
                            eindeSpel.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                KaartVoorbeeld kaartVoorbeeld = new KaartVoorbeeld(picBox.Image);
                kaartVoorbeeld.ShowDialog();
            }
        }

        #region Events

        // Vanaf hier worden alle functies voor alle kaart knoppen geactiveerd.

        private void img_Frituur_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Frituur", img_Frituur);
        }

        private void img_GaiaSpeeltuin_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("GaiaZoo Speeltuin", img_GaiaSpeeltuin);
        }

        private void img_ParkstadTheater_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Parkstad Theater", img_ParkstadTheater);
        }

        private void img_Bezienswaardigheid3_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Drielandenpunt", img_Bezienswaardigheid3);
        }

        private void lbl_BrandAantal_Click(object sender, EventArgs e)
        {

        }
        private void img_Bezienswaardigheid4_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Roda JC Stadion", img_Bezienswaardigheid4);
        }

        private void img_Brand_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Brand Bierbrouwerij", img_Brand);
        }

        private void img_Bufkes_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Broodje Bufkes", img_Bufkes);
        }

        private void img_Mosaqua_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Mosaqua", img_Mosaqua);
        }

        private void img_DrPool_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("D'r Pool", img_DrPool);
        }

        private void img_EventDesignParkstad_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Event Design Parkstad", img_EventDesignParkstad);
        }

        private void img_StadsCentrum_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Stadscentrum", img_StadsCentrum);
        }

        private void img_HofVanGaia_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Hof van Gaia", img_HofVanGaia);
        }

        private void img_UmcFestival_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("UMC Festival", img_UmcFestival);
        }

        private void img_PinkpopPodium_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Pinkpop Podium", img_PinkpopPodium);
        }

        private void img_L1TVStation_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("L1 TV Station", img_L1TVStation);
        }

        private void img_OmroepLandgraaf_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("Omroep Landgraaf", img_OmroepLandgraaf);
        }

        private void img_DrJoep_Click(object sender, EventArgs e)
        {
            KaartKnopActivatie("D'r Joep Standbeeld", img_DrJoep);
        }

        private void lbl_MosaquaAantal_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btn_Opties_Click(object sender, EventArgs e)
        {
            Opties opties = new Opties();
            opties.ShowDialog(this);
        }

        private void btn_Spelers_Click(object sender, EventArgs e)
        {
            SpelerChecken spelerChecken = new SpelerChecken(HuidigSpel.Spelers);
            if (spelerChecken.ShowDialog(this) == DialogResult.OK)
            {
                KaartChecken kaartChecken = new KaartChecken(spelerChecken.GetGeselecteerdeSpeler());
                kaartChecken.ShowDialog();
            }
        }
    }
}
