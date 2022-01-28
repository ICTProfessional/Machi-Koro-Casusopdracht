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
    public partial class SpelerChecken : Form
    {
        List<Speler> spelerLijst = new List<Speler>();
        public SpelerChecken(List<Speler> _spelerLijst)
        {
            InitializeComponent();
            foreach (var speler in _spelerLijst)
            {
                lb_SpelerLijst.Items.Add(speler.Naam);
            }
            spelerLijst = _spelerLijst;
        }

        public Speler GetGeselecteerdeSpeler()
        {
            foreach (var speler in spelerLijst)
            {
                if ((string)lb_SpelerLijst.SelectedItem == speler.Naam)
                {
                    return speler;
                }
            }
            return new Speler("aa");
        }

        private void lb_SpelerLijst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
