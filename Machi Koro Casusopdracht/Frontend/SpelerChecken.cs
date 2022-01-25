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
        public SpelerChecken(List<Speler> _spelerLijst)
        {
            InitializeComponent();
            foreach (var speler in _spelerLijst)
            {
                lb_SpelerLijst.Items.Add(speler.Naam);
            }
        }
    }
}
