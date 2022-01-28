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
    public partial class KaartKiezen : Form
    {
        Speler HuidigeSpeler;
        public KaartKiezen(Speler speler)
        {
            InitializeComponent();
            HuidigeSpeler = speler;
            lbl_SpelerAnnouncement.Text = String.Format("Selecteer kaart van {0}", HuidigeSpeler.Naam);
            // Geen bezienswaardigheden vanwege het feit dat het leeuwen zijn
            foreach (Gebouw kaart in speler.Gebouwen)
            {
                if (kaart.Icoon != Iconen.Leeuw)
                {
                    lb_Kaarten.Items.Add(kaart.Naam);
                }
            }
        }

        public Kaart GetGekozenKaart()
        {
            foreach (var kaart in HuidigeSpeler.Gebouwen)
            {
                if (kaart.Naam == (string)lb_Kaarten.SelectedItem)
                {
                    return kaart;
                }
            }
            return null;
        }

        private void lb_Kaarten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
