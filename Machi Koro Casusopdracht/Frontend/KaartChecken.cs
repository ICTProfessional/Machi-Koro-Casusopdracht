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
    public partial class KaartChecken : Form
    {
        Speler geselecteerdeSpeler;
        public KaartChecken(Speler _speler)
        {
            InitializeComponent();
            geselecteerdeSpeler = _speler;
            UpdateKaartenAantal(true);
            lbl_Tickets.Text = _speler.Geld.ToString();
        }

        private void UpdateKaartenAantal(bool isSpeler)
        {
            if (geselecteerdeSpeler.HeeftStation())
            {
                lbl_GeenBezienswaardigheid1.Visible = false;
            }
            if (geselecteerdeSpeler.HeeftWinkelCentrum())
            {
                lbl_GeenBezienswaardigheid2.Visible = false;
            }
            if (geselecteerdeSpeler.HeeftPretpark())
            {
                lbl_GeenBezienswaardigheid3.Visible = false;
            }
            if (geselecteerdeSpeler.HeeftRadioToren())
            {
                lbl_GeenBezienswaardigheid4.Visible = false;
            }
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

        private string GetAantalVanKaartInTekst(string _naam, bool _isSpeler)
        {
            var target = new List<Kaart>();
            var TargetPlayer = geselecteerdeSpeler;
            _isSpeler = true;
            int aantal = 0;
            if (_isSpeler)
            {
                target = geselecteerdeSpeler.Gebouwen.ToList();
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

        private void img_Bezienswaardigheid1_Click(object sender, EventArgs e)
        {

        }

        private void KaartChecken_Load(object sender, EventArgs e)
        {

        }

        private void img_Bufkes_Click(object sender, EventArgs e)
        {

        }
    }
}
